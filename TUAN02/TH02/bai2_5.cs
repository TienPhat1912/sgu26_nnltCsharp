using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace TH02.bai2_5
{
    public class NhanVienPhongBan
    {
        private string hoTen = "";
        private decimal mucLuong;
        private int soNgayVang;
        public string HoTen { get => hoTen; set => hoTen = value; }

        public decimal MucLuong
        {
            get => mucLuong;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value));
                }

                mucLuong = value;
            }
        }

        public int SoNgayVang
        {
            get => soNgayVang;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value));
                }

                soNgayVang = value;
            }
        }

        public NhanVienPhongBan()
        {
        }

        public NhanVienPhongBan(string ten, decimal luong, int vang)
        {
            HoTen = ten;
            MucLuong = luong;
            SoNgayVang = vang;
        }

        public NhanVienPhongBan(NhanVienPhongBan other) : this(other.HoTen, other.MucLuong, other.SoNgayVang)
        {
        }

        public decimal TinhLuong() => MucLuong - SoNgayVang * 100_000m;
        public void Input()
        {
            Console.Write("Họ tên: ");
            HoTen = Console.ReadLine()!;
            Console.Write("Mức lương: ");
            MucLuong = decimal.Parse(Console.ReadLine()!);
            Console.Write("Số ngày vắng: ");
            SoNgayVang = int.Parse(Console.ReadLine()!);
        }

        public void Output() => Console.WriteLine($"{HoTen}: {TinhLuong():N0} VNĐ");
        public static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            PhongBan p = new();
            p.Input();
            p.Output();
        }
    }

    public class PhongBan
    {
        private readonly List<NhanVienPhongBan> nhanVien = new();
        public int Count => nhanVien.Count;

        public PhongBan()
        {
        }

        public PhongBan(PhongBan other)
        {
            foreach (NhanVienPhongBan nv in other.nhanVien)
            {
                Add(new NhanVienPhongBan(nv));
            }
        }

        public void Add(NhanVienPhongBan nv) => nhanVien.Add(nv ?? throw new ArgumentNullException(nameof(nv)));
        public decimal TongLuong() => nhanVien.Sum(nv => nv.TinhLuong());
        public void Input()
        {
            Console.Write("Số nhân viên: ");
            int n = int.Parse(Console.ReadLine()!);
            nhanVien.Clear();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Nhân viên {i + 1}:");
                NhanVienPhongBan nv = new();
                nv.Input();
                Add(nv);
            }
        }

        public void Output()
        {
            foreach (NhanVienPhongBan nv in nhanVien)
            {
                nv.Output();
            }

            Console.WriteLine($"Tổng lương: {TongLuong():N0} VNĐ");
        }
    }
}
