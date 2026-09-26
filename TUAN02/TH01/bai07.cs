using System;

namespace TH01.bai07
{
    public class Bai07
    {
        private int n;
        public Bai07(int n = 0)
        {
            this.n = n;
        }

        public bool LaSoNguyenTo(int value)
        {
            if (value < 2)
            {
                return false;
            }

            for (int d = 2; d <= value / d; d++)
            {
                if (value % d == 0)
                {
                    return false;
                }
            }

            return true;
        }

        public void Nhap()
        {
            Console.Write("Nhap n: ");
            n = int.Parse(Console.ReadLine()!);
        }

        public void Xuat() => Console.WriteLine($"{n} " + (LaSoNguyenTo(n) ? "la so nguyen to." : "khong la so nguyen to."));
        public static void Main(string[] args)
        {
            Bai07 x = new();
            x.Nhap();
            x.Xuat();
        }
    }
}
