using System;

namespace NMLT.Buoi05
{
    class GiaiThua
    {
        public static void Main(string[] args)
        {
            Console.Write("Moi ban nhap so n (1 <= n <= 12): ");
            int n = int.Parse(Console.ReadLine());
            long gt = 1;

            for (int i = 1; i <= n; i++)
            {
                gt *= i;
            }

            Console.Write("{0}! = 1", n);
            for (int i = 2; i <= n; i++)
                Console.Write(".{0}", i);
            Console.WriteLine(" = {0}.", gt);
            Console.Read();
        }
    }
}
