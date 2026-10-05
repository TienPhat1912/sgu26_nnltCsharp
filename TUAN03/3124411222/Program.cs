using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaiThucHanhLINQ;

class Program
{
    static void Main()
    {
        // Bắt buộc để in được tiếng Việt có dấu trên Console
        Console.OutputEncoding = Encoding.UTF8;

        Bai21();
        Bai22();
        Bai31();
        Bai32();
        Bai51();
        Bai52();
        Bai62();
    }

    // ---------- Hàm hỗ trợ in ----------
    static void TieuDe(string s) => Console.WriteLine($"\n=== {s} ===");
    static void In<T>(IEnumerable<T> ds) => Console.WriteLine(string.Join(", ", ds));

    // =====================================================
    // BÀI 2.1 - Mảng số nguyên
    // =====================================================
    static void Bai21()
    {
        Console.WriteLine("\n########## BÀI 2.1 ##########");
        int[] mangSo = { 50, 42, 16, 3, 9, 8, 12, 7, 24, 0 };

        // a. Chia hết cho 4 và 3 (tức chia hết cho 12)
        TieuDe("2.1a - Chia hết cho 4 và 3 (Query Syntax)");
        var a1 = from x in mangSo where x % 4 == 0 && x % 3 == 0 select x;
        In(a1);
        TieuDe("2.1a - Method Syntax");
        In(mangSo.Where(x => x % 4 == 0 && x % 3 == 0));

        // b. Nhỏ hơn hoặc bằng 3
        TieuDe("2.1b - Nhỏ hơn hoặc bằng 3 (Query Syntax)");
        In(from x in mangSo where x <= 3 select x);
        TieuDe("2.1b - Method Syntax");
        In(mangSo.Where(x => x <= 3));

        // c. Chẵn chia đôi, lẻ giữ nguyên
        TieuDe("2.1c - Chẵn chia đôi, lẻ giữ nguyên (Query Syntax)");
        In(from x in mangSo select x % 2 == 0 ? x / 2 : x);
        TieuDe("2.1c - Method Syntax");
        In(mangSo.Select(x => x % 2 == 0 ? x / 2 : x));
    }

    // =====================================================
    // BÀI 2.2 - Mảng chuỗi
    // =====================================================
    static void Bai22()
    {
        Console.WriteLine("\n########## BÀI 2.2 ##########");
        string[] mangChuoi = { "đầu", "lòng", "hai", "ả", "tố", "nga",
            "Thúy", "Kiều", "là", "chị", "em", "là", "Thúy", "Vân" };

        TieuDe("2.2a - Có 4 ký tự, sắp xếp tăng dần theo ký tự đầu");
        In(from s in mangChuoi where s.Length == 4 orderby s[0] select s);
        In(mangChuoi.Where(s => s.Length == 4).OrderBy(s => s[0]));

        TieuDe("2.2b - <chữ thường> - <CHỮ HOA>");
        In(from s in mangChuoi select $"{s.ToLower()} - {s.ToUpper()}");
        In(mangChuoi.Select(s => $"{s.ToLower()} - {s.ToUpper()}"));

        TieuDe("2.2c - Chứa ký tự 'u'");
        In(from s in mangChuoi where s.Contains('u') select s);
        In(mangChuoi.Where(s => s.Contains('u')));

        TieuDe("2.2d - Bắt đầu bằng chữ in hoa");
        In(from s in mangChuoi where char.IsUpper(s[0]) select s);
        In(mangChuoi.Where(s => char.IsUpper(s[0])));
    }

