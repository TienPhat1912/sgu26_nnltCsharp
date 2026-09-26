using System;

namespace TH01.bai13
{
    public class SinhVien
    {
        private string maSinhVien, hoTen, diaChi;
        private int namThu;
        public SinhVien() : this("", "", "", 1)
        {
        }

        public SinhVien(string ma, string ten, string diaChi, int namThu)
        {
            if (namThu < 1)
            {
                throw new ArgumentOutOfRangeException(nameof(namThu));
            }

            maSinhVien = ma;
            hoTen = ten;
            this.diaChi = diaChi;
            this.namThu = namThu;
        }

        public void Nhap()
        {
            Console.Write("Ma sinh vien: ");
            maSinhVien = Console.ReadLine()!;
            Console.Write("Ho ten: ");
            hoTen = Console.ReadLine()!;
            Console.Write("Dia chi: ");
            diaChi = Console.ReadLine()!;
            Console.Write("Sinh vien nam thu: ");
            namThu = int.Parse(Console.ReadLine()!);
        }

        public void Xuat()
        {
            Console.WriteLine($"Ma: {maSinhVien}\nHo ten: {hoTen}\nDia chi: {diaChi}\nNam thu: {namThu}");
        }

        public static void Main(string[] args)
        {
            SinhVien sv = new();
            sv.Nhap();
            sv.Xuat();
        }
    }
}
