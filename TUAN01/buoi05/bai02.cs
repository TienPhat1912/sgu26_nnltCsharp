using System;

namespace NMLT.Buoi05
{
    class GiaTriBieuThuc
    {
        public static void Main(string[] args)
        {
            Console.Write("Moi ban nhap so nguyen n: ");
            int n = int.Parse(Console.ReadLine());

            double s1 = 0;
            for (int i = 1; i <= n; i++)
            {
                s1 += 1.0 / i;
            }

            double s2 = 0;
            int dau = 1;
            for (int i = n; i >= 1; i--)
            {
                s2 += dau * (1.0 / i);
                dau = -dau;
            }

            Console.WriteLine("S1({0}) = {1:0.00}", n, s1);
            Console.WriteLine("S2({0}) = {1:0.00}", n, s2);
            Console.Read();
        }
    }
}
