using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace TH02.bai3_5
{
    public abstract class NhanVien
    {
        private string ma = "", hoTen = "";
        public string Ma { get => ma; set => ma = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }

        protected NhanVien()
        {
        }

        protected NhanVien(string ma, string ten)
        {
            Ma = ma;
            HoTen = ten;
        }

        public virtual void Input()
        {
            Console.Write("Mã nhân viên: ");
            Ma = Console.ReadLine()!;
            Console.Write("Họ tên: ");
            HoTen = Console.ReadLine()!;
        }

        public abstract decimal TinhLuong();
        public virtual void Output() => Console.WriteLine($"{Ma} - {HoTen}: {TinhLuong():N0} VNĐ");
        public static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            CongTy c = new();
            c.Input();
            c.Output();
        }
    }

    public class NhanVienKinhDoanh : NhanVien
    {
        private decimal luongCoBan;
        private int soHopDong;
        public decimal LuongCoBan
        {
            get => luongCoBan;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value));
                }

                luongCoBan = value;
            }
        }

        public int SoHopDong
        {
            get => soHopDong;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value));
                }

                soHopDong = value;
            }
        }

        public NhanVienKinhDoanh()
        {
        }

        public NhanVienKinhDoanh(string ma, string ten, decimal luong, int hopDong) : base(ma, ten)
        {
            LuongCoBan = luong;
            SoHopDong = hopDong;
        }

        public override void Input()
        {
            base.Input();
            Console.Write("Lương cơ bản: ");
            LuongCoBan = decimal.Parse(Console.ReadLine()!);
            Console.Write("Số hợp đồng: ");
            SoHopDong = int.Parse(Console.ReadLine()!);
        }

        public override decimal TinhLuong() => LuongCoBan + SoHopDong * 500_000m;
    }

    public class NhanVienSanXuat : NhanVien
    {
        private int soSanPham;
        public int SoSanPham
        {
            get => soSanPham;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value));
                }

                soSanPham = value;
            }
        }

        public NhanVienSanXuat()
        {
        }

        public NhanVienSanXuat(string ma, string ten, int soSanPham) : base(ma, ten)
        {
            SoSanPham = soSanPham;
        }

        public override void Input()
        {
            base.Input();
            Console.Write("Số sản phẩm: ");
            SoSanPham = int.Parse(Console.ReadLine()!);
        }

        public override decimal TinhLuong()
        {
            decimal luong = SoSanPham * 1_000m;
            return SoSanPham > 3000 ? luong * 1.05m : luong;
        }
    }

    public class CongTy
    {
        private readonly List<NhanVien> nhanVien = new();
        public int Count => nhanVien.Count;

        public void Add(NhanVien nv) => nhanVien.Add(nv ?? throw new ArgumentNullException(nameof(nv)));
        public void Input()
        {
            Console.Write("Số nhân viên: ");
            int n = int.Parse(Console.ReadLine()!);
            nhanVien.Clear();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Nhân viên {i + 1}:");
                Console.Write("Loại (1: kinh doanh, 2: sản xuất): ");
                int loai = int.Parse(Console.ReadLine()!);
                NhanVien nv = loai == 1 ? new NhanVienKinhDoanh() : new NhanVienSanXuat();
                nv.Input();
                Add(nv);
            }
        }

        public decimal TongLuong() => nhanVien.Sum(nv => nv.TinhLuong());
        public void Output()
        {
            foreach (NhanVien nv in nhanVien)
            {
                nv.Output();
            }

            Console.WriteLine($"Tổng lương công ty: {TongLuong():N0} VNĐ");
        }
    }
}
