using System;
using System.Text;
using System.Numerics;
using System.Linq;

namespace TH02.bai2_4_dayphanso
{
    public class DayPhanSo
    {
        private PhanSo[] data;
        public int Count => data.Length;

        public PhanSo this[int i] { get => data[i]; set => data[i] = value ?? throw new ArgumentNullException(nameof(value)); }

        public DayPhanSo() : this(0)
        {
        }

        public DayPhanSo(int n)
        {
            if (n < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(n));
            }

            data = new PhanSo[n];
            for (int i = 0; i < n; i++)
            {
                data[i] = new PhanSo();
            }
        }

        public DayPhanSo(PhanSo[] source)
        {
            data = source.Select(p => new PhanSo(p)).ToArray();
        }

        public DayPhanSo(DayPhanSo other) : this(other.data)
        {
        }

        public void Input()
        {
            Console.Write("Số phân số: ");
            int soPhanSo = int.Parse(Console.ReadLine()!);
            data = new PhanSo[soPhanSo];
            for (int i = 0; i < Count; i++)
            {
                Console.WriteLine($"Phân số {i + 1}:");
                data[i] = PhanSo.Input();
            }
        }

        public PhanSo TinhTong()
        {
            PhanSo sum = new();
            foreach (PhanSo p in data)
            {
                sum += p;
            }

            return sum;
        }

        public void Output() => Console.WriteLine(string.Join("; ", data.Select(p => p.ToString())));
        public static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            DayPhanSo a = new();
            a.Input();
            a.Output();
            Console.WriteLine($"Tổng = {a.TinhTong()}");
        }
    }

    // Lop can dung cho bai nay, dat cung file de chay doc lap.
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
    }
}
