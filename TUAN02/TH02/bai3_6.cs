using System;
using System.Text;
using System.Collections.Generic;

namespace TH02.bai3_6
{
    public abstract class ThiSinh
    {
        private string sbd = "", hoTen = "";
        private double bai1, bai2, bai3;
        public string Sbd { get => sbd; set => sbd = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }

        protected static double KiemTraDiem(double value)
        {
            if (!double.IsFinite(value) || value < 0 || value > 10)
            {
                throw new ArgumentOutOfRangeException(nameof(value));
            }

            return value;
        }

        public double Bai1 { get => bai1; set => bai1 = KiemTraDiem(value); }
        public double Bai2 { get => bai2; set => bai2 = KiemTraDiem(value); }
        public double Bai3 { get => bai3; set => bai3 = KiemTraDiem(value); }
        public abstract double TongDiem { get; }

        protected ThiSinh()
        {
        }

        protected ThiSinh(string sbd, string ten, double b1, double b2, double b3)
        {
            Sbd = sbd;
            HoTen = ten;
            Bai1 = b1;
            Bai2 = b2;
            Bai3 = b3;
        }

        public virtual void Input()
        {
            Console.Write("Số báo danh: ");
            Sbd = Console.ReadLine()!;
            Console.Write("Họ tên: ");
            HoTen = Console.ReadLine()!;
            Console.Write("Điểm bài 1: ");
            Bai1 = double.Parse(Console.ReadLine()!);
            Console.Write("Điểm bài 2: ");
            Bai2 = double.Parse(Console.ReadLine()!);
            Console.Write("Điểm bài 3: ");
            Bai3 = double.Parse(Console.ReadLine()!);
        }

        public virtual void Output() => Console.WriteLine($"{Sbd} - {HoTen}: {TongDiem} điểm");
        public static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            CuocThi c = new();
            c.Input();
            c.Output();
        }
    }

    public class ThiSinhChuyen : ThiSinh
    {
        private double tiengAnh;
        public double TiengAnh { get => tiengAnh; set => tiengAnh = KiemTraDiem(value); }

        public ThiSinhChuyen()
        {
        }

        public ThiSinhChuyen(string sbd, string ten, double b1, double b2, double b3, double anh) : base(sbd, ten, b1, b2, b3)
        {
            TiengAnh = anh;
        }

        // Giữ nguyên các khoảng điểm ghi trong đề (8 < điểm < 9 không được cộng).
        public double DiemThuong => TiengAnh >= 9 && TiengAnh <= 10 ? 2 : TiengAnh >= 7 && TiengAnh <= 8 ? 1 : 0;
        public override double TongDiem => Bai1 + Bai2 + Bai3 + DiemThuong;

        public override void Input()
        {
            base.Input();
            Console.Write("Điểm tiếng Anh: ");
            TiengAnh = double.Parse(Console.ReadLine()!);
        }
    }

    public class ThiSinhSieuCup : ThiSinh
    {
        private double csdl;
        public double Csdl { get => csdl; set => csdl = KiemTraDiem(value); }

        public ThiSinhSieuCup()
        {
        }

        public ThiSinhSieuCup(string sbd, string ten, double b1, double b2, double b3, double csdl) : base(sbd, ten, b1, b2, b3)
        {
            Csdl = csdl;
        }

        public override double TongDiem => Bai1 + Bai2 + Bai3 + Csdl;

        public override void Input()
        {
            base.Input();
            Console.Write("Điểm CSDL: ");
            Csdl = double.Parse(Console.ReadLine()!);
        }
    }

    public class CuocThi
    {
        private readonly List<ThiSinh> thiSinh = new();
        public int Count => thiSinh.Count;

        public void Add(ThiSinh ts) => thiSinh.Add(ts ?? throw new ArgumentNullException(nameof(ts)));
        public void Input()
        {
            Console.Write("Số thí sinh: ");
            int n = int.Parse(Console.ReadLine()!);
            thiSinh.Clear();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Thí sinh {i + 1}:");
                Console.Write("Loại (1: Chuyên, 2: Siêu cúp): ");
                int loai = int.Parse(Console.ReadLine()!);
                ThiSinh ts = loai == 1 ? new ThiSinhChuyen() : new ThiSinhSieuCup();
                ts.Input();
                Add(ts);
            }
        }

        public void Output()
        {
            foreach (ThiSinh ts in thiSinh)
            {
                ts.Output();
            }
        }
    }
}
