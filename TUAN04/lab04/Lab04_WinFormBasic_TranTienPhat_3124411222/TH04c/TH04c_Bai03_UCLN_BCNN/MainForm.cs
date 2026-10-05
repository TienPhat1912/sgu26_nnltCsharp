namespace TH04c_Bai03_UCLN_BCNN;

public partial class MainForm : Form
{
    public MainForm() { InitializeComponent(); }

    private static int Gcd(int a, int b)
    {
        a = Math.Abs(a); b = Math.Abs(b);
        while (b != 0) { int r = a % b; a = b; b = r; }
        return a;
    }

    private void btnExecute_Click(object? sender, EventArgs e)
    {
        errorProvider.Clear();
        if (!int.TryParse(txtA.Text, out int a)) { errorProvider.SetError(txtA, "Nhập số nguyên."); return; }
        if (!int.TryParse(txtB.Text, out int b)) { errorProvider.SetError(txtB, "Nhập số nguyên."); return; }
        if (a == 0 && b == 0) { MessageBox.Show("UCLN và BCNN không xác định khi cả a và b đều bằng 0."); return; }

        int gcd = Gcd(a, b);
        long lcm = (a == 0 || b == 0) ? 0 : Math.Abs((long)a / gcd * b);
        txtGcd.Text = gcd.ToString(); txtLcm.Text = lcm.ToString();
    }

    private void btnContinue_Click(object? sender, EventArgs e)
    {
        txtA.Clear(); txtB.Clear(); txtGcd.Clear(); txtLcm.Clear(); errorProvider.Clear(); txtA.Focus();
    }

    private void btnExit_Click(object? sender, EventArgs e) => Close();
    private void MainForm_FormClosing(object? sender, FormClosingEventArgs e)
    {
        if (MessageBox.Show("Bạn có muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) e.Cancel = true;
    }
}
