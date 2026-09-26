using System;
using System.Text;

namespace TH02.bai3_3
{
    public static class SapXepDelegate
    {
        // Comparison<T> là delegate trả về số âm / 0 / số dương.
        public static void Sort<T>(T[] a, Comparison<T> compare)
        {
            ArgumentNullException.ThrowIfNull(a);
            ArgumentNullException.ThrowIfNull(compare);
            for (int i = 1; i < a.Length; i++)
            {
                T key = a[i];
                int j = i - 1;
                while (j >= 0 && compare(a[j], key) > 0)
                {
                    a[j + 1] = a[j];
                    j--;
                }

                a[j + 1] = key;
            }
        }

        public static void Run()
        {
            SanPham[] a = Bai3_1.NhapMang();
            Sort(a, (x, y) => y.Gia.CompareTo(x.Gia));
            Console.WriteLine("Giá giảm dần:");
            foreach (SanPham p in a)
            {
                Console.WriteLine(p);
            }
        }

        public static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            SapXepDelegate.Run();
        }
    }

    // Lop can dung cho bai nay, dat cung file de chay doc lap.
    // Minh họa Array.Sort với đối tượng: tăng dần theo giá, cùng giá thì theo tên.
    public class SanPham : IComparable<SanPham>
    {
        private string ten;
        private decimal gia;
        public string Ten { get => ten; set => ten = value; }

        public decimal Gia
        {
            get => gia;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value));
                }

                gia = value;
            }
        }

        public SanPham() : this("", 0)
        {
        }

        public SanPham(string ten, decimal gia)
        {
            this.ten = ten;
            Gia = gia;
        }

        public SanPham(SanPham other) : this(other.Ten, other.Gia)
        {
        }

        public int CompareTo(SanPham? other)
        {
            if (other is null)
            {
                return 1;
            }

            int result = Gia.CompareTo(other.Gia);
            return result != 0 ? result : string.Compare(Ten, other.Ten, StringComparison.Ordinal);
        }

        public override string ToString() => $"{Ten}: {Gia:N0} VNĐ";
    }

    public static class Bai3_1
    {
        public static SanPham[] NhapMang()
        {
            Console.Write("Số sản phẩm: ");
            int soSanPham = int.Parse(Console.ReadLine()!);
            SanPham[] a = new SanPham[soSanPham];
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine($"Sản phẩm {i + 1}:");
                Console.Write("Tên: ");
                string ten = Console.ReadLine()!;
                Console.Write("Giá: ");
                decimal gia = decimal.Parse(Console.ReadLine()!);
                a[i] = new SanPham(ten, gia);
            }

            return a;
        }

        public static void Run()
        {
            SanPham[] a = NhapMang();
            Array.Sort(a);
            foreach (SanPham p in a)
            {
                Console.WriteLine(p);
            }
        }
    }
}
