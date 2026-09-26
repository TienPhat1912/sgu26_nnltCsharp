using System;

namespace TH01.bai12
{
    public class Bai12
    {
        private string chuoi;
        public Bai12(string chuoi = "")
        {
            this.chuoi = chuoi;
        }

        public string ChuThuong() => chuoi.ToLowerInvariant();
        public string ChuHoa() => chuoi.ToUpperInvariant();
        public int DemTu() => chuoi.Split((char[]? )null, StringSplitOptions.RemoveEmptyEntries).Length;
        public void Nhap()
        {
            Console.Write("Nhap chuoi: ");
            chuoi = Console.ReadLine()!;
        }

        public void Xuat()
        {
            Console.WriteLine($"Chu thuong: {ChuThuong()}\nChu hoa: {ChuHoa()}\nSo tu: {DemTu()}");
        }

        public static void Main(string[] args)
        {
            Bai12 x = new();
            x.Nhap();
            x.Xuat();
        }
    }
}
