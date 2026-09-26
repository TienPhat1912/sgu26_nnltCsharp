using System;

namespace TH01.bai06
{
    public class Bai06
    {
        private int a, b, c;
        public Bai06() : this(0, 0, 0)
        {
        }

        public Bai06(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public void Nhap()
        {
            Console.Write("Nhap so a: ");
            a = int.Parse(Console.ReadLine()!);
            Console.Write("Nhap so b: ");
            b = int.Parse(Console.ReadLine()!);
            Console.Write("Nhap so c: ");
            c = int.Parse(Console.ReadLine()!);
        }

        public int TimMax() => TimMax(a, b, c);
        // Ba tham so duoc truyen bang tham tri.
        public int TimMax(int x, int y, int z) => Math.Max(x, Math.Max(y, z));
        public void Xuat() => Console.WriteLine($"Ba so: {a}, {b}, {c}; lon nhat: {TimMax()}");
        public static void Main(string[] args)
        {
            Bai06 so = new();
            so.Nhap();
            so.Xuat();
        }
    }
}
