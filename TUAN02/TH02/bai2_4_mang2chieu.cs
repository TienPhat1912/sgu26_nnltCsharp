using System;
using System.Text;
using System.Collections.Generic;

namespace TH02.bai2_4_mang2chieu
{
    public class MangHaiChieu
    {
        private int[,] data;
        public int SoDong => data.GetLength(0);
        public int SoCot => data.GetLength(1);

        public int this[int i, int j] { get => data[i, j]; set => data[i, j] = value; }

        public MangHaiChieu() : this(0, 0)
        {
        }

        public MangHaiChieu(int n, int m)
        {
            if (n < 0 || m < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(n), "Kích thước phải không âm.");
            }

            data = new int[n, m];
        }

        public MangHaiChieu(int[,] source)
        {
            data = (int[,])source.Clone();
        }

        public MangHaiChieu(MangHaiChieu other) : this(other.data)
        {
        }

        public void Input()
        {
            Console.Write("Số dòng: ");
            int n = int.Parse(Console.ReadLine()!);
            Console.Write("Số cột: ");
            int m = int.Parse(Console.ReadLine()!);
            data = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"a[{i},{j}]: ");
                    data[i, j] = int.Parse(Console.ReadLine()!);
                }
            }
        }

        public static bool LaSoNguyenTo(int n)
        {
            if (n < 2)
            {
                return false;
            }

            for (int d = 2; d <= n / d; d++)
            {
                if (n % d == 0)
                {
                    return false;
                }
            }

            return true;
        }

        public List<int> TimSoNguyenTo()
        {
            List<int> result = new();
            foreach (int x in data)
            {
                if (LaSoNguyenTo(x))
                {
                    result.Add(x);
                }
            }

            return result;
        }

        public void Output()
        {
            for (int i = 0; i < SoDong; i++)
            {
                for (int j = 0; j < SoCot; j++)
                {
                    Console.Write($"{data[i, j], 8}");
                }

                Console.WriteLine();
            }
        }

        public static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            MangHaiChieu a = new();
            a.Input();
            a.Output();
            Console.WriteLine("Các số nguyên tố: " + string.Join(" ", a.TimSoNguyenTo()));
        }
    }
}
