using System;
using System.Windows.Forms;

namespace B06_QuanLyHocVien;

public partial class FrmNhapHocVien : Form
{
    public string HoTenHocVien => txtHoTen.Text.Trim();
    public string LopDuocChon => cboLop.Text;

    public FrmNhapHocVien()
    {
        InitializeComponent();
        cboLop.Items.AddRange(new object[] { "Lớp A", "Lớp B" });
        cboLop.SelectedIndex = 0;
        txtHoTen.Focus();
    }

    private void btnCapNhat_Click(object? sender, EventArgs e)
    {
        if (HoTenHocVien.Length == 0)
        {
            MessageBox.Show("Vui lòng nhập họ tên.", "Thông báo");
            txtHoTen.Focus();
            return;
        }
        DialogResult = DialogResult.OK;
        Close();
    }

    private void btnTroVe_Click(object? sender, EventArgs e)
    {
        DialogResult = DialogResult.Cancel;
        Close();
    }
}
