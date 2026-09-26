using System;
using System.Text;
using System.Collections.Generic;

namespace TH02.bai3_4
{
    public class MenuChooseEventArgs : EventArgs
    {
        public int Choice { get; }

        public MenuChooseEventArgs(int choice)
        {
            Choice = choice;
        }

        public static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            PTBac2Console.Demo();
        }
    }

    public class ConsoleMenu
    {
        private readonly List<string> items = new();
        public string Title { get; set; }

        public event EventHandler<MenuChooseEventArgs>? Choose;
        public ConsoleMenu(string title = "Menu")
        {
            Title = title;
        }

        public void Add(string label) => items.Add(label);
        protected virtual void OnChoose(int choice) => Choose?.Invoke(this, new MenuChooseEventArgs(choice));
        public void Run()
        {
            while (true)
            {
                Console.WriteLine($"\n{Title}");
                for (int i = 0; i < items.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {items[i]}");
                }

                Console.WriteLine("0. Thoát");
                Console.Write("Thực hiện: ");
                int choice = int.Parse(Console.ReadLine()!);
                if (choice == 0)
                {
                    return;
                }

                OnChoose(choice);
            }
        }
    }

    public enum LoaiNghiem
    {
        VoNghiem,
        VoSoNghiem,
        MotNghiem,
        HaiNghiem
    }

    public record KetQuaPT(LoaiNghiem Loai, double X1 = 0, double X2 = 0)
    {
        public override string ToString() => Loai switch
        {
            LoaiNghiem.VoNghiem => "Vô nghiệm trong tập số thực.",
            LoaiNghiem.VoSoNghiem => "Vô số nghiệm.",
            LoaiNghiem.MotNghiem => $"x = {X1:G10}",
            _ => $"x1 = {X1:G10}; x2 = {X2:G10}"};
    }

    public static class PhuongTrinhBacHai
    {
        public static KetQuaPT Giai(double a, double b, double c)
        {
            if (!double.IsFinite(a) || !double.IsFinite(b) || !double.IsFinite(c))
            {
                throw new ArgumentException("Hệ số phải hữu hạn.");
            }

            if (a == 0)
            {
                if (b == 0)
                {
                    return new(c == 0 ? LoaiNghiem.VoSoNghiem : LoaiNghiem.VoNghiem);
                }

                return new(LoaiNghiem.MotNghiem, -c / b);
            }

            // Chuẩn hóa hệ số để giảm nguy cơ tràn khi tính delta.
            double scale = Math.Max(Math.Abs(a), Math.Max(Math.Abs(b), Math.Abs(c)));
            a /= scale;
            b /= scale;
            c /= scale;
            double delta = b * b - 4 * a * c;
            if (delta < 0)
            {
                return new(LoaiNghiem.VoNghiem);
            }

            if (delta == 0)
            {
                return new(LoaiNghiem.MotNghiem, -b / (2 * a));
            }

            // Công thức q hạn chế mất độ chính xác khi trừ hai số gần nhau.
            double q = -0.5 * (b + Math.CopySign(Math.Sqrt(delta), b));
            double x1 = q / a;
            double x2 = c / q;
            return new(LoaiNghiem.HaiNghiem, Math.Min(x1, x2), Math.Max(x1, x2));
        }
    }

    public class PTBac2Console : ConsoleMenu
    {
        private double a, b, c;
        private bool daNhap;
        public PTBac2Console() : base("Giải phương trình ax² + bx + c = 0")
        {
            Add("Nhập hệ số");
            Add("Giải phương trình");
        }

        protected override void OnChoose(int choice)
        {
            if (choice == 1)
            {
                Console.Write("a: ");
                a = double.Parse(Console.ReadLine()!);
                Console.Write("b: ");
                b = double.Parse(Console.ReadLine()!);
                Console.Write("c: ");
                c = double.Parse(Console.ReadLine()!);
                daNhap = true;
            }
            else if (choice == 2)
            {
                Console.WriteLine(daNhap ? PhuongTrinhBacHai.Giai(a, b, c).ToString() : "Hãy nhập hệ số trước.");
            }

            base.OnChoose(choice);
        }

        public static void Demo()
        {
            PTBac2Console app = new();
            app.Choose += (_, e) => Console.WriteLine($"Bạn thực hiện chức năng {e.Choice}.");
            app.Run();
        }
    }
}
