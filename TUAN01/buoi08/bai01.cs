using System;

namespace NMLT.Buoi08
{
    class GiaiThua
    {
        public static long TinhGiaiThua(int n)
        {
            long gt = 1;
            for (int i = 1; i <= n; i++) gt *= i;
            return gt;
        }

        public static long TinhToHop(int k, int n)
        {
            return TinhGiaiThua(n) / (TinhGiaiThua(k) * TinhGiaiThua(n - k));
        }

        public static void Main(string[] args)
        {
            Console.Write("Moi ban nhap k: ");
            int k = int.Parse(Console.ReadLine());
            Console.Write("Moi ban nhap n: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("C({0}, {1}) = {2}.", k, n, TinhToHop(k, n));
            Console.Read();
        }
    }
}
