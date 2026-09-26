using System;

namespace TH01.bai04
{
    class Bai04
    {
        public static void Main(string[] args)
        {
            Console.Write("Nhap so nguyen x: ");
            if (!int.TryParse(Console.ReadLine(), out int x))
            {
                Console.WriteLine("Loi: x khong phai so nguyen Int32 hop le.");
                return;
            }

            Console.Write("Nhap so nguyen y: ");
            if (!int.TryParse(Console.ReadLine(), out int y))
            {
                Console.WriteLine("Loi: y khong phai so nguyen Int32 hop le.");
                return;
            }

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
