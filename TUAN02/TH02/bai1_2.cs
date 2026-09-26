
namespace TH02.bai1_2
{
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
        public static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            Point a = new();
            Point b = new();
            Console.WriteLine("Điểm A:");
            a.Input();
            Console.WriteLine("Điểm B:");
            b.Input();
            Console.WriteLine($"A = {a}; B = {b}; A+B = {a + b}; A-B = {a - b}; -A = {-a}");
            Console.WriteLine($"Khoảng cách (thành viên): {a.KhoangCach(b)}; (tĩnh): {Point.KhoangCach(a, b)}");
            Console.WriteLine($"Trung điểm (thành viên): {a.TrungDiem(b)}; (tĩnh): {Point.TrungDiem(a, b)}");
        }
    }
}
