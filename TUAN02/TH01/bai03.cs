using System;

namespace TH01.bai03
{
    class Bai03
    {
        public static void Main(string[] args)
        {
            Console.Write("Nhap so nguyen x: ");
            int x = int.Parse(Console.ReadLine()!);
            Console.Write("Nhap so nguyen y: ");
            int y = int.Parse(Console.ReadLine()!);

            if (x == 0 && y < 0)
            {
                Console.WriteLine("Khong the tinh 0 mu so am.");
                return;
            }

            double ketQua = Math.Pow(x, y);
            Console.WriteLine("Ket qua {0} mu {1} la: {2}", x, y, ketQua);
        }
    }
}
