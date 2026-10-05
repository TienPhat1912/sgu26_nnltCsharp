namespace TH04c_Bai04_DaySoTinhTong;

partial class MainForm
{
    private System.ComponentModel.IContainer? components = null;
    private TextBox txtNumber = null!, txtSequence = null!, txtTotal = null!, txtEven = null!, txtOdd = null!;
    private Button btnAddNumber = null!, btnTotal = null!, btnEven = null!, btnOdd = null!, btnContinue = null!, btnExit = null!;
    private ErrorProvider errorProvider = null!;

    protected override void Dispose(bool disposing)
    {
        if (disposing) components?.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        errorProvider = new ErrorProvider(components);
        txtNumber = new TextBox(); txtSequence = new TextBox(); txtTotal = new TextBox(); txtEven = new TextBox(); txtOdd = new TextBox();
        btnAddNumber = new Button(); btnTotal = new Button(); btnEven = new Button(); btnOdd = new Button(); btnContinue = new Button(); btnExit = new Button();
        ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
        SuspendLayout();

        var title = new Label { Text = "Nhập Dãy Số và Tính Tổng", Font = new Font("Segoe UI", 17F, FontStyle.Bold), ForeColor = Color.Red, AutoSize = true, Left = 55, Top = 18 };
        var l1 = new Label { Text = "Nhập số:", Left = 45, Top = 82, AutoSize = true };
        var l2 = new Label { Text = "Dãy vừa nhập:", Left = 45, Top = 125, AutoSize = true };
        var l3 = new Label { Text = "Tổng các phần tử:", Left = 45, Top = 178, AutoSize = true };
        var l4 = new Label { Text = "Tổng chẵn:", Left = 45, Top = 228, AutoSize = true };
        var l5 = new Label { Text = "Tổng lẻ:", Left = 45, Top = 278, AutoSize = true };

        txtNumber.SetBounds(155, 77, 95, 27);
        btnAddNumber.SetBounds(280, 72, 95, 35); btnAddNumber.Text = "Nhập";
        txtSequence.SetBounds(155, 120, 220, 27); txtSequence.ReadOnly = true;

        txtTotal.SetBounds(205, 173, 85, 27); txtTotal.ReadOnly = true;
        btnTotal.SetBounds(305, 168, 100, 35); btnTotal.Text = "Tính tổng";
        txtEven.SetBounds(205, 223, 85, 27); txtEven.ReadOnly = true;
        btnEven.SetBounds(305, 218, 100, 35); btnEven.Text = "Tổng chẵn";
        txtOdd.SetBounds(205, 273, 85, 27); txtOdd.ReadOnly = true;
        btnOdd.SetBounds(305, 268, 100, 35); btnOdd.Text = "Tổng lẻ";

        btnContinue.SetBounds(115, 330, 110, 40); btnContinue.Text = "Tiếp tục";
        btnExit.SetBounds(250, 330, 110, 40); btnExit.Text = "Thoát";

        btnAddNumber.Click += btnAddNumber_Click;
        btnTotal.Click += btnTotal_Click;
        btnEven.Click += btnEven_Click;
        btnOdd.Click += btnOdd_Click;
        btnContinue.Click += btnContinue_Click;
        btnExit.Click += btnExit_Click;
        AcceptButton = btnAddNumber;

        ClientSize = new Size(455, 400);
        Controls.AddRange(new Control[] { title, l1, l2, l3, l4, l5, txtNumber, btnAddNumber, txtSequence, txtTotal, btnTotal, txtEven, btnEven, txtOdd, btnOdd, btnContinue, btnExit });
        Font = new Font("Segoe UI", 10F);
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Dãy số và Tính Tổng";
        FormClosing += MainForm_FormClosing;
        ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }
}
