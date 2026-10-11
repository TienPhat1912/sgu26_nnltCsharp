#nullable disable
using System.Drawing;
using System.Windows.Forms;

namespace B02_ListView
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
            btnThem = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            lblMa = new Label();
            txtMa = new TextBox();
            lblTen = new Label();
            txtTen = new TextBox();
            lvSinhVien = new ListView();
            SuspendLayout();

            //
            // btnThem
            //
            btnThem.Location = new Point(23, 17);
            btnThem.Size = new Size(114, 38);
            btnThem.Name = "btnThem";
            btnThem.Text = "Thêm";
            btnThem.Click += btnThem_Click;

            //
            // btnXoa
            //
            btnXoa.Location = new Point(157, 17);
            btnXoa.Size = new Size(114, 38);
            btnXoa.Name = "btnXoa";
            btnXoa.Text = "Xóa";
            btnXoa.Click += btnXoa_Click;

            //
            // btnSua
            //
            btnSua.Location = new Point(291, 17);
            btnSua.Size = new Size(114, 38);
            btnSua.Name = "btnSua";
            btnSua.Text = "Sửa";
            btnSua.Click += btnSua_Click;

            //
            // lblMa
            //
            lblMa.Location = new Point(23, 82);
            lblMa.Size = new Size(104, 25);
            lblMa.Name = "lblMa";
            lblMa.Text = "Mã SV:";

            //
            // txtMa
            //
            txtMa.Location = new Point(146, 77);
            txtMa.Size = new Size(340, 32);
            txtMa.Name = "txtMa";

            //
            // lblTen
            //
            lblTen.Location = new Point(23, 130);
            lblTen.Size = new Size(104, 25);
            lblTen.Name = "lblTen";
            lblTen.Text = "Họ tên:";

            //
            // txtTen
            //
            txtTen.Location = new Point(146, 125);
            txtTen.Size = new Size(340, 32);
            txtTen.Name = "txtTen";

            //
            // lvSinhVien
            //
            lvSinhVien.Location = new Point(24, 190);
            lvSinhVien.Size = new Size(460, 265);
            lvSinhVien.Name = "lvSinhVien";
            lvSinhVien.View = View.Details;
            lvSinhVien.FullRowSelect = true;
            lvSinhVien.GridLines = true;
            lvSinhVien.MultiSelect = true;
            lvSinhVien.HideSelection = false;
            lvSinhVien.Columns.Add("MÃ SỐ SV", 160);
            lvSinhVien.Columns.Add("HỌ VÀ TÊN", 290);
            lvSinhVien.SelectedIndexChanged += lvSinhVien_SelectedIndexChanged;
            Controls.Add(btnThem);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(lblMa);
            Controls.Add(txtMa);
            Controls.Add(lblTen);
            Controls.Add(txtTen);
            Controls.Add(lvSinhVien);


            //
            // Form1
            //
            ClientSize = new Size(535, 500);
            Font = new Font("Segoe UI", 10F);
            Name = "Form1";
            Text = "Bài mẫu 2 - Thao tác ListView";
            StartPosition = FormStartPosition.CenterScreen;
            AutoScaleMode = AutoScaleMode.Font;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnThem;
        private Button btnXoa;
        private Button btnSua;
        private Label lblMa;
        private TextBox txtMa;
        private Label lblTen;
        private TextBox txtTen;
        private ListView lvSinhVien;
    }
}
