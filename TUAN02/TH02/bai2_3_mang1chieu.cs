using System;
using System.Text;

namespace TH02.bai2_3_mang1chieu
{
    public class DaySo
    {
        private int[] data;
        public int Count => data.Length;

        public int this[int i] { get => data[i]; set => data[i] = value; }

        public DaySo() : this(0)
        {
        }

        public DaySo(int n)
        {
            if (n < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(n));
            }

            data = new int[n];
        }

        public DaySo(int[] source)
        {
            data = (int[])source.Clone();
        }

        public DaySo(DaySo other) : this(other.data)
        {
        }

        public void Input()
        {
            Console.Write("Số phần tử: ");
            int soPhanTu = int.Parse(Console.ReadLine()!);
            data = new int[soPhanTu];
            for (int i = 0; i < Count; i++)
            {
                Console.Write($"a[{i}]: ");
                data[i] = int.Parse(Console.ReadLine()!);
            }
        }

        public DaySo TimSoChan() => new(Array.FindAll(data, x => x % 2 == 0));
        public void Output() => Console.WriteLine(string.Join(" ", data));
        public static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            DaySo a = new();
            a.Input();
            a.Output();
            Console.WriteLine("Các số chẵn:");
            a.TimSoChan().Output();
        }
    }
}
