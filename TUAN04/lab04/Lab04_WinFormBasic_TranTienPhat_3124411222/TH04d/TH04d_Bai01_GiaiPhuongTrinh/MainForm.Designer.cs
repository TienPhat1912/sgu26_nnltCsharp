namespace TH04d_Bai01_GiaiPhuongTrinh;
partial class MainForm
{
    private System.ComponentModel.IContainer? components=null;private RadioButton rdoLinear=null!,rdoQuadratic=null!;private TextBox txtA=null!,txtB=null!,txtC=null!,txtResult=null!;private Label lblC=null!;private Button btnSolve=null!,btnExit=null!;private ErrorProvider errorProvider=null!;
    protected override void Dispose(bool disposing){if(disposing)components?.Dispose();base.Dispose(disposing);}
    private void InitializeComponent()
    {
        components=new System.ComponentModel.Container();errorProvider=new ErrorProvider(components);rdoLinear=new RadioButton();rdoQuadratic=new RadioButton();txtA=new TextBox();txtB=new TextBox();txtC=new TextBox();txtResult=new TextBox();btnSolve=new Button();btnExit=new Button();
        ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();SuspendLayout();
        var title=new Label{Text="GIẢI PHƯƠNG TRÌNH",Font=new Font("Segoe UI",17F,FontStyle.Bold),ForeColor=Color.Red,AutoSize=true,Left=85,Top=20};var grp=new GroupBox{Text="Bạn vui lòng chọn",Left=40,Top=75,Width=350,Height=105};
        rdoLinear.SetBounds(25,30,200,28);rdoLinear.Text="Phương trình bậc nhất";rdoLinear.Checked=true;rdoQuadratic.SetBounds(25,65,200,28);rdoQuadratic.Text="Phương trình bậc hai";grp.Controls.AddRange([rdoLinear,rdoQuadratic]);
        var la=new Label{Text="Nhập a",Left=50,Top=205,AutoSize=true};var lb=new Label{Text="Nhập b",Left=50,Top=248,AutoSize=true};lblC=new Label{Text="Nhập c",Left=50,Top=291,AutoSize=true};var lr=new Label{Text="Kết quả",Left=50,Top=345,AutoSize=true};
        txtA.SetBounds(145,200,150,27);txtB.SetBounds(145,243,150,27);txtC.SetBounds(145,286,150,27);txtResult.SetBounds(145,340,245,70);txtResult.Multiline=true;txtResult.ReadOnly=true;
        btnSolve.SetBounds(315,215,75,55);btnSolve.Text="Giải";btnExit.SetBounds(315,282,75,55);btnExit.Text="Thoát";btnSolve.Enabled=false;
        rdoLinear.CheckedChanged+=Mode_CheckedChanged;rdoQuadratic.CheckedChanged+=Mode_CheckedChanged;txtA.TextChanged+=Input_TextChanged;txtB.TextChanged+=Input_TextChanged;txtC.TextChanged+=Input_TextChanged;btnSolve.Click+=btnSolve_Click;btnExit.Click+=btnExit_Click;
        ClientSize=new Size(440,445);Controls.AddRange([title,grp,la,lb,lblC,lr,txtA,txtB,txtC,txtResult,btnSolve,btnExit]);Font=new Font("Segoe UI",10F);StartPosition=FormStartPosition.CenterScreen;Text="Giải phương trình bậc 1-2";FormClosing+=MainForm_FormClosing;
        ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();ResumeLayout(false);PerformLayout();
    }
}
