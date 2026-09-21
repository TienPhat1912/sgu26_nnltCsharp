using System;

namespace NMLT.Buoi05
{
    class TongPhanSoSaiSo
    {
        public static void Main(string[] args)
        {
            Console.Write("Moi ban nhap so a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Moi ban nhap sai so epsilon (<=0.1): ");
            double epsilon = double.Parse(Console.ReadLine());

            double s = 0;
            int i = 0;
            double term = 1.0 / (a + i);

            while (term >= epsilon)
            {
                s += term;
                i++;
                term = 1.0 / (a + i);
            }

            Console.WriteLine("Gia tri cua bieu thuc S(a={0}, epsilon={1}) = {2:0.000}.", a, epsilon, s);
            Console.Read();
        }
    }
}
