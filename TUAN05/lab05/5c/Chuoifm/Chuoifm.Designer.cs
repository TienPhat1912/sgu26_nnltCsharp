
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Chuoifm
{
    partial class Chuoifm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
        /// Required method for Designer support.
        /// </summary>
        private void InitializeComponent()
        {
            lstHoTen = new ListBox();
            btnNgauNhien = new Button();
            btnXoaChon = new Button();
            btnXoaTenSon = new Button();
            btnXoaHoLe = new Button();
            btnChuHoa = new Button();
            btnChuThuong = new Button();
            btnVietHoa = new Button();
            btnXoaTatCa = new Button();

            SuspendLayout();

            //
            // lstHoTen
            //
            lstHoTen.FormattingEnabled = true;
            lstHoTen.HorizontalScrollbar = true;
            lstHoTen.IntegralHeight = false;
            lstHoTen.ItemHeight = 22;
            lstHoTen.Location = new Point(30, 80);
            lstHoTen.Name = "lstHoTen";
            lstHoTen.SelectionMode = SelectionMode.MultiExtended;
            lstHoTen.Size = new Size(240, 355);
            lstHoTen.TabIndex = 0;
            lstHoTen.MouseDoubleClick +=
                lstHoTen_MouseDoubleClick;

            //
            // btnNgauNhien
            //
            btnNgauNhien.Location = new Point(30, 25);
            btnNgauNhien.Name = "btnNgauNhien";
            btnNgauNhien.Size = new Size(240, 42);
            btnNgauNhien.TabIndex = 1;
            btnNgauNhien.Text = "Nhập tên ngẫu nhiên";
            btnNgauNhien.UseVisualStyleBackColor = true;
            btnNgauNhien.Click += btnNgauNhien_Click;

            //
            // btnXoaChon
            //
            btnXoaChon.Location = new Point(300, 80);
            btnXoaChon.Name = "btnXoaChon";
            btnXoaChon.Size = new Size(400, 43);
            btnXoaChon.TabIndex = 2;
            btnXoaChon.Text = "Xóa phần tử đang chọn";
            btnXoaChon.UseVisualStyleBackColor = true;
            btnXoaChon.Click += btnXoaChon_Click;

            //
            // btnXoaTenSon
            //
            btnXoaTenSon.Location = new Point(300, 132);
            btnXoaTenSon.Name = "btnXoaTenSon";
            btnXoaTenSon.Size = new Size(400, 43);
            btnXoaTenSon.TabIndex = 3;
            btnXoaTenSon.Text = "Xóa phần tử có tên là Sơn";
            btnXoaTenSon.UseVisualStyleBackColor = true;
            btnXoaTenSon.Click += btnXoaTenSon_Click;

            //
            // btnXoaHoLe
            //
            btnXoaHoLe.Location = new Point(300, 184);
            btnXoaHoLe.Name = "btnXoaHoLe";
            btnXoaHoLe.Size = new Size(400, 43);
            btnXoaHoLe.TabIndex = 4;
            btnXoaHoLe.Text = "Xóa phần tử có họ là Lê";
            btnXoaHoLe.UseVisualStyleBackColor = true;
            btnXoaHoLe.Click += btnXoaHoLe_Click;

            //
            // btnChuHoa
            //
            btnChuHoa.Location = new Point(300, 236);
            btnChuHoa.Name = "btnChuHoa";
            btnChuHoa.Size = new Size(400, 43);
            btnChuHoa.TabIndex = 5;
            btnChuHoa.Text =
                "Chuyển PT đang chọn thành chữ HOA";
            btnChuHoa.UseVisualStyleBackColor = true;
            btnChuHoa.Click += btnChuHoa_Click;

            //
            // btnChuThuong
            //
            btnChuThuong.Location = new Point(300, 288);
            btnChuThuong.Name = "btnChuThuong";
            btnChuThuong.Size = new Size(400, 43);
            btnChuThuong.TabIndex = 6;
            btnChuThuong.Text =
                "Chuyển PT đang chọn thành chữ thường";
            btnChuThuong.UseVisualStyleBackColor = true;
            btnChuThuong.Click += btnChuThuong_Click;

            //
            // btnVietHoa
            //
            btnVietHoa.Location = new Point(300, 340);
            btnVietHoa.Name = "btnVietHoa";
            btnVietHoa.Size = new Size(400, 43);
            btnVietHoa.TabIndex = 7;
            btnVietHoa.Text =
                "Viết hoa đầu mỗi từ";
            btnVietHoa.UseVisualStyleBackColor = true;
            btnVietHoa.Click += btnVietHoa_Click;

            //
            // btnXoaTatCa
            //
            btnXoaTatCa.Location = new Point(300, 392);
            btnXoaTatCa.Name = "btnXoaTatCa";
            btnXoaTatCa.Size = new Size(400, 43);
            btnXoaTatCa.TabIndex = 8;
            btnXoaTatCa.Text = "Xóa tất cả các phần tử";
            btnXoaTatCa.UseVisualStyleBackColor = true;
            btnXoaTatCa.Click += btnXoaTatCa_Click;

            //
            // Chuoifm
            //
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(740, 465);

            Controls.Add(lstHoTen);
            Controls.Add(btnNgauNhien);
            Controls.Add(btnXoaChon);
            Controls.Add(btnXoaTenSon);
            Controls.Add(btnXoaHoLe);
            Controls.Add(btnChuHoa);
            Controls.Add(btnChuThuong);
            Controls.Add(btnVietHoa);
            Controls.Add(btnXoaTatCa);

            Font = new Font(
                "Times New Roman",
                12F,
                FontStyle.Regular,
                GraphicsUnit.Point);

            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Chuoifm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmChuoi - Xử lý chuỗi";

            ResumeLayout(false);
        }

        #endregion

        private ListBox lstHoTen;
        private Button btnNgauNhien;
        private Button btnXoaChon;
        private Button btnXoaTenSon;
        private Button btnXoaHoLe;
        private Button btnChuHoa;
        private Button btnChuThuong;
        private Button btnVietHoa;
        private Button btnXoaTatCa;
    }
}
