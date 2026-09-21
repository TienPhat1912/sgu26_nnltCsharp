using System;

namespace NMLT.Buoi07
{
    class XuLyChuSo1
    {
        public static void XuLy(int n, int k, ref char csK, ref int tongLe, ref int minLe, ref int maxLe)
        {
            string s = Math.Abs(n).ToString();
            csK = (k >= 1 && k <= s.Length) ? s[k - 1] : ' ';

            tongLe = 0; minLe = 10; maxLe = -1;
            int temp = Math.Abs(n);

            while (temp > 0)
            {
                int cs = temp % 10;
                if (cs % 2 != 0)
                {
                    tongLe += cs;
                    if (cs < minLe) minLe = cs;
                    if (cs > maxLe) maxLe = cs;
                }
                temp /= 10;
            }
        }

        public static void Main(string[] args)
        {
            Console.Write("Moi ban nhap so nguyen n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Moi ban nhap vi tri k: ");
            int k = int.Parse(Console.ReadLine());

            char csK = ' '; int tongLe = 0, minLe = 0, maxLe = 0;
            XuLy(n, k, ref csK, ref tongLe, ref minLe, ref maxLe);

            Console.WriteLine("Chu so o vi tri {0} (tinh tu trai) la {1}.", k, csK);
            Console.WriteLine("Tong cac chu so le: {0}.", tongLe);
            if (maxLe != -1)
                Console.WriteLine("Chu so le nho nhat la {0} va lon nhat la {1}.", minLe, maxLe);

            Console.Read();
        }
    }
}
