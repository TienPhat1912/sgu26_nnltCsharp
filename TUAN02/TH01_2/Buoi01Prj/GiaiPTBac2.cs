using MyLib;

// Doi thanh using MyLib.Buoi01; se gay loi da quan sat:
// CS0234: The type or namespace name 'Buoi01' does not exist in the namespace 'MyLib'.
// Cach sua: using MyLib; va ProjectReference toi ../MyLib/MyLib.csproj.
// Lop thu vien dung thong nhat ten LibBaiTap (de co cho ghi nham LibBai1).
namespace Buoi01Prj;

public class GiaiPTBac2
{
    public static void Main(string[] args)
    {
        Console.Write("Nhap a: ");
        double a = double.Parse(Console.ReadLine()!);
        Console.Write("Nhap b: ");
        double b = double.Parse(Console.ReadLine()!);
        Console.Write("Nhap c: ");
        double c = double.Parse(Console.ReadLine()!);

        double x1 = 0, x2 = 0;
        int sn = LibBaiTap.GiaiPTBac2(a, b, c, ref x1, ref x2);
        Console.WriteLine($"So nghiem: {sn}");
        switch (sn)
        {
            case -1:
                Console.WriteLine("Phuong trinh vo so nghiem.");
                break;
            case 0:
                Console.WriteLine("Phuong trinh vo nghiem.");
                break;
            case 1:
                Console.WriteLine($"x1 = {x1}");
                break;
            case 2:
                Console.WriteLine($"x1 = {x1}");
                Console.WriteLine($"x2 = {x2}");
                break;
        }
    }
}