    // =====================================================
    // BÀI 3.1 - Thống kê mảng số
    // =====================================================
    static void Bai31()
    {
        Console.WriteLine("\n########## BÀI 3.1 ##########");
        int[] mangSo = { 50, 42, 12, 3, 9, 8, 1, 50, 3, 42, 85 };

        TieuDe("3.1a - Đếm phần tử");
        Console.WriteLine($"Tổng số phần tử: {mangSo.Count()}");
        Console.WriteLine($"Số phần tử chẵn: {mangSo.Count(x => x % 2 == 0)}");
        Console.WriteLine($"Số phần tử lẻ  : {mangSo.Count(x => x % 2 != 0)}");

        TieuDe("3.1b - Sum, Max, Min");
        Console.WriteLine($"Tổng: {mangSo.Sum()}");
        Console.WriteLine($"Lớn nhất: {mangSo.Max()}");
        Console.WriteLine($"Nhỏ nhất: {mangSo.Min()}");

        TieuDe("3.1c - Số giá trị khác nhau");
        Console.WriteLine($"Số giá trị khác nhau: {mangSo.Distinct().Count()}");

        TieuDe("3.1d - Nhóm theo số dư khi chia 5");
        var nhom = from x in mangSo group x by x % 5 into g orderby g.Key select g;
        foreach (var g in nhom)
            Console.WriteLine($"Dư {g.Key}: {string.Join(", ", g)}");
    }

    // =====================================================
    // BÀI 3.2 - Thống kê mảng chuỗi
    // =====================================================
    static void Bai32()
    {
        Console.WriteLine("\n########## BÀI 3.2 ##########");
        string[] monAn = { "Bún bò Huế", "Hủ tiếu heo", "Bánh canh", "Bánh mì",
            "Nước Cà phê", "Mì quảng", "Cơm tấm", "Nước Chanh dây", "Mì xào",
            "Bún riêu", "Bánh cuốn", "Mì gói", "Bún chả", "Hủ tiếu Nam vang" };

        TieuDe("3.2a - Ngắn nhất / dài nhất");
        int min = monAn.Min(s => s.Length);
        int max = monAn.Max(s => s.Length);
        Console.WriteLine($"Ngắn nhất ({min} ký tự): {string.Join(" | ", monAn.Where(s => s.Length == min))}");
        Console.WriteLine($"Dài nhất  ({max} ký tự): {string.Join(" | ", monAn.Where(s => s.Length == max))}");

        TieuDe("3.2b - Nhóm theo từ đầu tiên");
        var nhom = monAn.GroupBy(s => s.Split(' ')[0]);
        foreach (var g in nhom)
        {
            Console.WriteLine($"Nhóm \"{g.Key}\":");
            foreach (var s in g) Console.WriteLine($"   - {s}");
        }

        TieuDe("3.2c - Đếm món có từ đầu là 'Bánh'");
        Console.WriteLine(monAn.Count(s => s.Split(' ')[0] == "Bánh"));
    }

    // =====================================================
    // BÀI 5.1 - Truy vấn cơ bản List<MonHoc>
    // =====================================================
    static void Bai51()
    {
        Console.WriteLine("\n########## BÀI 5.1 ##########");
        var ds = DuLieu.DS_Mon();

        TieuDe("5.1a - Tên môn bắt đầu bằng 'Lập trình'");
        var a = from m in ds where m.TenMon.StartsWith("Lập trình") select m.TenMon;
        foreach (var t in a) Console.WriteLine(t);

        TieuDe("5.1b - Hệ CD, số tiết giảm dần, mã môn tăng dần");
        var b = from m in ds
                where m.He == "CD"
                orderby m.SoTiet descending, m.MaMon
                select m;
        foreach (var m in b) Console.WriteLine($"{m.MaMon,-8}{m.TenMon,-40}{m.SoTiet}");

        TieuDe("5.1c - Tên chứa 'web' (Tên môn, Hệ)");
        var c = from m in ds
                where m.TenMon.Contains("web", StringComparison.OrdinalIgnoreCase)
                select new { m.TenMon, m.He };
        foreach (var m in c) Console.WriteLine($"{m.TenMon,-50}{m.He}");

        TieuDe("5.1d - Hệ KTV, tăng dần theo Mã môn");
        var d = ds.Where(m => m.He == "KTV").OrderBy(m => m.MaMon);
        foreach (var m in d) Console.WriteLine($"{m.MaMon,-8}{m.TenMon}");
    }

