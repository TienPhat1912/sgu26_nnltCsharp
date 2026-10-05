namespace TH04c_Bai02_DangKyTaiKhoan;

partial class MainForm
{
    private System.ComponentModel.IContainer? components = null;
    private TextBox txtUsername = null!, txtEmail = null!, txtPassword = null!, txtConfirm = null!;
    private Button btnRegister = null!;
    private ErrorProvider errorProvider = null!;
    protected override void Dispose(bool disposing) { if (disposing) components?.Dispose(); base.Dispose(disposing); }

    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container(); errorProvider = new ErrorProvider(components);
        txtUsername = new TextBox(); txtEmail = new TextBox(); txtPassword = new TextBox(); txtConfirm = new TextBox(); btnRegister = new Button();
        ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit(); SuspendLayout();
        var title = new Label { Text = "Đăng ký tài khoản", AutoSize = true, Font = new Font("Segoe UI", 16F, FontStyle.Bold), ForeColor = Color.DodgerBlue, Left = 110, Top = 18 };
        var l1 = new Label { Text = "Tên đăng nhập (*)", Left = 30, Top = 75, AutoSize = true };
        var l2 = new Label { Text = "Địa chỉ email (*)", Left = 30, Top = 118, AutoSize = true };
        var l3 = new Label { Text = "Mật khẩu (*)", Left = 30, Top = 161, AutoSize = true };
        var l4 = new Label { Text = "Xác nhận mật khẩu (*)", Left = 30, Top = 204, AutoSize = true };
        txtUsername.SetBounds(195, 70, 205, 27); txtEmail.SetBounds(195, 113, 205, 27);
        txtPassword.SetBounds(195, 156, 205, 27); txtConfirm.SetBounds(195, 199, 205, 27);
        txtPassword.UseSystemPasswordChar = true; txtConfirm.UseSystemPasswordChar = true;
        btnRegister.SetBounds(195, 245, 205, 42); btnRegister.Text = "Đăng ký";
        txtEmail.Leave += txtEmail_Leave; btnRegister.Click += btnRegister_Click;
        AcceptButton = btnRegister;
        AutoScaleDimensions = new SizeF(8F,20F); AutoScaleMode = AutoScaleMode.Font; ClientSize = new Size(445,320);
        Controls.AddRange([title,l1,l2,l3,l4,txtUsername,txtEmail,txtPassword,txtConfirm,btnRegister]);
        Font = new Font("Segoe UI",10F); FormBorderStyle = FormBorderStyle.FixedDialog; MaximizeBox = false;
        StartPosition = FormStartPosition.CenterScreen; Text = "Đăng ký tài khoản"; FormClosing += MainForm_FormClosing;
        ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit(); ResumeLayout(false); PerformLayout();
    }
}
