using System;
using System.Collections.Generic;
using System.Linq;

namespace TH01.bai17
{
    public class MaTran
    {
        private int[,] data;
        public MaTran()
        {
            data = new int[0, 0];
        }

        public MaTran(int[,] values)
        {
            data = (int[,])values.Clone();
        }

        public void SinhNgauNhien(int n, int m, Random? random = null)
        {
            if (n < 0 || m < 0)
            {
                throw new ArgumentException("Kich thuoc phai khong am.");
            }

            data = new int[n, m];
            random ??= Random.Shared;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    data[i, j] = random.Next(10, 101);
                }
            }
        }

        public void Nhap()
        {
            Console.Write("So dong n: ");
            int n = int.Parse(Console.ReadLine()!);
            Console.Write("So cot m: ");
            int m = int.Parse(Console.ReadLine()!);
            SinhNgauNhien(n, m);
        }

        public void Xuat()
        {
            for (int i = 0; i < data.GetLength(0); i++)
            {
                for (int j = 0; j < data.GetLength(1); j++)
                {
                    Console.Write($"{data[i, j], 5}");
                }

                Console.WriteLine();
            }
        }

        public void TachChanLe(out int[] chan, out int[] le)
        {
            List<int> soChan = new();
            List<int> soLe = new();
            foreach (int x in data)
            {
                if (x % 2 == 0)
                {
                    soChan.Add(x);
                }
                else
                {
                    soLe.Add(x);
                }
            }

            chan = soChan.ToArray();
            le = soLe.ToArray();
        }

        public static void Main(string[] args)
        {
            MaTran a = new();
            a.Nhap();
            a.Xuat();
            a.TachChanLe(out int[] chan, out int[] le);
            Console.WriteLine("Mang chan: " + string.Join(" ", chan));
            Console.WriteLine("Mang le: " + string.Join(" ", le));
        }
    }
}
