#nullable disable
using System.Drawing;
using System.Windows.Forms;

namespace B04_QuanLySinhVien
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
            lblTen = new Label();
            txtTen = new TextBox();
            lblMa = new Label();
            txtMa = new TextBox();
            lblGioiTinh = new Label();
            rdoNam = new RadioButton();
            rdoNu = new RadioButton();
            lblNgoaiNgu = new Label();
            chkAnh = new CheckBox();
            chkPhap = new CheckBox();
            chkHoa = new CheckBox();
            lblDanToc = new Label();
            cboDanToc = new ComboBox();
            lvSinhVien = new ListView();
            btnThem = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            menuChuOt = new ContextMenuStrip();
            menuXoa = new ToolStripMenuItem();
            SuspendLayout();

            //
            // lblTen
            //
            lblTen.Location = new Point(25, 25);
            lblTen.Size = new Size(124, 27);
            lblTen.Name = "lblTen";
            lblTen.Text = "Họ và tên:";

            //
            // txtTen
            //
            txtTen.Location = new Point(160, 22);
            txtTen.Size = new Size(285, 30);
            txtTen.Name = "txtTen";

            //
            // lblMa
            //
            lblMa.Location = new Point(25, 67);
            lblMa.Size = new Size(124, 27);
            lblMa.Name = "lblMa";
            lblMa.Text = "Mã sinh viên:";

            //
            // txtMa
            //
            txtMa.Location = new Point(160, 64);
            txtMa.Size = new Size(285, 30);
            txtMa.Name = "txtMa";

            //
            // lblGioiTinh
            //
            lblGioiTinh.Location = new Point(25, 105);
            lblGioiTinh.Size = new Size(128, 27);
            lblGioiTinh.Name = "lblGioiTinh";
            lblGioiTinh.Text = "Giới tính:";

            //
            // rdoNam
            //
            rdoNam.Location = new Point(160, 104);
            rdoNam.Size = new Size(78, 28);
            rdoNam.Name = "rdoNam";
            rdoNam.Text = "Nam";
            rdoNam.Checked = true;

            //
            // rdoNu
            //
            rdoNu.Location = new Point(265, 104);
            rdoNu.Size = new Size(77, 28);
            rdoNu.Name = "rdoNu";
            rdoNu.Text = "Nữ";

            //
            // lblNgoaiNgu
            //
            lblNgoaiNgu.Location = new Point(25, 147);
            lblNgoaiNgu.Size = new Size(128, 28);
            lblNgoaiNgu.Name = "lblNgoaiNgu";
            lblNgoaiNgu.Text = "Ngoại ngữ:";

            //
            // chkAnh
            //
            chkAnh.Location = new Point(160, 147);
            chkAnh.Size = new Size(80, 28);
            chkAnh.Name = "chkAnh";
            chkAnh.Text = "Anh";

            //
            // chkPhap
            //
            chkPhap.Location = new Point(262, 147);
            chkPhap.Size = new Size(80, 28);
            chkPhap.Name = "chkPhap";
            chkPhap.Text = "Pháp";

            //
            // chkHoa
            //
            chkHoa.Location = new Point(364, 147);
            chkHoa.Size = new Size(80, 28);
            chkHoa.Name = "chkHoa";
            chkHoa.Text = "Hoa";

            //
            // lblDanToc
            //
            lblDanToc.Location = new Point(25, 186);
            lblDanToc.Size = new Size(128, 27);
            lblDanToc.Name = "lblDanToc";
            lblDanToc.Text = "Dân tộc:";

            //
            // cboDanToc
            //
            cboDanToc.Location = new Point(160, 184);
            cboDanToc.Size = new Size(285, 31);
            cboDanToc.Name = "cboDanToc";
            cboDanToc.DropDownStyle = ComboBoxStyle.DropDownList;

            //
            // lvSinhVien
            //
            lvSinhVien.Location = new Point(24, 231);
            lvSinhVien.Size = new Size(704, 253);
            lvSinhVien.Name = "lvSinhVien";
            lvSinhVien.View = View.Details;
            lvSinhVien.GridLines = true;
            lvSinhVien.FullRowSelect = true;
            lvSinhVien.HideSelection = false;
            lvSinhVien.MultiSelect = true;
            lvSinhVien.ContextMenuStrip = menuChuOt;
            lvSinhVien.Columns.Add("Họ tên", 165);
            lvSinhVien.Columns.Add("Mã SV", 112);
            lvSinhVien.Columns.Add("Giới tính", 97);
            lvSinhVien.Columns.Add("Ngoại ngữ", 165);
            lvSinhVien.Columns.Add("Dân tộc", 140);
            lvSinhVien.SelectedIndexChanged += lvSinhVien_SelectedIndexChanged;

            //
            // btnThem
            //
            btnThem.Location = new Point(159, 503);
            btnThem.Size = new Size(118, 40);
            btnThem.Name = "btnThem";
            btnThem.Text = "Thêm";
            btnThem.Click += btnThem_Click;

            //
            // btnXoa
            //
            btnXoa.Location = new Point(304, 503);
            btnXoa.Size = new Size(118, 40);
            btnXoa.Name = "btnXoa";
            btnXoa.Text = "Xóa";
            btnXoa.Click += btnXoa_Click;

            //
            // btnSua
            //
            btnSua.Location = new Point(449, 503);
            btnSua.Size = new Size(118, 40);
            btnSua.Name = "btnSua";
            btnSua.Text = "Sửa";
            btnSua.Click += btnSua_Click;

            //
            // menuChuOt
            //
            menuChuOt.Name = "menuChuOt";

            //
            // menuXoa
            //
            menuXoa.Name = "menuXoa";
            menuXoa.Text = "Xóa sinh viên đã chọn";
            menuXoa.Click += menuXoa_Click;
            Controls.Add(lblTen);
            Controls.Add(txtTen);
            Controls.Add(lblMa);
            Controls.Add(txtMa);
            Controls.Add(lblGioiTinh);
            Controls.Add(rdoNam);
            Controls.Add(rdoNu);
            Controls.Add(lblNgoaiNgu);
            Controls.Add(chkAnh);
            Controls.Add(chkPhap);
            Controls.Add(chkHoa);
            Controls.Add(lblDanToc);
            Controls.Add(cboDanToc);
            Controls.Add(lvSinhVien);
            Controls.Add(btnThem);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);

            //
            // menuChuOt
            //
            menuChuOt.Items.Add(menuXoa);
            FormClosing += Form1_FormClosing;


            //
            // Form1
            //
            ClientSize = new Size(755, 575);
            Font = new Font("Segoe UI", 10F);
            Name = "Form1";
            Text = "Bài tại lớp 1 - Quản lý sinh viên";
            StartPosition = FormStartPosition.CenterScreen;
            AutoScaleMode = AutoScaleMode.Font;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTen;
        private TextBox txtTen;
        private Label lblMa;
        private TextBox txtMa;
        private Label lblGioiTinh;
        private RadioButton rdoNam;
        private RadioButton rdoNu;
        private Label lblNgoaiNgu;
        private CheckBox chkAnh;
        private CheckBox chkPhap;
        private CheckBox chkHoa;
        private Label lblDanToc;
        private ComboBox cboDanToc;
        private ListView lvSinhVien;
        private Button btnThem;
        private Button btnXoa;
        private Button btnSua;
        private ContextMenuStrip menuChuOt;
        private ToolStripMenuItem menuXoa;
    }
}
