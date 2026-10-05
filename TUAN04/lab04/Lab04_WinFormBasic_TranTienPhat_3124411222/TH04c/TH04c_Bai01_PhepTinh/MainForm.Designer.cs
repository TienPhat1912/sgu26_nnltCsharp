namespace TH04c_Bai01_PhepTinh;

partial class MainForm
{
    private System.ComponentModel.IContainer? components = null;
    private TextBox txtA = null!;
    private TextBox txtB = null!;
    private TextBox txtResult = null!;
    private Button btnAdd = null!;
    private Button btnSubtract = null!;
    private Button btnMultiply = null!;
    private Button btnDivide = null!;
    private ErrorProvider errorProvider = null!;

    protected override void Dispose(bool disposing)
    {
        if (disposing) components?.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        txtA = new TextBox(); txtB = new TextBox(); txtResult = new TextBox();
        btnAdd = new Button(); btnSubtract = new Button(); btnMultiply = new Button(); btnDivide = new Button();
        errorProvider = new ErrorProvider(components);
        ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
        SuspendLayout();

        var lblA = new Label { Text = "a =", Left = 25, Top = 25, AutoSize = true };
        var lblB = new Label { Text = "b =", Left = 210, Top = 25, AutoSize = true };
        var lblR = new Label { Text = "Kết quả", Left = 25, Top = 72, AutoSize = true };
        txtA.SetBounds(65, 20, 115, 27); txtB.SetBounds(250, 20, 115, 27);
        txtResult.SetBounds(90, 67, 275, 27); txtResult.ReadOnly = true;
        btnAdd.SetBounds(25, 115, 75, 38); btnAdd.Text = "+";
        btnSubtract.SetBounds(115, 115, 75, 38); btnSubtract.Text = "-";
        btnMultiply.SetBounds(205, 115, 75, 38); btnMultiply.Text = "x";
        btnDivide.SetBounds(295, 115, 75, 38); btnDivide.Text = "/";
        txtA.KeyPress += NumberTextBox_KeyPress; txtB.KeyPress += NumberTextBox_KeyPress;
        btnAdd.Click += btnAdd_Click; btnSubtract.Click += btnSubtract_Click;
        btnMultiply.Click += btnMultiply_Click; btnDivide.Click += btnDivide_Click;

        AutoScaleDimensions = new SizeF(8F, 20F); AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(405, 185); Controls.AddRange([lblA, lblB, lblR, txtA, txtB, txtResult, btnAdd, btnSubtract, btnMultiply, btnDivide]);
        Font = new Font("Segoe UI", 10F); FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false; StartPosition = FormStartPosition.CenterScreen; Text = "Cộng trừ nhân chia";
        FormClosing += MainForm_FormClosing;
        ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
        ResumeLayout(false); PerformLayout();
    }
}
