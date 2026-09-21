using System;

namespace NMLT.Buoi06
{
    class PhanTichThuaSo1
    {
        public static void Main(string[] args)
        {
            Console.Write("Moi ban nhap so nguyen n (n > 1): ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("{0} = ", n);
            int temp = n;
            bool dauTien = true;

            for (int i = 2; i * i <= temp; i++)
            {
                if (temp % i == 0)
                {
                    int dem = 0;
                    while (temp % i == 0)
                    {
                        dem++;
                        temp /= i;
                    }
                    if (!dauTien) Console.Write(" x ");
                    Console.Write(dem > 1 ? "{0}^{1}" : "{0}", i, dem);
                    dauTien = false;
                }
            }
            if (temp > 1)
            {
                if (!dauTien) Console.Write(" x ");
                Console.Write("{0}", temp);
            }
            Console.WriteLine();
            Console.Read();
        }
    }
}
