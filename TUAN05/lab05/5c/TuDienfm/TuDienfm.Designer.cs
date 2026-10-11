namespace TuDienfm
{
    partial class TuDienfm
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
            tabControl1 = new TabControl();
            tabAnhViet = new TabPage();
            tabVietAnh = new TabPage();

            lblAnh = new Label();
            lblViet = new Label();
            cboAnh = new ComboBox();
            lstAnh = new ListBox();
            txtViet = new TextBox();

            lblNhapViet = new Label();
            lblNghiaAnh = new Label();
            cboViet = new ComboBox();
            lstViet = new ListBox();
            txtAnh = new TextBox();

            btnThoat = new Button();

            tabControl1.SuspendLayout();
            tabAnhViet.SuspendLayout();
            tabVietAnh.SuspendLayout();
            SuspendLayout();

            //
            // tabControl1
            //
            tabControl1.Controls.Add(tabAnhViet);
            tabControl1.Controls.Add(tabVietAnh);
            tabControl1.Location = new Point(20, 20);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(640, 420);
            tabControl1.TabIndex = 0;

            //
            // tabAnhViet
            //
            tabAnhViet.Controls.Add(lblAnh);
            tabAnhViet.Controls.Add(lblViet);
            tabAnhViet.Controls.Add(cboAnh);
            tabAnhViet.Controls.Add(lstAnh);
            tabAnhViet.Controls.Add(txtViet);
            tabAnhViet.Location = new Point(4, 31);
            tabAnhViet.Name = "tabAnhViet";
            tabAnhViet.Padding = new Padding(3);
            tabAnhViet.Size = new Size(632, 385);
            tabAnhViet.TabIndex = 0;
            tabAnhViet.Text = "ANH - VIỆT";
            tabAnhViet.UseVisualStyleBackColor = true;

            //
            // lblAnh
            //
            lblAnh.AutoSize = true;
            lblAnh.Location = new Point(25, 20);
            lblAnh.Name = "lblAnh";
            lblAnh.Size = new Size(84, 22);
            lblAnh.TabIndex = 0;
            lblAnh.Text = "Tiếng Anh";

            //
            // lblViet
            //
            lblViet.AutoSize = true;
            lblViet.Location = new Point(290, 20);
            lblViet.Name = "lblViet";
            lblViet.Size = new Size(87, 22);
            lblViet.TabIndex = 1;
            lblViet.Text = "Tiếng Việt";

            //
            // cboAnh
            //
            cboAnh.DropDownStyle = ComboBoxStyle.DropDown;
            cboAnh.FormattingEnabled = true;
            cboAnh.Location = new Point(25, 50);
            cboAnh.Name = "cboAnh";
            cboAnh.Size = new Size(225, 30);
            cboAnh.TabIndex = 2;
            cboAnh.TextChanged += cboAnh_TextChanged;
            cboAnh.KeyDown += cboAnh_KeyDown;

            //
            // lstAnh
            //
            lstAnh.FormattingEnabled = true;
            lstAnh.IntegralHeight = false;
            lstAnh.ItemHeight = 22;
            lstAnh.Location = new Point(25, 85);
            lstAnh.Name = "lstAnh";
            lstAnh.Size = new Size(225, 275);
            lstAnh.TabIndex = 3;
            lstAnh.DoubleClick += lstAnh_DoubleClick;
            lstAnh.KeyDown += lstAnh_KeyDown;

            //
            // txtViet
            //
            txtViet.Location = new Point(290, 50);
            txtViet.Multiline = true;
            txtViet.Name = "txtViet";
            txtViet.ReadOnly = true;
            txtViet.ScrollBars = ScrollBars.Vertical;
            txtViet.Size = new Size(305, 310);
            txtViet.TabIndex = 4;

            //
            // tabVietAnh
            //
            tabVietAnh.Controls.Add(lblNhapViet);
            tabVietAnh.Controls.Add(lblNghiaAnh);
            tabVietAnh.Controls.Add(cboViet);
            tabVietAnh.Controls.Add(lstViet);
            tabVietAnh.Controls.Add(txtAnh);
            tabVietAnh.Location = new Point(4, 31);
            tabVietAnh.Name = "tabVietAnh";
            tabVietAnh.Padding = new Padding(3);
            tabVietAnh.Size = new Size(632, 385);
            tabVietAnh.TabIndex = 1;
            tabVietAnh.Text = "VIỆT - ANH";
            tabVietAnh.UseVisualStyleBackColor = true;

            //
            // lblNhapViet
            //
            lblNhapViet.AutoSize = true;
            lblNhapViet.Location = new Point(25, 20);
            lblNhapViet.Name = "lblNhapViet";
            lblNhapViet.Size = new Size(87, 22);
            lblNhapViet.TabIndex = 0;
            lblNhapViet.Text = "Tiếng Việt";

            //
            // lblNghiaAnh
            //
            lblNghiaAnh.AutoSize = true;
            lblNghiaAnh.Location = new Point(290, 20);
            lblNghiaAnh.Name = "lblNghiaAnh";
            lblNghiaAnh.Size = new Size(84, 22);
            lblNghiaAnh.TabIndex = 1;
            lblNghiaAnh.Text = "Tiếng Anh";

            //
            // cboViet
            //
            cboViet.DropDownStyle = ComboBoxStyle.DropDown;
            cboViet.FormattingEnabled = true;
            cboViet.Location = new Point(25, 50);
            cboViet.Name = "cboViet";
            cboViet.Size = new Size(225, 30);
            cboViet.TabIndex = 2;
            cboViet.TextChanged += cboViet_TextChanged;
            cboViet.KeyDown += cboViet_KeyDown;

            //
            // lstViet
            //
            lstViet.FormattingEnabled = true;
            lstViet.IntegralHeight = false;
            lstViet.ItemHeight = 22;
            lstViet.Location = new Point(25, 85);
            lstViet.Name = "lstViet";
            lstViet.Size = new Size(225, 275);
            lstViet.TabIndex = 3;
            lstViet.DoubleClick += lstViet_DoubleClick;
            lstViet.KeyDown += lstViet_KeyDown;

            //
            // txtAnh
            //
            txtAnh.Location = new Point(290, 50);
            txtAnh.Multiline = true;
            txtAnh.Name = "txtAnh";
            txtAnh.ReadOnly = true;
            txtAnh.ScrollBars = ScrollBars.Vertical;
            txtAnh.Size = new Size(305, 310);
            txtAnh.TabIndex = 4;

            //
            // btnThoat
            //
            btnThoat.Location = new Point(530, 450);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(130, 38);
            btnThoat.TabIndex = 1;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;

            //
            // Form1
            //
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(680, 505);
            Controls.Add(tabControl1);
            Controls.Add(btnThoat);
            Font = new Font(
                "Times New Roman",
                12F,
                FontStyle.Regular,
                GraphicsUnit.Point);

            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TỪ ĐIỂN ANH VIỆT - VIỆT ANH";

            tabAnhViet.ResumeLayout(false);
            tabAnhViet.PerformLayout();

            tabVietAnh.ResumeLayout(false);
            tabVietAnh.PerformLayout();

            tabControl1.ResumeLayout(false);

            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabAnhViet;
        private TabPage tabVietAnh;

        private Label lblAnh;
        private Label lblViet;
        private ComboBox cboAnh;
        private ListBox lstAnh;
        private TextBox txtViet;

        private Label lblNhapViet;
        private Label lblNghiaAnh;
        private ComboBox cboViet;
        private ListBox lstViet;
        private TextBox txtAnh;

        private Button btnThoat;
    }
}
