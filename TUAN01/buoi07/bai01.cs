using System;

namespace NMLT.Buoi07
{
    class KiemTraSoHoanHao
    {
        public static bool LaSoHoanHao(int n)
        {
            if (n <= 0) return false;
            int tong = 0;
            for (int i = 1; i <= n / 2; i++)
            {
                if (n % i == 0) tong += i;
            }
            return tong == n;
        }

        public static void Main(string[] args)
        {
            Console.Write("Moi ban nhap n: ");
            int n = int.Parse(Console.ReadLine());

            if (LaSoHoanHao(n))
                Console.WriteLine("{0} la so hoan hao.", n);
            else
                Console.WriteLine("{0} khong la so hoan hao.", n);

            Console.Read();
        }
    }
}
