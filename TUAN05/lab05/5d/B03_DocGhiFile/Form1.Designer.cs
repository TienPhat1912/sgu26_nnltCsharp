#nullable disable
using System.Drawing;
using System.Windows.Forms;

namespace B03_DocGhiFile
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
            lblDuongDan = new Label();
            txtDuongDan = new TextBox();
            rtbNoiDung = new RichTextBox();
            btnMo = new Button();
            btnLuu = new Button();
            SuspendLayout();

            //
            // lblDuongDan
            //
            lblDuongDan.Location = new Point(20, 27);
            lblDuongDan.Size = new Size(100, 28);
            lblDuongDan.Name = "lblDuongDan";
            lblDuongDan.Text = "Đường dẫn:";

            //
            // txtDuongDan
            //
            txtDuongDan.Location = new Point(132, 24);
            txtDuongDan.Size = new Size(436, 32);
            txtDuongDan.Name = "txtDuongDan";
            txtDuongDan.ReadOnly = true;

            //
            // rtbNoiDung
            //
            rtbNoiDung.Location = new Point(20, 78);
            rtbNoiDung.Size = new Size(548, 326);
            rtbNoiDung.Name = "rtbNoiDung";

            //
            // btnMo
            //
            btnMo.Location = new Point(204, 427);
            btnMo.Size = new Size(137, 40);
            btnMo.Name = "btnMo";
            btnMo.Text = "Mở File";
            btnMo.Click += btnMo_Click;

            //
            // btnLuu
            //
            btnLuu.Location = new Point(362, 427);
            btnLuu.Size = new Size(137, 40);
            btnLuu.Name = "btnLuu";
            btnLuu.Text = "Lưu File";
            btnLuu.Click += btnLuu_Click;
            Controls.Add(lblDuongDan);
            Controls.Add(txtDuongDan);
            Controls.Add(rtbNoiDung);
            Controls.Add(btnMo);
            Controls.Add(btnLuu);


            //
            // Form1
            //
            ClientSize = new Size(605, 520);
            Font = new Font("Segoe UI", 10F);
            Name = "Form1";
            Text = "Bài mẫu 3 - Đọc ghi tệp TXT";
            StartPosition = FormStartPosition.CenterScreen;
            AutoScaleMode = AutoScaleMode.Font;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDuongDan;
        private TextBox txtDuongDan;
        private RichTextBox rtbNoiDung;
        private Button btnMo;
        private Button btnLuu;
    }
}
