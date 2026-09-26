using System;
using System.Text;
using System.Numerics;

namespace TH02.bai1_4
{
    // BigInteger giúp phép nhân chéo và cộng nhiều phân số không tràn số nguyên.
    public sealed class PhanSo : IEquatable<PhanSo>, IComparable<PhanSo>
    {
        private readonly BigInteger tu, mau;
        public BigInteger Tu => tu;
        public BigInteger Mau => mau;

        public PhanSo() : this(0, 1)
        {
        }

        public PhanSo(BigInteger tu) : this(tu, 1)
        {
        }

        public PhanSo(PhanSo other) : this(other.Tu, other.Mau)
        {
        }

        public PhanSo(BigInteger tu, BigInteger mau)
        {
            if (mau.IsZero)
            {
                throw new DivideByZeroException("Mẫu số không được bằng 0.");
            }

            if (mau.Sign < 0)
            {
                tu = -tu;
                mau = -mau;
            }

            BigInteger gcd = BigInteger.GreatestCommonDivisor(BigInteger.Abs(tu), mau);
            this.tu = tu / gcd;
            this.mau = mau / gcd;
        }

        public static PhanSo Input()
        {
            Console.Write("Tử: ");
            int tu = int.Parse(Console.ReadLine()!);
            int mau;
            do
            {
                Console.Write("Mẫu (khác 0): ");
                mau = int.Parse(Console.ReadLine()!);
            }
            while (mau == 0);
            return new PhanSo(tu, mau);
        }

        public void Output() => Console.WriteLine(this);
        public override string ToString() => Mau.IsOne ? Tu.ToString() : $"{Tu}/{Mau}";
        public static PhanSo operator +(PhanSo a) => new(a);
        public static PhanSo operator -(PhanSo a) => new(-a.Tu, a.Mau);
        public static PhanSo operator +(PhanSo a, PhanSo b) => new(a.Tu * b.Mau + b.Tu * a.Mau, a.Mau * b.Mau);
        public static PhanSo operator -(PhanSo a, PhanSo b) => a + (-b);
        public static PhanSo operator *(PhanSo a, PhanSo b) => new(a.Tu * b.Tu, a.Mau * b.Mau);
        public static PhanSo operator /(PhanSo a, PhanSo b) => new(a.Tu * b.Mau, a.Mau * b.Tu);
        public int CompareTo(PhanSo? other) => other is null ? 1 : (Tu * other.Mau).CompareTo(other.Tu * Mau);
        public bool Equals(PhanSo? other) => other is not null && Tu == other.Tu && Mau == other.Mau;
        public override bool Equals(object? obj) => obj is PhanSo other && Equals(other);
        public override int GetHashCode() => HashCode.Combine(Tu, Mau);
        public static bool operator ==(PhanSo? a, PhanSo? b) => ReferenceEquals(a, b) || (a is not null && a.Equals(b));
        public static bool operator !=(PhanSo? a, PhanSo? b) => !(a == b);
        public static bool operator <(PhanSo a, PhanSo b) => a.CompareTo(b) < 0;
        public static bool operator>(PhanSo a, PhanSo b) => a.CompareTo(b) > 0;
        public static bool operator <=(PhanSo a, PhanSo b) => a.CompareTo(b) <= 0;
        public static bool operator >=(PhanSo a, PhanSo b) => a.CompareTo(b) >= 0;
        public static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Phân số A:");
            PhanSo a = PhanSo.Input();
            Console.WriteLine("Phân số B:");
            PhanSo b = PhanSo.Input();
            Console.WriteLine($"A = {a}; B = {b}; +A = {+a}; -A = {-a}");
            Console.WriteLine($"A+B = {a + b}; A-B = {a - b}; A*B = {a * b}");
            Console.WriteLine(b.Tu.IsZero ? "Không thể chia cho phân số 0." : $"A/B = {a / b}");
            Console.WriteLine($"A>B: {a > b}; A<B: {a < b}; A>=B: {a >= b}; A<=B: {a <= b}; A==B: {a == b}; A!=B: {a != b}");
        }
    }
}
