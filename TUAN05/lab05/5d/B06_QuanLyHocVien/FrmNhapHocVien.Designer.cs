#nullable disable
using System.Drawing;
using System.Windows.Forms;

namespace B06_QuanLyHocVien
{
    partial class FrmNhapHocVien
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
            lblHoTen = new Label();
            txtHoTen = new TextBox();
            lblLop = new Label();
            cboLop = new ComboBox();
            btnCapNhat = new Button();
            btnTroVe = new Button();
            SuspendLayout();

            //
            // lblHoTen
            //
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Location = new Point(24, 29);
            lblHoTen.Size = new Size(130, 30);
            lblHoTen.Text = "Họ và tên:";

            //
            // txtHoTen
            //
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Location = new Point(159, 28);
            txtHoTen.Size = new Size(256, 32);

            //
            // lblLop
            //
            lblLop.Name = "lblLop";
            lblLop.Location = new Point(24, 88);
            lblLop.Size = new Size(130, 30);
            lblLop.Text = "Lớp:";

            //
            // cboLop
            //
            cboLop.Name = "cboLop";
            cboLop.Location = new Point(159, 85);
            cboLop.Size = new Size(256, 32);
            cboLop.DropDownStyle = ComboBoxStyle.DropDownList;

            //
            // btnCapNhat
            //
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Location = new Point(139, 151);
            btnCapNhat.Size = new Size(122, 41);
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.Click += btnCapNhat_Click;

            //
            // btnTroVe
            //
            btnTroVe.Name = "btnTroVe";
            btnTroVe.Location = new Point(281, 151);
            btnTroVe.Size = new Size(122, 41);
            btnTroVe.Text = "Trở về";
            btnTroVe.Click += btnTroVe_Click;

            Controls.Add(lblHoTen);
            Controls.Add(txtHoTen);
            Controls.Add(lblLop);
            Controls.Add(cboLop);
            Controls.Add(btnCapNhat);
            Controls.Add(btnTroVe);

            //
            // FrmNhapHocVien
            //
            ClientSize = new Size(455, 235);
            Text = "Nhập học viên mới";
            Font = new Font("Segoe UI", 10F);
            StartPosition = FormStartPosition.CenterParent;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            AutoScaleMode = AutoScaleMode.Font;
            AcceptButton = btnCapNhat;
            CancelButton = btnTroVe;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHoTen;
        private TextBox txtHoTen;
        private Label lblLop;
        private ComboBox cboLop;
        private Button btnCapNhat;
        private Button btnTroVe;
    }
}
