namespace TreeViewfm
{
    public partial class TreeViewfm : Form
    {
        public TreeViewfm()
        {
            InitializeComponent();
            string[] departments = { "Giám đốc", "Tổ chức hành chính", "Kế hoạch", "Kế toán" };
            foreach (string name in departments)
            {
                trvPhongBan.Nodes.Add(name);
                cboPhongBan.Items.Add(name);
            }
            cboPhongBan.SelectedIndex = 0;
        }

        private static void ThongBao(string message)
        {
            MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private static bool XacNhan(string message)
        {
            return MessageBox.Show(message, "Xác nhận", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes;
        }

        private void btnThemPhongBan_Click(object? sender, EventArgs e)
        {
            string name = txtPhongBan.Text.Trim();
            if (name.Length == 0) { ThongBao("Hãy nhập tên phòng ban."); txtPhongBan.Focus(); return; }
            bool exists = trvPhongBan.Nodes.Cast<TreeNode>().Any(node =>
                string.Equals(node.Text, name, StringComparison.OrdinalIgnoreCase));
            if (exists) { ThongBao("Phòng ban đã tồn tại."); return; }
            trvPhongBan.Nodes.Add(name);
            cboPhongBan.Items.Add(name);
            txtPhongBan.Clear();
        }

        private void btnXoaPhongBan_Click(object? sender, EventArgs e)
        {
            TreeNode? node = trvPhongBan.SelectedNode;
            if (node == null || node.Parent != null) { ThongBao("Hãy chọn một phòng ban trong TreeView."); return; }
            if (!XacNhan("Xóa phòng ban và các nhân viên trực thuộc?")) return;
            cboPhongBan.Items.Remove(node.Text);
            trvPhongBan.Nodes.Remove(node);
            if (cboPhongBan.Items.Count > 0) cboPhongBan.SelectedIndex = 0;
        }

        private void btnThemNhanVien_Click(object? sender, EventArgs e)
        {
            string id = txtMaNhanVien.Text.Trim();
            string name = txtHoTen.Text.Trim();
            string address = txtDiaChi.Text.Trim();
            if (id.Length == 0 || name.Length == 0 || address.Length == 0)
            { ThongBao("Vui lòng nhập đủ thông tin nhân viên."); return; }
            TreeNode? parent = trvPhongBan.Nodes.Cast<TreeNode>()
                .FirstOrDefault(node => node.Text == cboPhongBan.Text);
            if (parent is null) { ThongBao("Hãy chọn phòng ban."); return; }
            parent.Nodes.Add($"{name} ({id}) - {address}");
            parent.Expand();
            txtMaNhanVien.Clear(); txtHoTen.Clear(); txtDiaChi.Clear();
        }

        private void btnThoat_Click(object? sender, EventArgs e) => Close();
        private void Form1_FormClosing(object? sender, FormClosingEventArgs e)
        {
            if (!XacNhan("Bạn muốn thoát?")) e.Cancel = true;
        }


    }
}
