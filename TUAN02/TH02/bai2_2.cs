using System;
using System.Text;
using System.Collections.Generic;

namespace TH02.bai2_2
{
    public class PersonList
    {
        private readonly List<Person> people = new();
        public int Count => people.Count;

        public Person this[int i] { get => people[i]; set => people[i] = value ?? throw new ArgumentNullException(nameof(value)); }

        public PersonList()
        {
        }

        public PersonList(PersonList other)
        {
            foreach (Person p in other.people)
            {
                Add(new Person(p));
            }
        }

        public void Add(Person x) => people.Add(x ?? throw new ArgumentNullException(nameof(x)));
        public PersonList LivingPeople()
        {
            PersonList result = new();
            foreach (Person p in people)
            {
                if (p.IsLiving())
                {
                    result.Add(new Person(p));
                }
            }

            return result;
        }

        public void Input()
        {
            Console.Write("Số người: ");
            int n = int.Parse(Console.ReadLine()!);
            people.Clear();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Người thứ {i + 1}:");
                Person p = new();
                p.Input();
                Add(p);
            }
        }

        public void Output()
        {
            foreach (Person p in people)
            {
                p.Output();
            }
        }

        public static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            PersonList a = new();
            a.Input();
            a.Output();
            Console.WriteLine("Những người còn sống:");
            a.LivingPeople().Output();
        }
    }

    // Lop can dung cho bai nay, dat cung file de chay doc lap.
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
    }
}
