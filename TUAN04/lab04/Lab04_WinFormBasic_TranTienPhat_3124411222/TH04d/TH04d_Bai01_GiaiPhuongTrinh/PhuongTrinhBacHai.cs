namespace TH04d_Bai01_GiaiPhuongTrinh;

// Lớp nghiệp vụ dùng chung cho phương trình bậc nhất và bậc hai.
public class PhuongTrinhBacHai
{
    public double A { get; set; }
    public double B { get; set; }
    public double C { get; set; }

    public PhuongTrinhBacHai(double a, double b, double c = 0) { A = a; B = b; C = c; }

    public string GiaiBacNhat()
    {
        if (Math.Abs(A) < 1e-12) return Math.Abs(B) < 1e-12 ? "Phương trình vô số nghiệm." : "Phương trình vô nghiệm.";
        return $"Phương trình có nghiệm x = {-B / A:0.##}";
    }

    public string GiaiBacHai()
    {
        if (Math.Abs(A) < 1e-12) return new PhuongTrinhBacHai(B, C).GiaiBacNhat();
        double delta = B * B - 4 * A * C;
        if (delta < 0) return "Phương trình vô nghiệm.";
        if (Math.Abs(delta) < 1e-12) return $"Phương trình có nghiệm kép x = {-B / (2 * A):0.##}";
        double x1 = (-B + Math.Sqrt(delta)) / (2 * A), x2 = (-B - Math.Sqrt(delta)) / (2 * A);
        return $"Phương trình có hai nghiệm x1 = {x1:0.##}; x2 = {x2:0.##}";
    }
}
