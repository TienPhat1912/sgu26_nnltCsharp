using MyLib;
using Xunit;

namespace MyLib.Tests;

public class LibBaiTapTests
{
    [Fact]
    public void GiaiPTBac2_A0_B0_C0_VoSoNghiem()
    {
        double x1 = 0, x2 = 0;
        int result = LibBaiTap.GiaiPTBac2(0, 0, 0, ref x1, ref x2);
        Assert.Equal(-1, result);
    }

    [Fact]
    public void GiaiPTBac2_A0_B0_CKhac0_VoNghiem()
    {
        double x1 = 0, x2 = 0;
        int result = LibBaiTap.GiaiPTBac2(0, 0, 5, ref x1, ref x2);
        Assert.Equal(0, result);
    }

    [Fact]
    public void GiaiPTBac2_PhuongTrinhBac1_CoMotNghiem()
    {
        double x1 = 0, x2 = 0;
        int result = LibBaiTap.GiaiPTBac2(0, 2, -4, ref x1, ref x2);
        Assert.Equal(1, result);
        Assert.Equal(2.0, x1, 10);
    }

    [Fact]
    public void GiaiPTBac2_DeltaNhoHon0_VoNghiem()
    {
        double x1 = 0, x2 = 0;
        int result = LibBaiTap.GiaiPTBac2(1, 0, 1, ref x1, ref x2);
        Assert.Equal(0, result);
    }

    [Fact]
    public void GiaiPTBac2_DeltaBang0_CoNghiemKep()
    {
        double x1 = 0, x2 = 0;
        int result = LibBaiTap.GiaiPTBac2(1, -2, 1, ref x1, ref x2);
        Assert.Equal(1, result);
        Assert.Equal(1.0, x1, 10);
    }

    [Fact]
    public void GiaiPTBac2_DeltaLonHon0_CoHaiNghiem()
    {
        double x1 = 0, x2 = 0;
        int result = LibBaiTap.GiaiPTBac2(1, -3, 2, ref x1, ref x2);
        Assert.Equal(2, result);
        Assert.Equal(1.0, x1, 10);
        Assert.Equal(2.0, x2, 10);
    }

    [Fact]
    public void GiaiPTBac2_HaiNghiem_LuonDuocSapXepTangDan()
    {
        double x1 = 0, x2 = 0;
        int result = LibBaiTap.GiaiPTBac2(-1, 3, -2, ref x1, ref x2);
        Assert.Equal(2, result);
        Assert.Equal(1.0, x1, 10);
        Assert.Equal(2.0, x2, 10);
        Assert.True(x1 <= x2);
    }

    [Fact]
    public void GiaiPTBac2_AGan0_XemNhuBac1()
    {
        double x1 = 0, x2 = 0;
        int result = LibBaiTap.GiaiPTBac2(LibBaiTap.EPS / 2, 2, -4, ref x1, ref x2);
        Assert.Equal(1, result);
        Assert.Equal(2.0, x1, 10);
    }

    [Fact]
    public void GiaiPTBac2_CacHeSoGan0_VoSoNghiem()
    {
        double x1 = 0, x2 = 0;
        double small = LibBaiTap.EPS / 2;
        Assert.Equal(-1, LibBaiTap.GiaiPTBac2(small, -small, small, ref x1, ref x2));
    }

    [Fact]
    public void GiaiPTBac2_ABGan0_CKhac0_VoNghiem()
    {
        double x1 = 0, x2 = 0;
        double small = LibBaiTap.EPS / 2;
        Assert.Equal(0, LibBaiTap.GiaiPTBac2(small, small, 5, ref x1, ref x2));
    }

    [Theory]
    [InlineData(1.0000000001)] // delta am, nhung |delta| < EPS.
    [InlineData(0.9999999999)] // delta duong, nhung |delta| < EPS.
    public void GiaiPTBac2_DeltaGan0_XemNhuNghiemKep(double c)
    {
        double x1 = 0, x2 = 0;
        int result = LibBaiTap.GiaiPTBac2(1, -2, c, ref x1, ref x2);
        Assert.Equal(1, result);
        Assert.Equal(1.0, x1, 10);
    }

    [Fact]
    public void GiaiPTBac2_ABangEPS_KhongXemLa0()
    {
        double x1 = 0, x2 = 0;
        int result = LibBaiTap.GiaiPTBac2(LibBaiTap.EPS, 0, -1, ref x1, ref x2);
        Assert.Equal(2, result);
        Assert.True(x1 < 0 && x2 > 0);
        Assert.InRange(Math.Abs(LibBaiTap.EPS * x1 * x1 - 1), 0, 1e-10);
        Assert.InRange(Math.Abs(LibBaiTap.EPS * x2 * x2 - 1), 0, 1e-10);
    }

    [Fact]
    public void GiaiPTBac2_NghiemVoTi_ThoaPhuongTrinh()
    {
        double x1 = 0, x2 = 0;
        int result = LibBaiTap.GiaiPTBac2(1, 0, -2, ref x1, ref x2);
        Assert.Equal(2, result);
        Assert.Equal(-Math.Sqrt(2), x1, 10);
        Assert.Equal(Math.Sqrt(2), x2, 10);
    }
}
