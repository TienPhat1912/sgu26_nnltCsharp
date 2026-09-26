using System;

namespace TH01.bai08
{
    public class Bai08
    {
        public void HoanVi(ref double a, ref double b)
        {
            double temp = a;
            a = b;
            b = temp;
        }

        public static void Main(string[] args)
        {
            Console.Write("a: ");
            double a = double.Parse(Console.ReadLine()!);
            Console.Write("b: ");
            double b = double.Parse(Console.ReadLine()!);
            Console.WriteLine($"Truoc hoan vi: a = {a}, b = {b}");
            new Bai08().HoanVi(ref a, ref b);
            Console.WriteLine($"Sau hoan vi: a = {a}, b = {b}");
        }
    }
}
