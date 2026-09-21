using System;

namespace NMLT.Buoi08
{
    class LietKeSoHoanHao
    {
        public static bool LaSoHoanHao(int n)
        {
            if (n <= 0) return false;
            int tong = 0;
            for (int i = 1; i <= n / 2; i++)
                if (n % i == 0) tong += i;
            return tong == n;
        }

        public static void LietKeHoanHaoGiam(int n)
        {
            Console.Write("Cac so hoan hao trong doan [1, {0}]: ", n);
            for (int i = n; i >= 1; i--)
            {
                if (LaSoHoanHao(i))
                    Console.Write("{0} ", i);
            }
            Console.WriteLine();
        }

        public static void Main(string[] args)
        {
            Console.Write("Moi ban nhap so n: ");
            int n = int.Parse(Console.ReadLine());

            LietKeHoanHaoGiam(n);
            Console.Read();
        }
    }
}
