#nullable disable
using System.Drawing;
using System.Windows.Forms;

namespace B05_QuanLyTaiKhoan
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblTieuDe = new Label();
            lblSoTaiKhoan = new Label();
            txtSoTaiKhoan = new TextBox();
            lblKhachHang = new Label();
            txtKhachHang = new TextBox();
            lblDiaChi = new Label();
            txtDiaChi = new TextBox();
            lblSoTien = new Label();
            txtSoTien = new TextBox();
            btnThem = new Button();
            btnLuu = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            lvTaiKhoan = new ListView();
            lblTong = new Label();
            txtTong = new TextBox();
            SuspendLayout();

            //
            // lblTieuDe
            //
            lblTieuDe.Location = new Point(64, 17);
            lblTieuDe.Size = new Size(540, 45);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Text = "QUẢN LÝ THÔNG TIN TÀI KHOẢN";
            lblTieuDe.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            lblTieuDe.ForeColor = Color.DarkBlue;
            lblTieuDe.TextAlign = ContentAlignment.MiddleCenter;

            //
            // lblSoTaiKhoan
            //
            lblSoTaiKhoan.Location = new Point(27, 82);
            lblSoTaiKhoan.Size = new Size(194, 26);
            lblSoTaiKhoan.Name = "lblSoTaiKhoan";
            lblSoTaiKhoan.Text = "Số tài khoản:";

            //
            // txtSoTaiKhoan
            //
            txtSoTaiKhoan.Location = new Point(241, 79);
            txtSoTaiKhoan.Size = new Size(370, 32);
            txtSoTaiKhoan.Name = "txtSoTaiKhoan";

            //
            // lblKhachHang
            //
            lblKhachHang.Location = new Point(27, 126);
            lblKhachHang.Size = new Size(194, 26);
            lblKhachHang.Name = "lblKhachHang";
            lblKhachHang.Text = "Tên khách hàng:";

            //
            // txtKhachHang
            //
            txtKhachHang.Location = new Point(241, 123);
            txtKhachHang.Size = new Size(370, 32);
            txtKhachHang.Name = "txtKhachHang";

            //
            // lblDiaChi
            //
            lblDiaChi.Location = new Point(27, 170);
            lblDiaChi.Size = new Size(194, 26);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Text = "Địa chỉ khách hàng:";

            //
            // txtDiaChi
            //
            txtDiaChi.Location = new Point(241, 167);
            txtDiaChi.Size = new Size(370, 32);
            txtDiaChi.Name = "txtDiaChi";

            //
            // lblSoTien
            //
            lblSoTien.Location = new Point(27, 214);
            lblSoTien.Size = new Size(194, 26);
            lblSoTien.Name = "lblSoTien";
            lblSoTien.Text = "Số tiền trong tài khoản:";

            //
            // txtSoTien
            //
            txtSoTien.Location = new Point(241, 211);
            txtSoTien.Size = new Size(370, 32);
            txtSoTien.Name = "txtSoTien";

            //
            // btnThem
            //
            btnThem.Location = new Point(137, 265);
            btnThem.Size = new Size(105, 36);
            btnThem.Name = "btnThem";
            btnThem.Text = "Thêm";
            btnThem.Click += btnThem_Click;

            //
            // btnLuu
            //
            btnLuu.Location = new Point(256, 265);
            btnLuu.Size = new Size(105, 36);
            btnLuu.Name = "btnLuu";
            btnLuu.Text = "Lưu";
            btnLuu.Click += btnLuu_Click;

            //
            // btnXoa
            //
            btnXoa.Location = new Point(375, 265);
            btnXoa.Size = new Size(105, 36);
            btnXoa.Name = "btnXoa";
            btnXoa.Text = "Xóa";
            btnXoa.Click += btnXoa_Click;

            //
            // btnThoat
            //
            btnThoat.Location = new Point(494, 265);
            btnThoat.Size = new Size(105, 36);
            btnThoat.Name = "btnThoat";
            btnThoat.Text = "Thoát";
            btnThoat.Click += btnThoat_Click;

            //
            // lvTaiKhoan
            //
            lvTaiKhoan.Location = new Point(30, 328);
            lvTaiKhoan.Size = new Size(625, 197);
            lvTaiKhoan.Name = "lvTaiKhoan";
            lvTaiKhoan.View = View.Details;
            lvTaiKhoan.GridLines = true;
            lvTaiKhoan.FullRowSelect = true;
            lvTaiKhoan.HideSelection = false;
            lvTaiKhoan.Columns.Add("STT", 51);
            lvTaiKhoan.Columns.Add("Số tài khoản", 145);
            lvTaiKhoan.Columns.Add("Tên khách hàng", 150);
            lvTaiKhoan.Columns.Add("Địa chỉ", 150);
            lvTaiKhoan.Columns.Add("Số tiền", 120);
            lvTaiKhoan.SelectedIndexChanged += lvTaiKhoan_SelectedIndexChanged;

            //
            // lblTong
            //
            lblTong.Location = new Point(402, 545);
            lblTong.Size = new Size(116, 27);
            lblTong.Name = "lblTong";
            lblTong.Text = "Tổng tiền:";

            //
            // txtTong
            //
            txtTong.Location = new Point(524, 540);
            txtTong.Size = new Size(131, 31);
            txtTong.Name = "txtTong";
            txtTong.ReadOnly = true;
            txtTong.TextAlign = HorizontalAlignment.Right;
            Controls.Add(lblTieuDe);
            Controls.Add(lblSoTaiKhoan);
            Controls.Add(txtSoTaiKhoan);
            Controls.Add(lblKhachHang);
            Controls.Add(txtKhachHang);
            Controls.Add(lblDiaChi);
            Controls.Add(txtDiaChi);
            Controls.Add(lblSoTien);
            Controls.Add(txtSoTien);
            Controls.Add(btnThem);
            Controls.Add(btnLuu);
            Controls.Add(btnXoa);
            Controls.Add(btnThoat);
            Controls.Add(lvTaiKhoan);
            Controls.Add(lblTong);
            Controls.Add(txtTong);


            //
            // Form1
            //
            ClientSize = new Size(685, 605);
            Font = new Font("Segoe UI", 10F);
            Name = "Form1";
            Text = "Bài tại lớp 2 - Quản lý tài khoản";
            StartPosition = FormStartPosition.CenterScreen;
            AutoScaleMode = AutoScaleMode.Font;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTieuDe;
        private Label lblSoTaiKhoan;
        private TextBox txtSoTaiKhoan;
        private Label lblKhachHang;
        private TextBox txtKhachHang;
        private Label lblDiaChi;
        private TextBox txtDiaChi;
        private Label lblSoTien;
        private TextBox txtSoTien;
        private Button btnThem;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnThoat;
        private ListView lvTaiKhoan;
        private Label lblTong;
        private TextBox txtTong;
    }
}
