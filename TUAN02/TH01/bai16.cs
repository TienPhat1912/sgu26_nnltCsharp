using System;
using System.Globalization;

namespace TH01.bai16
{
    public class DanhSachHoTen
    {
        private string[] hoTen;
        public DanhSachHoTen(params string[] values)
        {
            hoTen = (string[])values.Clone();
        }

        public void Nhap()
        {
            Console.Write("So nguoi: ");
            int soNguoi = int.Parse(Console.ReadLine()!);
            hoTen = new string[soNguoi];
            for (int i = 0; i < hoTen.Length; i++)
            {
                Console.Write($"Ho ten nguoi {i + 1}: ");
                string tenNhap = Console.ReadLine()!;
                hoTen[i] = tenNhap.Trim();
            }
        }

        public void SapXep()
        {
            // So sanh toan bo ho ten theo tieng Viet, khong phan biet hoa thuong.
            Array.Sort(hoTen, StringComparer.Create(CultureInfo.GetCultureInfo("vi-VN"), true));
        }

        public string[] ToArray() => (string[])hoTen.Clone();
        public void Xuat()
        {
            foreach (string ten in hoTen)
            {
                Console.WriteLine(ten);
            }
        }

        public static void Main(string[] args)
        {
            DanhSachHoTen a = new();
            a.Nhap();
            a.SapXep();
            a.Xuat();
        }
    }
}
