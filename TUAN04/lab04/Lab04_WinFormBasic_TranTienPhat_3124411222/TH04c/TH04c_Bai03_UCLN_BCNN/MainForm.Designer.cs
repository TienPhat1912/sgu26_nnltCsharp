namespace TH04c_Bai03_UCLN_BCNN;
partial class MainForm
{
    private System.ComponentModel.IContainer? components = null;
    private TextBox txtA=null!, txtB=null!, txtGcd=null!, txtLcm=null!; private Button btnExecute=null!, btnContinue=null!, btnExit=null!; private ErrorProvider errorProvider=null!;
    protected override void Dispose(bool disposing){ if(disposing) components?.Dispose(); base.Dispose(disposing); }
    private void InitializeComponent()
    {
        components=new System.ComponentModel.Container(); errorProvider=new ErrorProvider(components); txtA=new TextBox();txtB=new TextBox();txtGcd=new TextBox();txtLcm=new TextBox();btnExecute=new Button();btnContinue=new Button();btnExit=new Button();
        ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit(); SuspendLayout();
        var title=new Label{Text="Ước Số Chung - Bội Số Chung",Font=new Font("Segoe UI",16F,FontStyle.Bold),ForeColor=Color.Red,AutoSize=true,Left=48,Top=18};
        var l1=new Label{Text="Nhập số a:",Left=55,Top=80,AutoSize=true}; var l2=new Label{Text="Nhập số b:",Left=55,Top=120,AutoSize=true};
        var l3=new Label{Text="Ước số chung lớn nhất:",Left=55,Top=160,AutoSize=true}; var l4=new Label{Text="Bội số chung nhỏ nhất:",Left=55,Top=200,AutoSize=true};
        txtA.SetBounds(230,75,130,27);txtB.SetBounds(230,115,130,27);txtGcd.SetBounds(230,155,130,27);txtLcm.SetBounds(230,195,130,27);txtGcd.ReadOnly=true;txtLcm.ReadOnly=true;
        btnExecute.SetBounds(45,250,100,38);btnExecute.Text="Thực hiện";btnContinue.SetBounds(160,250,100,38);btnContinue.Text="Tiếp tục";btnExit.SetBounds(275,250,100,38);btnExit.Text="Thoát";
        btnExecute.Click+=btnExecute_Click;btnContinue.Click+=btnContinue_Click;btnExit.Click+=btnExit_Click;
        ClientSize=new Size(420,320);Controls.AddRange([title,l1,l2,l3,l4,txtA,txtB,txtGcd,txtLcm,btnExecute,btnContinue,btnExit]);Font=new Font("Segoe UI",10F);StartPosition=FormStartPosition.CenterScreen;Text="Ước Số - Bội Số";FormClosing+=MainForm_FormClosing;
        ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();ResumeLayout(false);PerformLayout();
    }
}
