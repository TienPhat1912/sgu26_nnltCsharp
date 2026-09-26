using System;

namespace TH01.bai09
{
    public class Bai09
    {
        public void TimMinMax(double a, double b, double c, out double min, out double max)
        {
            min = Math.Min(a, Math.Min(b, c));
            max = Math.Max(a, Math.Max(b, c));
        }

        public static void Main(string[] args)
        {
            Console.Write("a: ");
            double a = double.Parse(Console.ReadLine()!);
            Console.Write("b: ");
            double b = double.Parse(Console.ReadLine()!);
            Console.Write("c: ");
            double c = double.Parse(Console.ReadLine()!);
            new Bai09().TimMinMax(a, b, c, out double min, out double max);
            Console.WriteLine($"Nho nhat: {min}; lon nhat: {max}");
        }
    }
}
