using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace TH02.bai2_1
{
    public class ArrayPoint
    {
        private readonly ArrayList points = new();
        public int Count => points.Count;

        public Point this[int i] { get => (Point)points[i]!; set => points[i] = value ?? throw new ArgumentNullException(nameof(value)); }

        public ArrayPoint()
        {
        }

        public ArrayPoint(IEnumerable<Point> source)
        {
            foreach (Point p in source)
            {
                Add(new Point(p));
            }
        }

        public ArrayPoint(ArrayPoint other)
        {
            for (int i = 0; i < other.Count; i++)
            {
                Add(new Point(other[i]));
            }
        }

        public void Add(Point p) => points.Add(p ?? throw new ArgumentNullException(nameof(p)));
        public void Input()
        {
            Console.Write("Số điểm: ");
            int n = int.Parse(Console.ReadLine()!);
            points.Clear();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Điểm {i}:");
                Point p = new();
                p.Input();
                Add(p);
            }
        }

        public void Output()
        {
            for (int i = 0; i < Count; i++)
            {
                Console.WriteLine($"[{i}] = {this[i]}");
            }
        }

        public static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            ArrayPoint a = new();
            a.Input();
            a.Output();
            if (a.Count > 0)
            {
                Console.WriteLine($"Truy cập indexer a[0]: {a[0]}");
            }
        }
    }

    // Lop can dung cho bai nay, dat cung file de chay doc lap.
    public class Point
    {
        private double x, y;
        public double X { get => x; set => x = value; }
        public double Y { get => y; set => y = value; }

        public Point() : this(0, 0)
        {
        }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public Point(Point other) : this(other.X, other.Y)
        {
        }

        public void Input()
        {
            Console.Write("x: ");
            X = double.Parse(Console.ReadLine()!);
            Console.Write("y: ");
            Y = double.Parse(Console.ReadLine()!);
        }

        public void Output() => Console.WriteLine(this);
        public override string ToString() => $"({X}; {Y})";
        public static Point operator +(Point a, Point b) => new(a.X + b.X, a.Y + b.Y);
        public static Point operator -(Point a, Point b) => new(a.X - b.X, a.Y - b.Y);
        public static Point operator -(Point a) => new(-a.X, -a.Y);
        public double KhoangCach(Point b) => KhoangCach(this, b);
        public static double KhoangCach(Point a, Point b) => double.Hypot(a.X - b.X, a.Y - b.Y);
        public Point TrungDiem(Point b) => TrungDiem(this, b);
        public static Point TrungDiem(Point a, Point b) => new(a.X / 2 + b.X / 2, a.Y / 2 + b.Y / 2);
    }
}
