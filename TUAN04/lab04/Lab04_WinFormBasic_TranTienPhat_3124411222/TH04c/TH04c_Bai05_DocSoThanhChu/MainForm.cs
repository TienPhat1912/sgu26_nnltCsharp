namespace TH04c_Bai05_DocSoThanhChu;

public partial class MainForm : Form
{
    private static readonly string[] digit = ["không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín"];
    public MainForm() { InitializeComponent(); }

    private static string ReadTwoDigits(int n, bool full)
    {
        int tens = n / 10, ones = n % 10; var parts = new List<string>();
        if (tens > 1) { parts.Add(digit[tens] + " mươi"); if (ones == 1) parts.Add("mốt"); else if (ones == 5) parts.Add("lăm"); else if (ones > 0) parts.Add(digit[ones]); }
        else if (tens == 1) { parts.Add("mười"); if (ones == 5) parts.Add("lăm"); else if (ones > 0) parts.Add(digit[ones]); }
        else if (ones > 0) { if (full) parts.Add("lẻ"); parts.Add(digit[ones]); }
        return string.Join(" ", parts);
    }

    private static string ReadNumber(int n)
    {
        if (n < 10) return digit[n];
        if (n < 100) return ReadTwoDigits(n, false);
        int hundreds = n / 100, rest = n % 100;
        string result = digit[hundreds] + " trăm";
        if (rest > 0) result += " " + ReadTwoDigits(rest, true);
        return result;
    }

    private void btnExecute_Click(object? sender, EventArgs e)
    {
        if (!int.TryParse(txtNumber.Text, out int n) || n < 1 || n > 999)
        {
            errorProvider.SetError(txtNumber, "Nhập số nguyên từ 1 đến 999.");
            MessageBox.Show("Vui lòng nhập số nguyên dương từ 1 đến 999.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
        }
        errorProvider.Clear(); lblResult.Text = ReadNumber(n);
    }
    private void btnClear_Click(object? sender, EventArgs e) { txtNumber.Clear(); lblResult.Text=""; errorProvider.Clear(); txtNumber.Focus(); }
    private void btnExit_Click(object? sender, EventArgs e) => Close();
    private void MainForm_FormClosing(object? sender, FormClosingEventArgs e){if(MessageBox.Show("Bạn có chắc muốn thoát?","Xác nhận",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.No)e.Cancel=true;}
}
