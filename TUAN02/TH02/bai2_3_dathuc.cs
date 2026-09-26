using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace TH02.bai2_3_dathuc
{
    public class DaThuc
    {
        private DonThuc[] terms;
        public int Count => terms.Length;

        // Vị trí i luôn biểu diễn hệ số của x^i; sao chép để bảo toàn quy ước này.
        public DonThuc this[int i]
        {
            get => new(terms[i]);
            set
            {
                ArgumentNullException.ThrowIfNull(value);
                if (value.SoMu != i)
                {
                    throw new ArgumentException("Đơn thức thứ i phải có số mũ i.");
                }

                terms[i] = new DonThuc(value);
            }
        }

        public DaThuc() : this(new double[] { 0 })
        {
        }

        public DaThuc(int n)
        {
            if (n < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(n));
            }

            terms = new DonThuc[checked(n + 1)];
            for (int i = 0; i <= n; i++)
            {
                terms[i] = new DonThuc(0, i);
            }
        }

        public DaThuc(double[] heSo) : this(Math.Max(0, heSo.Length - 1))
        {
            for (int i = 0; i < heSo.Length; i++)
            {
                terms[i] = new DonThuc(heSo[i], i);
            }
        }

        public DaThuc(DaThuc other) : this(other.terms.Select(t => t.HeSo).ToArray())
        {
        }

        public void Input()
        {
            Console.Write("Bậc đa thức: ");
            int n = int.Parse(Console.ReadLine()!);
            terms = new DonThuc[n + 1];
            for (int i = 0; i <= n; i++)
            {
                Console.Write($"a[{i}]: ");
                double heSoNhap = double.Parse(Console.ReadLine()!);
                terms[i] = new DonThuc(heSoNhap, i);
            }
        }

        public double TinhGiaTri(double x)
        {
            // Horner: a0 + x*(a1 + x*(a2 + ...)).
            double result = terms[^1].HeSo;
            for (int i = Count - 2; i >= 0; i--)
            {
                result = result * x + terms[i].HeSo;
            }

            return result;
        }

        public override string ToString()
        {
            List<string> parts = new();
            for (int i = Count - 1; i >= 0; i--)
            {
                double a = terms[i].HeSo;
                if (a == 0)
                {
                    continue;
                }

                string sign = parts.Count == 0 ? (a < 0 ? "-" : "") : (a < 0 ? " - " : " + ");
                parts.Add(sign + new DonThuc(Math.Abs(a), i));
            }

            return parts.Count == 0 ? "0" : string.Concat(parts);
        }

        public void Output() => Console.WriteLine(this);
        public static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            DaThuc p = new();
            p.Input();
            p.Output();
            Console.Write("x: ");
            double x = double.Parse(Console.ReadLine()!);
            Console.WriteLine($"P({x}) = {p.TinhGiaTri(x)}");
        }
    }

    // Lop can dung cho bai nay, dat cung file de chay doc lap.
    public class DonThuc
    {
        private double heSo;
        private int soMu;
        public double HeSo { get => heSo; set => heSo = value; }

        public int SoMu
        {
            get => soMu;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value));
                }

                soMu = value;
            }
        }

        public DonThuc() : this(0, 0)
        {
        }

        public DonThuc(double a, int n)
        {
            HeSo = a;
            SoMu = n;
        }

        public DonThuc(DonThuc other) : this(other.HeSo, other.SoMu)
        {
        }

        public double TinhGiaTri(double x) => HeSo == 0 ? 0 : HeSo * Math.Pow(x, SoMu);
        public DonThuc DaoHam() => SoMu == 0 ? new DonThuc() : new DonThuc(HeSo * SoMu, SoMu - 1);
        public void Input()
        {
            Console.Write("Hệ số a: ");
            HeSo = double.Parse(Console.ReadLine()!);
            Console.Write("Số mũ n: ");
            SoMu = int.Parse(Console.ReadLine()!);
        }

        public void Output() => Console.WriteLine(this);
        public override string ToString() => SoMu == 0 || HeSo == 0 ? HeSo.ToString() : $"{HeSo}*x^{SoMu}";
    }
}
