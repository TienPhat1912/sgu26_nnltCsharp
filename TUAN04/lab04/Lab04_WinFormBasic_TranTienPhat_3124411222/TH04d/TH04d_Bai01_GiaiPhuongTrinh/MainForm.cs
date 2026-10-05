namespace TH04d_Bai01_GiaiPhuongTrinh;

public partial class MainForm : Form
{
    public MainForm() { InitializeComponent(); UpdateMode(); }

    private void Mode_CheckedChanged(object? sender, EventArgs e) => UpdateMode();
    private void UpdateMode()
    {
        bool quadratic = rdoQuadratic.Checked;
        lblC.Enabled = quadratic; txtC.Enabled = quadratic;
        if (!quadratic) txtC.Clear();
        btnSolve.Enabled = false; txtResult.Clear();
    }

    private void Input_TextChanged(object? sender, EventArgs e)
    {
        bool a = double.TryParse(txtA.Text, out _), b = double.TryParse(txtB.Text, out _);
        bool c = !rdoQuadratic.Checked || double.TryParse(txtC.Text, out _);
        btnSolve.Enabled = a && b && c;
    }

    private void btnSolve_Click(object? sender, EventArgs e)
    {
        errorProvider.Clear();
        if (!double.TryParse(txtA.Text, out double a)) { errorProvider.SetError(txtA, "Nhập số hợp lệ."); return; }
        if (!double.TryParse(txtB.Text, out double b)) { errorProvider.SetError(txtB, "Nhập số hợp lệ."); return; }
        double c = 0;
        if (rdoQuadratic.Checked && !double.TryParse(txtC.Text, out c)) { errorProvider.SetError(txtC, "Nhập số hợp lệ."); return; }
        var pt = new PhuongTrinhBacHai(a, b, c);
        txtResult.Text = rdoQuadratic.Checked ? pt.GiaiBacHai() : pt.GiaiBacNhat();
        btnSolve.Enabled = false;
    }

    private void btnExit_Click(object? sender, EventArgs e) => Close();
    private void MainForm_FormClosing(object? sender, FormClosingEventArgs e){if(MessageBox.Show("Bạn có chắc muốn thoát?","Xác nhận",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.No)e.Cancel=true;}
}
