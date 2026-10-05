namespace TH04c_Bai04_DaySoTinhTong;

public partial class MainForm : Form
{
    private readonly List<int> numbers = new();
    public MainForm() { InitializeComponent(); }

    private void btnAddNumber_Click(object? sender, EventArgs e)
    {
        if (!int.TryParse(txtNumber.Text, out int value))
        {
            errorProvider.SetError(txtNumber, "Vui lòng nhập số nguyên.");
            MessageBox.Show("Dữ liệu nhập phải là số nguyên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtNumber.SelectAll();
            txtNumber.Focus();
            return;
        }

        errorProvider.Clear();
        numbers.Add(value);
        txtSequence.Text = string.Join(" ", numbers);
        txtNumber.Clear();
        txtNumber.Focus();
    }

    private void btnTotal_Click(object? sender, EventArgs e)
        => txtTotal.Text = numbers.Sum().ToString();

    private void btnEven_Click(object? sender, EventArgs e)
        => txtEven.Text = numbers.Where(x => x % 2 == 0).Sum().ToString();

    private void btnOdd_Click(object? sender, EventArgs e)
        => txtOdd.Text = numbers.Where(x => x % 2 != 0).Sum().ToString();

    private void btnContinue_Click(object? sender, EventArgs e)
    {
        numbers.Clear();
        txtNumber.Clear();
        txtSequence.Clear();
        txtTotal.Clear();
        txtEven.Clear();
        txtOdd.Clear();
        errorProvider.Clear();
        txtNumber.Focus();
    }

    private void btnExit_Click(object? sender, EventArgs e) => Close();

    private void MainForm_FormClosing(object? sender, FormClosingEventArgs e)
    {
        if (MessageBox.Show("Bạn có chắc muốn thoát?", "Xác nhận",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            e.Cancel = true;
    }
}