    // =====================================================
    // BÀI 5.2 - Thống kê List<MonHoc>
    // =====================================================
    static void Bai52()
    {
        Console.WriteLine("\n########## BÀI 5.2 ##########");
        var ds = DuLieu.DS_Mon();

        TieuDe("5.2a - Tổng số môn");
        Console.WriteLine(ds.Count);

        TieuDe("5.2b - Số môn bắt đầu bằng 'Lập trình'");
        Console.WriteLine(ds.Count(m => m.TenMon.StartsWith("Lập trình")));

        TieuDe("5.2c - Tổng số tiết hệ KTV");
        Console.WriteLine(ds.Where(m => m.He == "KTV").Sum(m => m.SoTiet));

        TieuDe("5.2d - Tổng số môn của mỗi hệ");
        var d = from m in ds
                group m by m.He into g
                select new { He = g.Key, TongMon = g.Count() };
        foreach (var x in d) Console.WriteLine($"Hệ: {(x.He == "" ? "(chưa khai báo)" : x.He),-16} Tổng số môn: {x.TongMon}");

        TieuDe("5.2e - Nhóm theo Số tiết, giảm dần");
        var e = from m in ds
                group m by m.SoTiet into g
                orderby g.Key descending
                select new { SoTiet = g.Key, TongMon = g.Count() };
        foreach (var x in e) Console.WriteLine($"Số tiết: {x.SoTiet,-5} Tổng số môn: {x.TongMon}");

        TieuDe("5.2f - Môn có số tiết cao nhất");
        int maxTiet = ds.Max(m => m.SoTiet);
        foreach (var m in ds.Where(m => m.SoTiet == maxTiet))
            Console.WriteLine($"{m.MaMon} | {m.TenMon} | {m.He} | {m.SoTiet}");

        TieuDe("5.2g - Thống kê theo Hệ");
        var g5 = from m in ds
                 group m by m.He into g
                 select new
                 {
                     He = g.Key,
                     TongMon = g.Count(),
                     TongTiet = g.Sum(x => x.SoTiet),
                     TietMax = g.Max(x => x.SoTiet),
                     TietMin = g.Min(x => x.SoTiet)
                 };
        foreach (var x in g5)
            Console.WriteLine($"Hệ {(x.He == "" ? "(trống)" : x.He),-8} | Môn: {x.TongMon,-3} | Tổng tiết: {x.TongTiet,-4} | Max: {x.TietMax,-4} | Min: {x.TietMin}");

        TieuDe("5.2h - Danh sách môn phân nhóm theo Hệ");
        foreach (var g in ds.GroupBy(m => m.He))
        {
            Console.WriteLine($"Hệ: {(g.Key == "" ? "(chưa khai báo)" : g.Key)}");
            foreach (var m in g) Console.WriteLine($"   {m.MaMon,-8}{m.TenMon,-45}{m.SoTiet}");
        }

        TieuDe("5.2i - Nhóm theo Số tiết, tăng dần");
        foreach (var g in ds.GroupBy(m => m.SoTiet).OrderBy(g => g.Key))
        {
            Console.WriteLine($"Số tiết: {g.Key}");
            foreach (var m in g) Console.WriteLine($"   {m.MaMon,-8}{m.TenMon}");
        }

        TieuDe("5.2j - Hệ KTV, nhóm theo học phần (HP2, HP3, ...)");
        var j = ds.Where(m => m.He == "KTV")
                  .OrderBy(m => m.MaMon)
                  .GroupBy(m => m.MaMon.Substring(0, 3));
        foreach (var g in j)
        {
            Console.WriteLine($"Học phần {g.Key}:");
            foreach (var m in g) Console.WriteLine($"   {m.MaMon,-8}{m.TenMon}");
        }

        TieuDe("5.2k - Nhóm theo Hệ, Số tiết > 40, sắp xếp theo Mã môn");
        var k = ds.Where(m => m.SoTiet > 40)
                  .GroupBy(m => m.He)
                  .Select(g => new { He = g.Key, Mons = g.OrderBy(m => m.MaMon) });
        foreach (var g in k)
        {
            Console.WriteLine($"Hệ: {g.He}");
            foreach (var m in g.Mons) Console.WriteLine($"   {m.MaMon,-8}{m.TenMon,-45}{m.SoTiet}");
        }
    }

