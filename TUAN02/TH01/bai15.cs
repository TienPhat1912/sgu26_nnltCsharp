using System;
using System.Collections.Generic;
using System.Linq;

namespace TH01.bai15
{
    public class MangSoNguyen
    {
        private int[] data;
        // params cho phep new MangSoNguyen(1, 2, 3) hoac truyen mot mang.
        public MangSoNguyen(params int[] values)
        {
            data = (int[])values.Clone();
        }

        public void Nhap()
        {
            Console.Write("So phan tu: ");
            int soPhanTu = int.Parse(Console.ReadLine()!);
            data = new int[soPhanTu];
            for (int i = 0; i < data.Length; i++)
            {
                Console.Write($"a[{i}]: ");
                data[i] = int.Parse(Console.ReadLine()!);
            }
        }

        public void Xuat() => Console.WriteLine("Mang: " + string.Join(" ", data));
        public int TimMax()
        {
            if (data.Length == 0)
            {
                throw new InvalidOperationException("Mang rong khong co max.");
            }

            int max = data[0];
            foreach (int x in data)
            {
                if (x > max)
                {
                    max = x;
                }
            }

            return max;
        }

        public int TimMin()
        {
            if (data.Length == 0)
            {
                throw new InvalidOperationException("Mang rong khong co min.");
            }

            int min = data[0];
            foreach (int x in data)
            {
                if (x < min)
                {
                    min = x;
                }
            }

            return min;
        }

        public bool LaSoNguyenTo(int value)
        {
            if (value < 2)
            {
                return false;
            }

            for (int d = 2; d <= value / d; d++)
            {
                if (value % d == 0)
                {
                    return false;
                }
            }

            return true;
        }

        public int[] CacSoNguyenTo()
        {
            List<int> result = new();
            foreach (int x in data)
            {
                if (LaSoNguyenTo(x))
                {
                    result.Add(x);
                }
            }

            return result.ToArray();
        }

        public static void Main(string[] args)
        {
            MangSoNguyen a = new();
            a.Nhap();
            a.Xuat();
            if (a.data.Length == 0)
            {
                Console.WriteLine("Mang rong khong co min/max.");
            }
            else
            {
                Console.WriteLine($"Min = {a.TimMin()}; Max = {a.TimMax()}");
            }

            Console.WriteLine("Cac so nguyen to: " + string.Join(" ", a.CacSoNguyenTo()));
        }
    }
}
