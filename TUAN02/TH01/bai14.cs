using System;

namespace TH01.bai14
{
    public class NhanVien
    {
        private string hoTen;
        private decimal mucLuong;
        private int soNgayVang;
        public NhanVien() : this("", 0, 0)
        {
        }

        public NhanVien(string ten, decimal luong, int vang)
        {
            if (luong < 0 || vang < 0)
            {
                throw new ArgumentException("Luong va so ngay vang phai khong am.");
            }

            hoTen = ten;
            mucLuong = luong;
            soNgayVang = vang;
        }

        public void Nhap()
        {
            Console.Write("Ho ten: ");
            hoTen = Console.ReadLine()!;
            Console.Write("Muc luong: ");
            mucLuong = decimal.Parse(Console.ReadLine()!);
            Console.Write("So ngay vang: ");
            soNgayVang = int.Parse(Console.ReadLine()!);
        }

        public decimal TinhLuong() => mucLuong - soNgayVang * 100_000m;
        public void Xuat() => Console.WriteLine($"{hoTen}: luong = {TinhLuong():N0} VND");
        public static void Main(string[] args)
        {
            NhanVien nv = new();
            nv.Nhap();
            nv.Xuat();
        }
    }
}