    // =====================================================
    // BÀI 6.2 - Truy vấn trên hai nguồn dữ liệu
    // =====================================================
    static void Bai62()
    {
        Console.WriteLine("\n########## BÀI 6.2 ##########");
        var dsMon = DuLieu.DS_Mon();
        var dsHe = DuLieu.DS_He();

        // a. Inner join
        TieuDe("6.2a - Inner join: Tên hệ, Mã môn, Tên môn");
        var a = from m in dsMon
                join h in dsHe on m.He equals h.MaHe
                select new { h.TenHe, m.MaMon, m.TenMon };
        foreach (var x in a) Console.WriteLine($"{x.TenHe,-16}{x.MaMon,-8}{x.TenMon}");

        // b. Left outer join (hệ chưa có môn cũng hiện)
        TieuDe("6.2b - Left join: cả hệ chưa có môn học");
        var leftJoin = from h in dsHe
                       join m in dsMon on h.MaHe equals m.He into g
                       from m in g.DefaultIfEmpty()
                       select new KetQua(h.TenHe, m?.MaMon ?? "(chưa có)", m?.TenMon ?? "(chưa có)", m?.SoTiet);
        foreach (var x in leftJoin) Console.WriteLine($"{x.TenHe,-18}{x.MaMon,-10}{x.TenMon}");

        // c. Full outer join = left join + môn chưa có hệ
        TieuDe("6.2c - Full join: hệ chưa có môn + môn chưa khai báo hệ");
        var monChuaHe = from m in dsMon
                        join h in dsHe on m.He equals h.MaHe into g
                        from h in g.DefaultIfEmpty()
                        where h == null
                        select new KetQua("(chưa khai báo hệ)", m.MaMon, m.TenMon, m.SoTiet);
        var full = leftJoin.Concat(monChuaHe);
        foreach (var x in full) Console.WriteLine($"{x.TenHe,-20}{x.MaMon,-10}{x.TenMon}");

        // d. Chỉ phần không khớp
        TieuDe("6.2d - Chỉ hệ chưa có môn và môn chưa khai báo hệ");
        var heChuaMon = dsHe.Where(h => !dsMon.Any(m => m.He == h.MaHe))
                            .Select(h => new KetQua(h.TenHe, "(chưa có)", "(chưa có)", null));
        foreach (var x in heChuaMon.Concat(monChuaHe))
            Console.WriteLine($"{x.TenHe,-20}{x.MaMon,-10}{x.TenMon}");

        // e. 5 môn đầu có số tiết giảm dần
        TieuDe("6.2e - 5 môn có số tiết cao nhất");
        var e = (from m in dsMon
                 join h in dsHe on m.He equals h.MaHe
                 orderby m.SoTiet descending, m.MaMon
                 select new { h.TenHe, m.MaMon, m.TenMon, m.SoTiet }).Take(5);
        foreach (var x in e) Console.WriteLine($"{x.TenHe,-16}{x.MaMon,-8}{x.TenMon,-40}{x.SoTiet}");

        // f. GroupJoin: tổng môn mỗi hệ
        TieuDe("6.2f - Tổng số môn của mỗi hệ");
        var f = dsHe.GroupJoin(dsMon, h => h.MaHe, m => m.He,
                    (h, g) => new { h.MaHe, h.TenHe, TongMon = g.Count() });
        foreach (var x in f) Console.WriteLine($"{x.MaHe,-6}{x.TenHe,-20}{x.TongMon}");

        // g. Số loại Số tiết khác nhau
        TieuDe("6.2g - Số loại Số tiết khác nhau");
        Console.WriteLine(dsMon.Select(m => m.SoTiet).Distinct().Count());

        // h. Môn đầu tiên bắt đầu bằng "Lập trình"
        TieuDe("6.2h - Môn đầu tiên bắt đầu bằng 'Lập trình'");
        var h1 = dsMon.FirstOrDefault(m => m.TenMon.StartsWith("Lập trình"));
        Console.WriteLine(h1 == null ? "Không tìm thấy" : $"{h1.MaMon} | {h1.TenMon} | {h1.He} | {h1.SoTiet}");

        // i. Đánh số thứ tự trong mỗi nhóm (Select có chỉ số)
        TieuDe("6.2i - Môn theo từng hệ, đánh số thứ tự trong nhóm");
        foreach (var g in dsMon.GroupBy(m => m.He))
        {
            Console.WriteLine($"Hệ: {(g.Key == "" ? "(chưa khai báo)" : g.Key)}");
            var dem = g.Select((m, i) => new { STT = i + 1, m.MaMon, m.TenMon });
            foreach (var x in dem) Console.WriteLine($"   {x.STT}. {x.MaMon,-8}{x.TenMon}");
        }
    }
}

