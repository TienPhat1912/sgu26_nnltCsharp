namespace TreeViewfm
{
    partial class TreeViewfm
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
            trvPhongBan = new TreeView();
            lblPhongBan = new Label();
            txtPhongBan = new TextBox();
            btnThemPhongBan = new Button();
            btnXoaPhongBan = new Button();
            lblChonPhong = new Label();
            cboPhongBan = new ComboBox();
            lblMaNhanVien = new Label();
            txtMaNhanVien = new TextBox();
            lblHoTen = new Label();
            txtHoTen = new TextBox();
            lblDiaChi = new Label();
            txtDiaChi = new TextBox();
            btnThemNhanVien = new Button();
            btnThoat = new Button();
            SuspendLayout();
            // 
            // trvPhongBan
            // 
            trvPhongBan.Location = new Point(25, 48);
            trvPhongBan.Name = "trvPhongBan";
            trvPhongBan.Size = new Size(425, 456);
            trvPhongBan.TabIndex = 0;
            // 
            // lblPhongBan
            // 
            lblPhongBan.Location = new Point(483, 56);
            lblPhongBan.Name = "lblPhongBan";
            lblPhongBan.Size = new Size(150, 25);
            lblPhongBan.TabIndex = 1;
            lblPhongBan.Text = "Phòng ban:";
            // 
            // txtPhongBan
            // 
            txtPhongBan.Location = new Point(650, 55);
            txtPhongBan.Name = "txtPhongBan";
            txtPhongBan.Size = new Size(245, 30);
            txtPhongBan.TabIndex = 2;
            // 
            // btnThemPhongBan
            // 
            btnThemPhongBan.Location = new Point(500, 108);
            btnThemPhongBan.Name = "btnThemPhongBan";
            btnThemPhongBan.Size = new Size(176, 38);
            btnThemPhongBan.TabIndex = 3;
            btnThemPhongBan.Text = "Thêm phòng ban";
            btnThemPhongBan.Click += btnThemPhongBan_Click;
            // 
            // btnXoaPhongBan
            // 
            btnXoaPhongBan.Location = new Point(710, 108);
            btnXoaPhongBan.Name = "btnXoaPhongBan";
            btnXoaPhongBan.Size = new Size(176, 38);
            btnXoaPhongBan.TabIndex = 4;
            btnXoaPhongBan.Text = "Xóa phòng ban";
            btnXoaPhongBan.Click += btnXoaPhongBan_Click;
            // 
            // lblChonPhong
            // 
            lblChonPhong.Location = new Point(483, 206);
            lblChonPhong.Name = "lblChonPhong";
            lblChonPhong.Size = new Size(160, 30);
            lblChonPhong.TabIndex = 5;
            lblChonPhong.Text = "Chọn phòng ban:";
            // 
            // cboPhongBan
            // 
            cboPhongBan.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPhongBan.Location = new Point(650, 201);
            cboPhongBan.Name = "cboPhongBan";
            cboPhongBan.Size = new Size(245, 31);
            cboPhongBan.TabIndex = 6;
            // 
            // lblMaNhanVien
            // 
            lblMaNhanVien.Location = new Point(483, 263);
            lblMaNhanVien.Name = "lblMaNhanVien";
            lblMaNhanVien.Size = new Size(162, 27);
            lblMaNhanVien.TabIndex = 7;
            lblMaNhanVien.Text = "Mã nhân viên:";
            // 
            // txtMaNhanVien
            // 
            txtMaNhanVien.Location = new Point(650, 260);
            txtMaNhanVien.Name = "txtMaNhanVien";
            txtMaNhanVien.Size = new Size(245, 30);
            txtMaNhanVien.TabIndex = 8;
            // 
            // lblHoTen
            // 
            lblHoTen.Location = new Point(483, 315);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(162, 27);
            lblHoTen.TabIndex = 9;
            lblHoTen.Text = "Họ tên:";
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(650, 312);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(245, 30);
            txtHoTen.TabIndex = 10;
            // 
            // lblDiaChi
            // 
            lblDiaChi.Location = new Point(483, 367);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new Size(162, 27);
            lblDiaChi.TabIndex = 11;
            lblDiaChi.Text = "Địa chỉ:";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(650, 364);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(245, 30);
            txtDiaChi.TabIndex = 12;
            // 
            // btnThemNhanVien
            // 
            btnThemNhanVien.Location = new Point(500, 449);
            btnThemNhanVien.Name = "btnThemNhanVien";
            btnThemNhanVien.Size = new Size(176, 40);
            btnThemNhanVien.TabIndex = 13;
            btnThemNhanVien.Text = "Thêm nhân viên";
            btnThemNhanVien.Click += btnThemNhanVien_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(710, 449);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(176, 40);
            btnThoat.TabIndex = 14;
            btnThoat.Text = "Thoát";
            btnThoat.Click += btnThoat_Click;
            // 
            // TreeViewfm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(950, 570);
            Controls.Add(trvPhongBan);
            Controls.Add(lblPhongBan);
            Controls.Add(txtPhongBan);
            Controls.Add(btnThemPhongBan);
            Controls.Add(btnXoaPhongBan);
            Controls.Add(lblChonPhong);
            Controls.Add(cboPhongBan);
            Controls.Add(lblMaNhanVien);
            Controls.Add(txtMaNhanVien);
            Controls.Add(lblHoTen);
            Controls.Add(txtHoTen);
            Controls.Add(lblDiaChi);
            Controls.Add(txtDiaChi);
            Controls.Add(btnThemNhanVien);
            Controls.Add(btnThoat);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "TreeViewfm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bài mẫu 3 - Phòng ban và nhân viên";
            FormClosing += Form1_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TreeView trvPhongBan;
        private Label lblPhongBan;
        private TextBox txtPhongBan;
        private Button btnThemPhongBan;
        private Button btnXoaPhongBan;
        private Label lblChonPhong;
        private ComboBox cboPhongBan;
        private Label lblMaNhanVien;
        private TextBox txtMaNhanVien;
        private Label lblHoTen;
        private TextBox txtHoTen;
        private Label lblDiaChi;
        private TextBox txtDiaChi;
        private Button btnThemNhanVien;
        private Button btnThoat;
    }
}
