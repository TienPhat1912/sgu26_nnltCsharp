using System.Drawing;

namespace QuanLySVfm
{
    public partial class QuanLySVfm : Form
    {
        public QuanLySVfm()
        {
            InitializeComponent();
            foreach (string className in new[] { "DCT124C1", "DCT124C2", "DCT124C3" })
            {
                treeLop.Nodes.Add(className);
                cboLop.Items.Add(className);
            }
            cboLop.SelectedIndex = 0;
            groupLop.Visible = false;
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

        private sealed class SinhVien
        {
            public string Ma { get; init; } = "";
            public string HoTen { get; init; } = "";
            public string DiaChi { get; init; } = "";
        }

        private void chkThemLop_CheckedChanged(object? sender, EventArgs e)
        {
            groupLop.Visible = chkThemLop.Checked;
        }

        private void btnThemLop_Click(object? sender, EventArgs e)
        {
            string className = txtLop.Text.Trim();
            if (className.Length == 0) { ThongBao("Hãy nhập tên lớp."); return; }
            if (treeLop.Nodes.Cast<TreeNode>().Any(n =>
                string.Equals(n.Text, className, StringComparison.OrdinalIgnoreCase)))
            { ThongBao("Tên lớp đã tồn tại."); return; }
            treeLop.Nodes.Add(className);
            cboLop.Items.Add(className);
            cboLop.SelectedItem = className;
            txtLop.Clear();
        }

        private bool MaDaTonTai(string ma)
        {
            return treeLop.Nodes.Cast<TreeNode>()
                .SelectMany(n => n.Nodes.Cast<TreeNode>())
                .Any(n => n.Tag is SinhVien sv &&
                    string.Equals(sv.Ma, ma, StringComparison.OrdinalIgnoreCase));
        }

        private void btnCapNhat_Click(object? sender, EventArgs e)
        {
            string id = txtMa.Text.Trim(), name = txtTen.Text.Trim(), address = txtDiaChi.Text.Trim();
            if (id.Length == 0 || name.Length == 0 || address.Length == 0)
            { ThongBao("Không được để trống thông tin sinh viên."); return; }
            if (MaDaTonTai(id)) { ThongBao("Mã sinh viên đã tồn tại."); return; }
            TreeNode? parent = treeLop.Nodes.Cast<TreeNode>()
                .FirstOrDefault(n => n.Text == cboLop.Text);
            if (parent is null) { ThongBao("Hãy chọn lớp."); return; }
            var child = parent.Nodes.Add(id + " - " + name);
            child.Tag = new SinhVien { Ma = id, HoTen = name, DiaChi = address };
            parent.Expand();
            txtMa.Clear(); txtTen.Clear(); txtDiaChi.Clear();
        }

        private void treeLop_AfterSelect(object? sender, TreeViewEventArgs e)
        {
            if (e.Node.Tag is not SinhVien sv) return;
            txtMa.Text = sv.Ma;
            txtTen.Text = sv.HoTen;
            txtDiaChi.Text = sv.DiaChi;
            cboLop.SelectedItem = e.Node.Parent?.Text;
        }

        private void btnXoa_Click(object? sender, EventArgs e)
        {
            TreeNode? node = treeLop.SelectedNode;
            if (node?.Tag is not SinhVien) { ThongBao("Hãy chọn sinh viên cần xóa."); return; }
            if (!XacNhan("Xóa sinh viên đang chọn?")) return;
            node.Remove();
            txtMa.Clear(); txtTen.Clear(); txtDiaChi.Clear();
        }
    }
}
