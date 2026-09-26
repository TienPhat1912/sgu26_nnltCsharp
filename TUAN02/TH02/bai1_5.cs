using System;
using System.Text;

namespace TH02.bai1_5
{
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
        public static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            DonThuc p = new();
            p.Input();
            p.Output();
            Console.Write("x: ");
            double x = double.Parse(Console.ReadLine()!);
            Console.WriteLine($"P({x}) = {p.TinhGiaTri(x)}; P'(x) = {p.DaoHam()}");
        }
    }
}
