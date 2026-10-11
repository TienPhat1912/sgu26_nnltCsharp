#nullable disable
using System.Drawing;
using System.Windows.Forms;

namespace B06_QuanLyHocVien
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
            menuChinh = new MenuStrip();
            menuCapNhat = new ToolStripMenuItem();
            menuKetThuc = new ToolStripMenuItem();
            menuNhap = new ToolStripMenuItem();
            menuSangB = new ToolStripMenuItem();
            menuSangA = new ToolStripMenuItem();
            menuXoa = new ToolStripMenuItem();
            lblLopA = new Label();
            lstLopA = new ListBox();
            lblLopB = new Label();
            lstLopB = new ListBox();
            SuspendLayout();

            //
            // menuChinh
            //
            menuChinh.Name = "menuChinh";

            //
            // menuCapNhat
            //
            menuCapNhat.Name = "menuCapNhat";
            menuCapNhat.Text = "Cập nhật";

            //
            // menuKetThuc
            //
            menuKetThuc.Name = "menuKetThuc";
            menuKetThuc.Text = "Kết thúc";
            menuKetThuc.Click += menuKetThuc_Click;

            //
            // menuNhap
            //
            menuNhap.Name = "menuNhap";
            menuNhap.Text = "Nhập học viên mới";
            menuNhap.Click += menuNhap_Click;

            //
            // menuSangB
            //
            menuSangB.Name = "menuSangB";
            menuSangB.Text = "Chuyển sang lớp B";
            menuSangB.Click += menuSangB_Click;

            //
            // menuSangA
            //
            menuSangA.Name = "menuSangA";
            menuSangA.Text = "Chuyển sang lớp A";
            menuSangA.Click += menuSangA_Click;

            //
            // menuXoa
            //
            menuXoa.Name = "menuXoa";
            menuXoa.Text = "Xóa học viên";
            menuXoa.Click += menuXoa_Click;

            //
            // lblLopA
            //
            lblLopA.Location = new Point(35, 64);
            lblLopA.Size = new Size(155, 30);
            lblLopA.Name = "lblLopA";
            lblLopA.Text = "Lớp A";

            //
            // lstLopA
            //
            lstLopA.Location = new Point(35, 104);
            lstLopA.Size = new Size(245, 280);
            lstLopA.Name = "lstLopA";
            lstLopA.SelectionMode = SelectionMode.MultiExtended;

            //
            // lblLopB
            //
            lblLopB.Location = new Point(323, 64);
            lblLopB.Size = new Size(155, 30);
            lblLopB.Name = "lblLopB";
            lblLopB.Text = "Lớp B";

            //
            // lstLopB
            //
            lstLopB.Location = new Point(323, 104);
            lstLopB.Size = new Size(245, 280);
            lstLopB.Name = "lstLopB";
            lstLopB.SelectionMode = SelectionMode.MultiExtended;
            Controls.Add(menuChinh);
            Controls.Add(lblLopA);
            Controls.Add(lstLopA);
            Controls.Add(lblLopB);
            Controls.Add(lstLopB);
            menuCapNhat.DropDownItems.AddRange(new ToolStripItem[] { menuNhap, menuSangB, menuSangA, menuXoa });

            //
            // menuChinh
            //
            menuChinh.Items.AddRange(new ToolStripItem[] { menuCapNhat, menuKetThuc });
            MainMenuStrip = menuChinh;
            FormClosing += Form1_FormClosing;


            //
            // Form1
            //
            ClientSize = new Size(615, 475);
            Font = new Font("Segoe UI", 10F);
            Name = "Form1";
            Text = "Bài nâng cao 1 - Quản lý học viên";
            StartPosition = FormStartPosition.CenterScreen;
            AutoScaleMode = AutoScaleMode.Font;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuChinh;
        private ToolStripMenuItem menuCapNhat;
        private ToolStripMenuItem menuKetThuc;
        private ToolStripMenuItem menuNhap;
        private ToolStripMenuItem menuSangB;
        private ToolStripMenuItem menuSangA;
        private ToolStripMenuItem menuXoa;
        private Label lblLopA;
        private ListBox lstLopA;
        private Label lblLopB;
        private ListBox lstLopB;
    }
}
