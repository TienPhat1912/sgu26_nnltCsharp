using System;

namespace NMLT.Buoi06
{
    class InChuIvaU
    {
        public static void Main(string[] args)
        {
            Console.Write("Moi ban nhap chieu cao h: ");
            int h = int.Parse(Console.ReadLine());

            Console.WriteLine("Chu I va U ung voi h = {0}:", h);

            // In chữ I và U theo từng dòng
            for (int i = 1; i <= h; i++)
            {
                // In 1 dòng chữ I (nét gạch ngang trên/dưới và nét dọc ở giữa)
                if (i == 1 || i == h)
                    Console.Write("*****   ");
                else
                    Console.Write("  *     ");

                // In 1 dòng chữ U (2 cạnh bên và nét đáy)
                if (i == h)
                    Console.WriteLine("*****");
                else
                    Console.WriteLine("*   *");
            }

            Console.Read();
        }
    }
}
