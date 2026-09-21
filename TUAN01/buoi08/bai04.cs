using System;

namespace NMLT.Buoi08
{
    class DemChuSo
    {
        public static int DemXuatHien(long n, int digit)
        {
            int dem = 0;
            long temp = Math.Abs(n);
            while (temp > 0)
            {
                if (temp % 10 == digit) dem++;
                temp /= 10;
            }
            return dem;
        }

        public static void ThongKeChuSo(long n)
        {
            for (int d = 0; d <= 9; d++)
            {
                int dem = DemXuatHien(n, d);
                if (dem > 0)
                {
                    Console.WriteLine("Chu so {0} xuat hien {1} lan.", d, dem);
                }
            }
        }

        public static void Main(string[] args)
        {
            Console.Write("Moi ban nhap so nguyen n: ");
            long n = long.Parse(Console.ReadLine());

            ThongKeChuSo(n);
            Console.Read();
        }
    }
}
