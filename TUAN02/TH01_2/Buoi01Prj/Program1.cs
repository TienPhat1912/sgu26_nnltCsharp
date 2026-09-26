namespace Buoi01Prj;

// Bai 4 - Loi da quan sat khi bo StartupObject trong file .csproj:
// CS0017: Program has more than one entry point defined.
// Cach sua: dat StartupObject thanh Buoi01Prj.GiaiPTBac2 (mac dinh),
// Buoi01Prj.Program1 hoac Buoi01Prj.Program2, sau do build/run lai.
public class Program1
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Main 1");
    }
}
