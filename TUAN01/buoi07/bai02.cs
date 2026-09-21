using System;

namespace NMLT.Buoi07
{
    class TinhSoPi
    {
        public static double TinhPi(double epsilon)
        {
            double pi = 0;
            double term = 1.0;
            int i = 0;
            int dau = 1;

            while (4.0 / (2 * i + 1) >= epsilon)
            {
                pi += dau * (4.0 / (2 * i + 1));
                dau = -dau;
                i++;
            }
            return pi;
        }

        public static void Main(string[] args)
        {
            Console.Write("Moi ban nhap do sai so epsilon: ");
            double epsilon = double.Parse(Console.ReadLine());

            double pi = TinhPi(epsilon);
            Console.WriteLine("So pi tinh den do chinh xac {0} la {1}.", epsilon, pi);
            Console.WriteLine("Do sai so thuc te la {0}.", Math.Abs(pi - Math.PI));

            Console.Read();
        }
    }
}
