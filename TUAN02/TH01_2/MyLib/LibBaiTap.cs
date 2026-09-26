namespace MyLib;

public class LibBaiTap
{
    public const double EPS = 1e-9;

    /// <summary>
    /// Giai ax^2 + bx + c = 0 trong tap so thuc.
    /// </summary>
    /// <returns>-1: vo so nghiem; 0: vo nghiem; 1: mot nghiem; 2: hai nghiem.</returns>
    /// <remarks>
    /// Dung nguong tuyet doi EPS theo bai thuc hanh.
    /// Khi co mot nghiem, chi x1 co y nghia; khi co hai nghiem, x1 &lt;= x2.
    /// Cac gia tri ref khong co nghiem tuong ung duoc giu nguyen.
    /// </remarks>
    public static int GiaiPTBac2(double a, double b, double c, ref double x1, ref double x2)
    {
        if (Math.Abs(a) < EPS)
        {
            if (Math.Abs(b) < EPS)
                return Math.Abs(c) < EPS ? -1 : 0;

            x1 = -c / b;
            return 1;
        }

        double delta = b * b - 4 * a * c;
        if (Math.Abs(delta) < EPS)
        {
            x1 = -b / (2 * a);
            return 1;
        }

        if (delta < 0) return 0;

        x1 = (-b - Math.Sqrt(delta)) / (2 * a);
        x2 = (-b + Math.Sqrt(delta)) / (2 * a);
        if (x1 > x2)
        {
            double temp = x1;
            x1 = x2;
            x2 = temp;
        }
        return 2;
    }
}
