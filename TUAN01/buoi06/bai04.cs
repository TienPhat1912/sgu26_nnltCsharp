using System;

namespace NMLT.Buoi06
{
    class KiemTraSoHoanHao
    {
        public static void Main(string[] args)
        {
            Console.Write("Moi ban nhap n: ");
            int n = int.Parse(Console.ReadLine());

            int tongUoc = 0;
            for (int i = 1; i <= n / 2; i++)
            {
                if (n % i == 0)
                    tongUoc += i;
            }

            if (tongUoc == n && n > 0)
                Console.WriteLine("{0} la so hoan hao.", n);
            else
                Console.WriteLine("{0} khong la so hoan hao.", n);

            Console.Read();
        }
    }
}
