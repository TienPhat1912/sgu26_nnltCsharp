using System;

namespace NMLT.Buoi05
{
    class TimBeNhatThoa
    {
        public static void Main(string[] args)
        {
            Console.Write("Moi ban nhap so thuc a: ");
            double a = double.Parse(Console.ReadLine());

            double tong = 0;
            int n = 0;

            while (tong <= a)
            {
                n++;
                tong += 1.0 / n;
            }

            Console.WriteLine("So n be nhat thoa man la: {0} (Tong S = {1:0.00})", n, tong);
            Console.Read();
        }
    }
}
