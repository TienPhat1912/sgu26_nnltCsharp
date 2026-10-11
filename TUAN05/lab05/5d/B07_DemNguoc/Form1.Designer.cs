#nullable disable
using System.Drawing;
using System.Windows.Forms;

namespace B07_DemNguoc
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
            lblThoiGian = new Label();
            btnBatDau = new Button();
            timerDemNguoc = new System.Windows.Forms.Timer(components); // Now unambiguous
            SuspendLayout();

            //
            // lblThoiGian
            //
            lblThoiGian.Location = new Point(83, 39);
            lblThoiGian.Size = new Size(192, 72);
            lblThoiGian.Name = "lblThoiGian";
            lblThoiGian.Text = "30:00";
            lblThoiGian.Font = new Font("Consolas", 25F, FontStyle.Bold);
            lblThoiGian.TextAlign = ContentAlignment.MiddleCenter;

            //
            // btnBatDau
            //
            btnBatDau.Location = new Point(118, 126);
            btnBatDau.Size = new Size(128, 42);
            btnBatDau.Name = "btnBatDau";
            btnBatDau.Text = "Bắt đầu";
            btnBatDau.Click += btnBatDau_Click;

            //
            // timerDemNguoc
            //
            timerDemNguoc.Interval = 1000;
            timerDemNguoc.Tick += timerDemNguoc_Tick;
            Controls.Add(lblThoiGian);
            Controls.Add(btnBatDau);


            //
            // Form1
            //
            ClientSize = new Size(360, 225);
            Font = new Font("Segoe UI", 10F);
            Name = "Form1";
            Text = "Bài về nhà 1 - Đồng hồ đếm ngược";
            StartPosition = FormStartPosition.CenterScreen;
            AutoScaleMode = AutoScaleMode.Font;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblThoiGian;
        private Button btnBatDau;
        private System.Windows.Forms.Timer timerDemNguoc;
    }
}
