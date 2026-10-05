using System.Text.RegularExpressions;

namespace TH04c_Bai02_DangKyTaiKhoan;

public partial class MainForm : Form
{
    public MainForm() { InitializeComponent(); }

    private bool IsValidEmail(string email) =>
        Regex.IsMatch(email, @"^[^\s@]+@[^\s@]+\.[^\s@]+$");

    private void txtEmail_Leave(object? sender, EventArgs e)
    {
        if (!IsValidEmail(txtEmail.Text.Trim()))
            errorProvider.SetError(txtEmail, "Email không đúng định dạng.");
        else
            errorProvider.SetError(txtEmail, "");
    }

    private bool ValidateInput()
    {
        errorProvider.Clear();
        bool ok = true;
        if (string.IsNullOrWhiteSpace(txtUsername.Text)) { errorProvider.SetError(txtUsername, "Bắt buộc nhập tên đăng nhập."); ok = false; }
        if (string.IsNullOrWhiteSpace(txtEmail.Text) || !IsValidEmail(txtEmail.Text.Trim())) { errorProvider.SetError(txtEmail, "Email không hợp lệ."); ok = false; }
        if (string.IsNullOrEmpty(txtPassword.Text)) { errorProvider.SetError(txtPassword, "Bắt buộc nhập mật khẩu."); ok = false; }
        if (string.IsNullOrEmpty(txtConfirm.Text)) { errorProvider.SetError(txtConfirm, "Bắt buộc xác nhận mật khẩu."); ok = false; }
        if (txtPassword.Text != txtConfirm.Text) { errorProvider.SetError(txtConfirm, "Mật khẩu xác nhận không khớp."); ok = false; }
        return ok;
    }

    private void btnRegister_Click(object? sender, EventArgs e)
    {
        if (!ValidateInput())
        {
            MessageBox.Show("Vui lòng kiểm tra lại thông tin đăng ký.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        string info = $"Tên đăng nhập: {txtUsername.Text}\n" +
                      $"Địa chỉ email: {txtEmail.Text}\n" +
                      $"Mật khẩu: {txtPassword.Text}\n" +
                      $"Xác nhận mật khẩu: {txtConfirm.Text}";
        MessageBox.Show(info, "Thông tin đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void MainForm_FormClosing(object? sender, FormClosingEventArgs e)
    {
        if (MessageBox.Show("Bạn có chắc muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            e.Cancel = true;
    }
}
