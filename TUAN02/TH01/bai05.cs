using System;

namespace TH01.bai05
{
    public static class Bai05
    {
        public static void Main(string[] args)
        {
            double x = 0;
            double y = 0;
            bool daNhap = false;
            while (true)
            {
                Console.WriteLine("\nMENU\n1. Nhap hai gia tri so thuc cho x, y\n2. Tinh x^y\n3. Tinh can bac 2 cua x va y\n4. Thoat");
                Console.Write("Chon chuc nang: ");
                int choice = int.Parse(Console.ReadLine()!);
                if (choice == 4)
                {
                    return;
                }

                if (choice == 1)
                {
                    Console.Write("x: ");
                    x = double.Parse(Console.ReadLine()!);
                    Console.Write("y: ");
                    y = double.Parse(Console.ReadLine()!);
                    daNhap = true;
                }
                else if (choice == 2 || choice == 3)
                {
                    if (!daNhap)
                    {
                        Console.WriteLine("Vui long nhap x, y truoc.");
                        continue;
                    }

                    if (choice == 2)
                    {
                        double result = Math.Pow(x, y);
                        Console.WriteLine(double.IsNaN(result) || (x == 0 && y < 0) ? "Luy thua khong xac dinh trong tap so thuc." : double.IsInfinity(result) ? "Ket qua vuot pham vi double." : $"x^y = {result}");
                    }
                    else
                    {
                        Console.WriteLine(x < 0 ? "x khong co can bac hai thuc." : $"Can bac 2 cua x = {Math.Sqrt(x)}");
                        Console.WriteLine(y < 0 ? "y khong co can bac hai thuc." : $"Can bac 2 cua y = {Math.Sqrt(y)}");
                    }
                }
                else
                {
                    Console.WriteLine("Lua chon khong hop le.");
                }
            }
        }
    }
}
