using System;
using System.Text;

namespace TH01.bai11
{
    public class Bai11
    {
        private string chuoi;
        public Bai11(string chuoi = "")
        {
            this.chuoi = chuoi;
        }

        public string DaoChuoi()
        {
            StringBuilder result = new(chuoi.Length);
            for (int i = chuoi.Length - 1; i >= 0; i--)
            {
                result.Append(chuoi[i]);
            }

            return result.ToString();
        }

        public void Nhap()
        {
            Console.Write("Nhap chuoi: ");
            chuoi = Console.ReadLine()!;
        }

        public void Xuat() => Console.WriteLine($"Chuoi dao: {DaoChuoi()}");
        public static void Main(string[] args)
        {
            Bai11 x = new();
            x.Nhap();
            x.Xuat();
        }
    }
}
