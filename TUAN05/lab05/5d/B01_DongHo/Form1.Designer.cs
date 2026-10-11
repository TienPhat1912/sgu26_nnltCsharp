#nullable disable
using System.Drawing;
using System.Windows.Forms;

namespace B01_DongHo
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
            lblDongHo = new Label();
            timerDongHo = new System.Windows.Forms.Timer(components); // Fully qualify the Timer class
            SuspendLayout();

            //
            // lblDongHo
            //
            lblDongHo.Location = new Point(27, 65);
            lblDongHo.Size = new Size(360, 68);
            lblDongHo.Name = "lblDongHo";
            lblDongHo.Font = new Font("Segoe UI", 19F, FontStyle.Bold);
            lblDongHo.ForeColor = Color.Firebrick;
            lblDongHo.TextAlign = ContentAlignment.MiddleCenter;

            //
            // timerDongHo
            //
            timerDongHo.Interval = 1000;
            timerDongHo.Tick += timerDongHo_Tick;
            Controls.Add(lblDongHo);

            //
            // Form1
            //
            ClientSize = new Size(420, 230);
            Font = new Font("Segoe UI", 10F);
            Name = "Form1";
            Text = "Bài mẫu 1 - Đồng hồ hệ thống";
            StartPosition = FormStartPosition.CenterScreen;
            AutoScaleMode = AutoScaleMode.Font;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDongHo;
        private System.Windows.Forms.Timer timerDongHo;
    }
}
