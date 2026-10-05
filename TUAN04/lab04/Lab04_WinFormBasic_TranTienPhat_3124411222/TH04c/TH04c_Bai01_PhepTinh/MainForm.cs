namespace TH04c_Bai01_PhepTinh;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
    }

    // Chỉ cho phép nhập số, dấu âm và dấu thập phân.
    private void NumberTextBox_KeyPress(object? sender, KeyPressEventArgs e)
    {
        if (char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar)) return;
        TextBox txt = (TextBox)sender!;
        if ((e.KeyChar == '-' && txt.SelectionStart == 0 && !txt.Text.Contains('-')) ||
            (e.KeyChar == '.' && !txt.Text.Contains('.')))
            return;
        e.Handled = true;
    }

    private bool TryReadNumbers(out double a, out double b)
    {
        bool okA = double.TryParse(txtA.Text, out a);
        bool okB = double.TryParse(txtB.Text, out b);
        errorProvider.Clear();
        if (!okA) errorProvider.SetError(txtA, "Giá trị a không hợp lệ.");
        if (!okB) errorProvider.SetError(txtB, "Giá trị b không hợp lệ.");
        if (!okA || !okB)
        {
            MessageBox.Show("Vui lòng nhập đúng hai số a và b.", "Lỗi dữ liệu",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }
        return true;
    }

    private void Calculate(char op)
    {
        if (!TryReadNumbers(out double a, out double b)) return;
        if (op == '/' && Math.Abs(b) < double.Epsilon)
        {
            MessageBox.Show("Không thể chia cho 0.", "Lỗi phép chia",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        double result = op switch
        {
            '+' => a + b,
            '-' => a - b,
            '*' => a * b,
            '/' => a / b,
            _ => 0
        };
        txtResult.Text = result.ToString("0.########");
    }

    private void btnAdd_Click(object? sender, EventArgs e) => Calculate('+');
    private void btnSubtract_Click(object? sender, EventArgs e) => Calculate('-');
    private void btnMultiply_Click(object? sender, EventArgs e) => Calculate('*');
    private void btnDivide_Click(object? sender, EventArgs e) => Calculate('/');

    private void MainForm_FormClosing(object? sender, FormClosingEventArgs e)
    {
        if (MessageBox.Show("Bạn có muốn thoát chương trình?", "Xác nhận",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            e.Cancel = true;
    }
}
