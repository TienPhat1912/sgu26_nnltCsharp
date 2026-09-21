using System;

namespace NMLT.Buoi08
{
    class RutGonPhanSo
    {
        public static int USCLN(int a, int b)
        {
            a = Math.Abs(a); b = Math.Abs(b);
            while (b != 0)
            {
                int r = a % b;
                a = b;
                b = r;
            }
            return a;
        }

        public static void RutGon(int tu, int mau, out int tuRG, out int mauRG)
        {
            int uscln = USCLN(tu, mau);
            tuRG = tu / uscln;
            mauRG = mau / uscln;
        }

        public static void Main(string[] args)
        {
            Console.Write("Moi ban nhap tu so: ");
            int tu = int.Parse(Console.ReadLine());
            Console.Write("Moi ban nhap mau so: ");
            int mau = int.Parse(Console.ReadLine());

            RutGon(tu, mau, out int tuRG, out int mauRG);
            Console.WriteLine("Phan so {0}/{1} duoc rut gon thanh {2}/{3}.", tu, mau, tuRG, mauRG);

            Console.Read();
        }
    }
}
