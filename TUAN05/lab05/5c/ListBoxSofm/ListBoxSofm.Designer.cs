namespace ListBoxSofm
{
    partial class ListBoxSofm
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
            lblNhap = new Label();
            txtSo = new TextBox();
            btnThem = new Button();
            lstSo = new ListBox();
            btnTinhTong = new Button();
            btnXoaDauCuoi = new Button();
            btnXoaChon = new Button();
            btnTangHai = new Button();
            btnBinhPhuong = new Button();
            btnChonChan = new Button();
            btnChonLe = new Button();
            btnQuit = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // lblNhap
            // 
            lblNhap.Location = new Point(35, 46);
            lblNhap.Name = "lblNhap";
            lblNhap.Size = new Size(130, 27);
            lblNhap.TabIndex = 0;
            lblNhap.Text = "Nhập số N:";
            // 
            // txtSo
            // 
            txtSo.Location = new Point(160, 43);
            txtSo.Name = "txtSo";
            txtSo.Size = new Size(225, 30);
            txtSo.TabIndex = 1;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(406, 42);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(138, 34);
            btnThem.TabIndex = 2;
            btnThem.Text = "Thêm";
            btnThem.Click += btnThem_Click;
            // 
            // lstSo
            // 
            lstSo.ItemHeight = 23;
            lstSo.Location = new Point(55, 108);
            lstSo.Name = "lstSo";
            lstSo.SelectionMode = SelectionMode.MultiExtended;
            lstSo.Size = new Size(338, 395);
            lstSo.TabIndex = 3;
            // 
            // btnTinhTong
            // 
            btnTinhTong.Location = new Point(465, 100);
            btnTinhTong.Name = "btnTinhTong";
            btnTinhTong.Size = new Size(330, 40);
            btnTinhTong.TabIndex = 4;
            btnTinhTong.Text = "Tính tổng";
            btnTinhTong.Click += btnTinhTong_Click;
            // 
            // btnXoaDauCuoi
            // 
            btnXoaDauCuoi.Location = new Point(465, 161);
            btnXoaDauCuoi.Name = "btnXoaDauCuoi";
            btnXoaDauCuoi.Size = new Size(330, 40);
            btnXoaDauCuoi.TabIndex = 5;
            btnXoaDauCuoi.Text = "Xóa đầu và cuối";
            btnXoaDauCuoi.Click += btnXoaDauCuoi_Click;
            // 
            // btnXoaChon
            // 
            btnXoaChon.Location = new Point(465, 222);
            btnXoaChon.Name = "btnXoaChon";
            btnXoaChon.Size = new Size(330, 40);
            btnXoaChon.TabIndex = 6;
            btnXoaChon.Text = "Xóa các phần tử chọn";
            btnXoaChon.Click += btnXoaChon_Click;
            // 
            // btnTangHai
            // 
            btnTangHai.Location = new Point(465, 283);
            btnTangHai.Name = "btnTangHai";
            btnTangHai.Size = new Size(330, 40);
            btnTangHai.TabIndex = 7;
            btnTangHai.Text = "Tăng mỗi phần tử lên 2";
            btnTangHai.Click += btnTangHai_Click;
            // 
            // btnBinhPhuong
            // 
            btnBinhPhuong.Location = new Point(465, 344);
            btnBinhPhuong.Name = "btnBinhPhuong";
            btnBinhPhuong.Size = new Size(330, 40);
            btnBinhPhuong.TabIndex = 8;
            btnBinhPhuong.Text = "Bình phương";
            btnBinhPhuong.Click += btnBinhPhuong_Click;
            // 
            // btnChonChan
            // 
            btnChonChan.Location = new Point(465, 405);
            btnChonChan.Name = "btnChonChan";
            btnChonChan.Size = new Size(330, 40);
            btnChonChan.TabIndex = 9;
            btnChonChan.Text = "Chọn số chẵn";
            btnChonChan.Click += btnChonChan_Click;
            // 
            // btnChonLe
            // 
            btnChonLe.Location = new Point(465, 466);
            btnChonLe.Name = "btnChonLe";
            btnChonLe.Size = new Size(330, 40);
            btnChonLe.TabIndex = 10;
            btnChonLe.Text = "Chọn số lẻ";
            btnChonLe.Click += btnChonLe_Click;
            // 
            // btnQuit
            // 
            btnQuit.Location = new Point(288, 536);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(330, 40);
            btnQuit.TabIndex = 10;
            btnQuit.Text = "&Kết thúc";
            btnQuit.Click += btnQuit_Click;
            // 
            // button2
            // 
            button2.Location = new Point(901, 398);
            button2.Name = "button2";
            button2.Size = new Size(8, 8);
            button2.TabIndex = 11;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // ListBoxSofm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(925, 604);
            Controls.Add(button2);
            Controls.Add(lblNhap);
            Controls.Add(txtSo);
            Controls.Add(btnThem);
            Controls.Add(lstSo);
            Controls.Add(btnTinhTong);
            Controls.Add(btnXoaDauCuoi);
            Controls.Add(btnXoaChon);
            Controls.Add(btnTangHai);
            Controls.Add(btnBinhPhuong);
            Controls.Add(btnChonChan);
            Controls.Add(btnQuit);
            Controls.Add(btnChonLe);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ListBoxSofm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bài về nhà 2 - ListBox số nguyên";
            FormClosing += ListBoxSofm_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNhap;
        private TextBox txtSo;
        private Button btnThem;
        private ListBox lstSo;
        private Button btnTinhTong;
        private Button btnXoaDauCuoi;
        private Button btnXoaChon;
        private Button btnTangHai;
        private Button btnBinhPhuong;
        private Button btnChonChan;
        private Button btnChonLe;
        private Button btnQuit;
        private Button button2;
    }
}
