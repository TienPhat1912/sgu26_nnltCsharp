namespace QuanLySVfm
{
    partial class QuanLySVfm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            treeLop = new TreeView();
            chkThemLop = new CheckBox();
            groupLop = new GroupBox();
            lblTenLop = new Label();
            txtLop = new TextBox();
            btnThemLop = new Button();
            lblChonLop = new Label();
            cboLop = new ComboBox();
            lblMa = new Label();
            txtMa = new TextBox();
            lblTen = new Label();
            txtTen = new TextBox();
            lblDiaChi = new Label();
            txtDiaChi = new TextBox();
            btnCapNhat = new Button();
            btnXoa = new Button();
            SuspendLayout();

            //
            // treeLop
            //
            treeLop.Location = new Point(20, 43);
            treeLop.Size = new Size(385, 450);
            treeLop.Name = "treeLop";
            treeLop.AfterSelect += treeLop_AfterSelect;

            //
            // chkThemLop
            //
            chkThemLop.Location = new Point(440, 20);
            chkThemLop.Size = new Size(150, 28);
            chkThemLop.Name = "chkThemLop";
            chkThemLop.Text = "Thêm lớp";
            chkThemLop.CheckedChanged += chkThemLop_CheckedChanged;

            //
            // groupLop
            //
            groupLop.Location = new Point(432, 55);
            groupLop.Size = new Size(445, 125);
            groupLop.Name = "groupLop";
            groupLop.Text = "Thông tin lớp";

            //
            // lblTenLop
            //
            lblTenLop.Location = new Point(15, 33);
            lblTenLop.Size = new Size(105, 28);
            lblTenLop.Name = "lblTenLop";
            lblTenLop.Text = "Tên lớp:";

            //
            // txtLop
            //
            txtLop.Location = new Point(125, 32);
            txtLop.Size = new Size(260, 30);
            txtLop.Name = "txtLop";

            //
            // btnThemLop
            //
            btnThemLop.Location = new Point(125, 76);
            btnThemLop.Size = new Size(150, 34);
            btnThemLop.Name = "btnThemLop";
            btnThemLop.Text = "Thêm lớp";
            btnThemLop.Click += btnThemLop_Click;

            //
            // lblChonLop
            //
            lblChonLop.Location = new Point(438, 211);
            lblChonLop.Size = new Size(146, 28);
            lblChonLop.Name = "lblChonLop";
            lblChonLop.Text = "Chọn lớp:";

            //
            // cboLop
            //
            cboLop.Location = new Point(604, 208);
            cboLop.Size = new Size(254, 30);
            cboLop.Name = "cboLop";
            cboLop.DropDownStyle = ComboBoxStyle.DropDownList;

            //
            // lblMa
            //
            lblMa.Location = new Point(438, 262);
            lblMa.Size = new Size(154, 28);
            lblMa.Name = "lblMa";
            lblMa.Text = "Mã sinh viên:";

            //
            // txtMa
            //
            txtMa.Location = new Point(604, 259);
            txtMa.Size = new Size(254, 31);
            txtMa.Name = "txtMa";

            //
            // lblTen
            //
            lblTen.Location = new Point(438, 319);
            lblTen.Size = new Size(154, 28);
            lblTen.Name = "lblTen";
            lblTen.Text = "Họ tên:";

            //
            // txtTen
            //
            txtTen.Location = new Point(604, 316);
            txtTen.Size = new Size(254, 31);
            txtTen.Name = "txtTen";

            //
            // lblDiaChi
            //
            lblDiaChi.Location = new Point(438, 376);
            lblDiaChi.Size = new Size(154, 28);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Text = "Địa chỉ:";

            //
            // txtDiaChi
            //
            txtDiaChi.Location = new Point(604, 373);
            txtDiaChi.Size = new Size(254, 31);
            txtDiaChi.Name = "txtDiaChi";

            //
            // btnCapNhat
            //
            btnCapNhat.Location = new Point(500, 451);
            btnCapNhat.Size = new Size(150, 39);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.Click += btnCapNhat_Click;

            //
            // btnXoa
            //
            btnXoa.Location = new Point(678, 451);
            btnXoa.Size = new Size(150, 39);
            btnXoa.Name = "btnXoa";
            btnXoa.Text = "Xóa";
            btnXoa.Click += btnXoa_Click;
            Controls.Add(treeLop);
            Controls.Add(chkThemLop);
            Controls.Add(groupLop);
            groupLop.Controls.Add(lblTenLop);
            groupLop.Controls.Add(txtLop);
            groupLop.Controls.Add(btnThemLop);
            Controls.Add(lblChonLop);
            Controls.Add(cboLop);
            Controls.Add(lblMa);
            Controls.Add(txtMa);
            Controls.Add(lblTen);
            Controls.Add(txtTen);
            Controls.Add(lblDiaChi);
            Controls.Add(txtDiaChi);
            Controls.Add(btnCapNhat);
            Controls.Add(btnXoa);


            //
            // Form1
            //
            ClientSize = new Size(930, 560);
            Font = new Font("Segoe UI", 10F);
            Name = "Form1";
            Text = "Bài tại lớp 2 - Quản lý sinh viên";
            StartPosition = FormStartPosition.CenterScreen;
            AutoScaleMode = AutoScaleMode.Font;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TreeView treeLop;
        private CheckBox chkThemLop;
        private GroupBox groupLop;
        private Label lblTenLop;
        private TextBox txtLop;
        private Button btnThemLop;
        private Label lblChonLop;
        private ComboBox cboLop;
        private Label lblMa;
        private TextBox txtMa;
        private Label lblTen;
        private TextBox txtTen;
        private Label lblDiaChi;
        private TextBox txtDiaChi;
        private Button btnCapNhat;
        private Button btnXoa;
    }
}