// Kiểu dùng chung để Concat các kết quả join (cùng kiểu dữ liệu)
public record KetQua(string TenHe, string MaMon, string TenMon, int? SoTiet);

// =====================================================
// BÀI 4.1 & 6.1 - Lớp dữ liệu
// =====================================================
public class MonHoc
{
    public string MaMon { get; set; } = "";
    public string TenMon { get; set; } = "";
    public string He { get; set; } = "";
    public byte SoTiet { get; set; }
}

public class He
{
    public string MaHe { get; set; } = "";
    public string TenHe { get; set; } = "";
}

public class DuLieu
{
    public static List<MonHoc> DS_Mon()
    {
        return new List<MonHoc>
        {
            new() { MaMon = "HP2_1", TenMon = "Nền tảng C#", He = "KTV", SoTiet = 64 },
            new() { MaMon = "HP2_2", TenMon = "Công nghệ ADO.NET", He = "KTV", SoTiet = 64 },
            new() { MaMon = "HP3_1", TenMon = "Lập trình Windows Forms", He = "KTV", SoTiet = 64 },
            new() { MaMon = "HP3_2", TenMon = "Xây dựng ứng dụng Windows Forms", He = "KTV", SoTiet = 64 },
            new() { MaMon = "HP4_1", TenMon = "Lập trình Web với HTML, CSS và JavaScript", He = "KTV", SoTiet = 64 },
            new() { MaMon = "HP4_2", TenMon = "Xây dựng ứng dụng Web với ASP.NET", He = "KTV", SoTiet = 64 },
            new() { MaMon = "HP5_1", TenMon = "Lập trình CSDL SQL Server căn bản", He = "KTV", SoTiet = 64 },
            new() { MaMon = "HP5_2", TenMon = "Lập trình CSDL SQL Server nâng cao", He = "KTV", SoTiet = 64 },
            new() { MaMon = "JLCB", TenMon = "Joomla cơ bản", He = "CD", SoTiet = 72 },
            new() { MaMon = "LINQ", TenMon = "Language-Integrated Query", He = "CD", SoTiet = 64 },
            new() { MaMon = "DAWEB", TenMon = "Đồ án thực tế Web với ASP.NET", He = "CD", SoTiet = 40 },
            new() { MaMon = "DAWIN", TenMon = "Đồ án thực tế Windows Forms", He = "CD", SoTiet = 40 },
            new() { MaMon = "CC++", TenMon = "Lập trình hướng đối tượng với C/C++", He = "CD", SoTiet = 128 },
            new() { MaMon = "JQUE", TenMon = "JQuery", He = "CD", SoTiet = 22 },
            new() { MaMon = "XML", TenMon = "Công nghệ XML", He = "CD", SoTiet = 32 },
            new() { MaMon = "CRYS", TenMon = "Crystal Report trong Visual Studio", He = "CD", SoTiet = 32 },
            new() { MaMon = "BWEB", TenMon = "HTML, CSS và JavaScript", He = "CD", SoTiet = 32 },
            new() { MaMon = "XYZ", TenMon = "Chưa đặt tên môn", He = "", SoTiet = 0 },
        };
    }

    public static List<He> DS_He()
    {
        return new List<He>
        {
            new() { MaHe = "KTV", TenHe = "Kỹ thuật viên" },
            new() { MaHe = "CD", TenHe = "Chuyên đề" },
            new() { MaHe = "QT", TenHe = "Chứng chỉ quốc tế" },
        };
    }
}