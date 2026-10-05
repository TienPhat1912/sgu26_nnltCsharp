namespace TH04c_Bai05_DocSoThanhChu;
partial class MainForm
{
    private System.ComponentModel.IContainer? components=null;private TextBox txtNumber=null!;private Label lblResult=null!;private Button btnExecute=null!,btnClear=null!,btnExit=null!;private ErrorProvider errorProvider=null!;
    protected override void Dispose(bool disposing){if(disposing)components?.Dispose();base.Dispose(disposing);}
    private void InitializeComponent()
    {
        components=new System.ComponentModel.Container();errorProvider=new ErrorProvider(components);txtNumber=new TextBox();lblResult=new Label();btnExecute=new Button();btnClear=new Button();btnExit=new Button();
        ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();SuspendLayout();
        var title=new Label{Text="Đọc Số Thành Chữ",Font=new Font("Segoe UI",18F,FontStyle.Bold),ForeColor=Color.Red,AutoSize=true,Left=82,Top=20};var l1=new Label{Text="Nhập dãy số (1 đến 999):",Left=35,Top=88,AutoSize=true};
        txtNumber.SetBounds(235,83,105,27);btnExecute.SetBounds(35,135,95,38);btnExecute.Text="Thực hiện";btnClear.SetBounds(145,135,95,38);btnClear.Text="Xóa";btnExit.SetBounds(255,135,95,38);btnExit.Text="Thoát";
        lblResult.SetBounds(35,195,315,40);lblResult.BorderStyle=BorderStyle.FixedSingle;lblResult.ForeColor=Color.Blue;lblResult.TextAlign=ContentAlignment.MiddleLeft;
        btnExecute.Click+=btnExecute_Click;btnClear.Click+=btnClear_Click;btnExit.Click+=btnExit_Click;AcceptButton=btnExecute;
        ClientSize=new Size(390,260);Controls.AddRange([title,l1,txtNumber,btnExecute,btnClear,btnExit,lblResult]);Font=new Font("Segoe UI",10F);StartPosition=FormStartPosition.CenterScreen;Text="Đọc Số Thành Chữ";FormClosing+=MainForm_FormClosing;
        ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();ResumeLayout(false);PerformLayout();
    }
}
