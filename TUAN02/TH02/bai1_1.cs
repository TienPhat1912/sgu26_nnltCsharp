using System;
using System.Text;

namespace TH02.bai1_1
{
    public class SinhVien
    {
        private string hoTen = "Chưa đặt tên";
        private int namSinh = DateTime.Now.Year;
        public string HoTen { get => hoTen; set => hoTen = value; }

        public int NamSinh
        {
            get => namSinh;
            set
            {
                if (value < 1 || value > DateTime.Now.Year)
                {
                    throw new ArgumentOutOfRangeException(nameof(value));
                }

                namSinh = value;
            }
        }

        public SinhVien()
        {
        }

        public SinhVien(string hoTen, int namSinh)
        {
            HoTen = hoTen;
            NamSinh = namSinh;
        }

        public SinhVien(SinhVien other) : this(other.HoTen, other.NamSinh)
        {
        }

        public int TinhTuoi() => DateTime.Now.Year - NamSinh;
        public void Input()
        {
            Console.Write("Họ tên: ");
            HoTen = Console.ReadLine()!;
            Console.Write("Năm sinh: ");
            NamSinh = int.Parse(Console.ReadLine()!);
        }

        public void Output() => Console.WriteLine($"{HoTen}, sinh năm {NamSinh}, tuổi: {TinhTuoi()}");
        public static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            SinhVien x = new();
            x.Input();
            x.Output();
        }
    }
}
