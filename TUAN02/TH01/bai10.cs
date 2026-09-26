using System;

namespace TH01.bai10
{
    public class Bai10
    {
        private string chuoi;
        public Bai10(string chuoi = "")
        {
            this.chuoi = chuoi;
        }

        public bool LaDoiXung()
        {
            for (int i = 0, j = chuoi.Length - 1; i < j; i++, j--)
            {
                if (chuoi[i] != chuoi[j])
                {
                    return false;
                }
            }

            return true;
        }

        public void Nhap()
        {
            Console.Write("Nhap chuoi: ");
            chuoi = Console.ReadLine()!;
        }

        public void Xuat() => Console.WriteLine(LaDoiXung() ? "Chuoi doi xung." : "Chuoi khong doi xung.");
        public static void Main(string[] args)
        {
            Bai10 x = new();
            x.Nhap();
            x.Xuat();
        }
    }
}
