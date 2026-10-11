namespace DanhBafm
{
    partial class DanhBafm
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
            components = new System.ComponentModel.Container();
            lblDanhBa = new Label();
            treeDanhBa = new TreeView();
            lblHoTen = new Label();
            txtHoTen = new TextBox();
            btnThem = new Button();
            SuspendLayout();

            //
            // lblDanhBa
            //
            lblDanhBa.Location = new Point(25, 16);
            lblDanhBa.Size = new Size(300, 27);
            lblDanhBa.Name = "lblDanhBa";
            lblDanhBa.Text = "Danh bạ A - Z";

            //
            // treeDanhBa
            //
            treeDanhBa.Location = new Point(25, 52);
            treeDanhBa.Size = new Size(444, 453);
            treeDanhBa.Name = "treeDanhBa";

            //
            // lblHoTen
            //
            lblHoTen.Location = new Point(490, 83);
            lblHoTen.Size = new Size(135, 27);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Text = "Họ và tên:";

            //
            // txtHoTen
            //
            txtHoTen.Location = new Point(639, 79);
            txtHoTen.Size = new Size(232, 32);
            txtHoTen.Name = "txtHoTen";

            //
            // btnThem
            //
            btnThem.Location = new Point(640, 146);
            btnThem.Size = new Size(170, 43);
            btnThem.Name = "btnThem";
            btnThem.Text = "Thêm";
            btnThem.Click += btnThem_Click;
            Controls.Add(lblDanhBa);
            Controls.Add(treeDanhBa);
            Controls.Add(lblHoTen);
            Controls.Add(txtHoTen);
            Controls.Add(btnThem);


            //
            // Form1
            //
            ClientSize = new Size(920, 555);
            Font = new Font("Segoe UI", 10F);
            Name = "Form1";
            Text = "Bài về nhà 3 - Danh bạ A-Z";
            StartPosition = FormStartPosition.CenterScreen;
            AutoScaleMode = AutoScaleMode.Font;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDanhBa;
        private TreeView treeDanhBa;
        private Label lblHoTen;
        private TextBox txtHoTen;
        private Button btnThem;
    }
}
