using System;
using System.Text;

namespace TH02.bai1_3
{
    public class Person
    {
        private string id = "", name = "";
        private int yob = DateTime.Now.Year, yod;
        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }

        public int Yob
        {
            get => yob;
            set
            {
                if (value < 1 || value > DateTime.Now.Year || (yod != 0 && value > yod))
                {
                    throw new ArgumentOutOfRangeException(nameof(value));
                }

                yob = value;
            }
        }

        public int Yod
        {
            get => yod;
            set
            {
                if (value != 0 && (value < Yob || value > DateTime.Now.Year))
                {
                    throw new ArgumentOutOfRangeException(nameof(value));
                }

                yod = value;
            }
        }

        public Person()
        {
        }

        public Person(string id, string name, int yob, int yod = 0)
        {
            Id = id;
            Name = name;
            Yob = yob;
            Yod = yod;
        }

        public Person(Person other) : this(other.Id, other.Name, other.Yob, other.Yod)
        {
        }

        public bool IsLiving() => Yod == 0;
        public void Input()
        {
            Console.Write("Mã: ");
            Id = Console.ReadLine()!;
            Console.Write("Họ tên: ");
            Name = Console.ReadLine()!;
            Yod = 0;
            Console.Write("Năm sinh: ");
            Yob = int.Parse(Console.ReadLine()!);
            while (true)
            {
                Console.Write("Năm mất (0 nếu còn sống): ");
                int year = int.Parse(Console.ReadLine()!);
                if (year == 0 || year >= Yob)
                {
                    Yod = year;
                    break;
                }

                Console.WriteLine("Năm mất phải từ năm sinh trở đi.");
            }
        }

        public override string ToString() => $"{Id} - {Name}, sinh {Yob}, " + (IsLiving() ? "còn sống" : $"mất {Yod}");
        public void Output() => Console.WriteLine(this);
        public static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            Person x = new();
            x.Input();
            x.Output();
        }
    }
}
