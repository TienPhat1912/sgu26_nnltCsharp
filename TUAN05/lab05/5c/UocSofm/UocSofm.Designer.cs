namespace UocSofm
{
    partial class UocSofm
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
            lblNhap = new Label();
            txtSo = new TextBox();
            lblChon = new Label();
            cboSo = new ComboBox();
            btnCapNhat = new Button();
            lblUoc = new Label();
            lstUoc = new ListBox();
            btnTong = new Button();
            btnUocChan = new Button();
            btnUocNguyenTo = new Button();
            btnThoat = new Button();
            SuspendLayout();

            //
            // lblNhap
            //
            lblNhap.Location = new Point(32, 60);
            lblNhap.Size = new Size(135, 30);
            lblNhap.Name = "lblNhap";
            lblNhap.Text = "Nhập số:";

            //
            // txtSo
            //
            txtSo.Location = new Point(175, 57);
            txtSo.Size = new Size(210, 31);
            txtSo.Name = "txtSo";

            //
            // lblChon
            //
            lblChon.Location = new Point(32, 133);
            lblChon.Size = new Size(140, 30);
            lblChon.Name = "lblChon";
            lblChon.Text = "Danh sách số:";

            //
            // cboSo
            //
            cboSo.Location = new Point(175, 130);
            cboSo.Size = new Size(210, 31);
            cboSo.Name = "cboSo";
            cboSo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSo.SelectedIndexChanged += cboSo_SelectedIndexChanged;

            //
            // btnCapNhat
            //
            btnCapNhat.Location = new Point(175, 202);
            btnCapNhat.Size = new Size(155, 38);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Text = "&Cập nhật";
            btnCapNhat.Click += btnCapNhat_Click;

            //
            // lblUoc
            //
            lblUoc.Location = new Point(460, 28);
            lblUoc.Size = new Size(310, 30);
            lblUoc.Name = "lblUoc";
            lblUoc.Text = "Danh sách các ước:";

            //
            // lstUoc
            //
            lstUoc.Location = new Point(460, 68);
            lstUoc.Size = new Size(325, 430);
            lstUoc.Name = "lstUoc";

            //
            // btnTong
            //
            btnTong.Location = new Point(78, 267);
            btnTong.Size = new Size(265, 38);
            btnTong.Name = "btnTong";
            btnTong.Text = "&Tổng các ước số";
            btnTong.Click += btnTong_Click;

            //
            // btnUocChan
            //
            btnUocChan.Location = new Point(78, 325);
            btnUocChan.Size = new Size(265, 38);
            btnUocChan.Name = "btnUocChan";
            btnUocChan.Text = "Ước &chẵn";
            btnUocChan.Click += btnUocChan_Click;

            //
            // btnUocNguyenTo
            //
            btnUocNguyenTo.Location = new Point(78, 383);
            btnUocNguyenTo.Size = new Size(265, 38);
            btnUocNguyenTo.Name = "btnUocNguyenTo";
            btnUocNguyenTo.Text = "Ước &nguyên tố";
            btnUocNguyenTo.Click += btnUocNguyenTo_Click;

            //
            // btnThoat
            //
            btnThoat.Location = new Point(78, 441);
            btnThoat.Size = new Size(265, 38);
            btnThoat.Name = "btnThoat";
            btnThoat.Text = "Thoát";
            btnThoat.Click += btnThoat_Click;
            Controls.Add(lblNhap);
            Controls.Add(txtSo);
            Controls.Add(lblChon);
            Controls.Add(cboSo);
            Controls.Add(btnCapNhat);
            Controls.Add(lblUoc);
            Controls.Add(lstUoc);
            Controls.Add(btnTong);
            Controls.Add(btnUocChan);
            Controls.Add(btnUocNguyenTo);
            Controls.Add(btnThoat);
            FormClosing += Form1_FormClosing;


            //
            // Form1
            //
            ClientSize = new Size(900, 570);
            Font = new Font("Segoe UI", 10F);
            Name = "Form1";
            Text = "Bài tại lớp 1 - Ước số";
            StartPosition = FormStartPosition.CenterScreen;
            AutoScaleMode = AutoScaleMode.Font;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNhap;
        private TextBox txtSo;
        private Label lblChon;
        private ComboBox cboSo;
        private Button btnCapNhat;
        private Label lblUoc;
        private ListBox lstUoc;
        private Button btnTong;
        private Button btnUocChan;
        private Button btnUocNguyenTo;
        private Button btnThoat;


    }
}
