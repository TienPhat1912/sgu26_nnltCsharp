using System.Globalization;

namespace TuDienfm
{
    public partial class TuDienfm : Form
    {
        private readonly CultureInfo vi =
            new CultureInfo("vi-VN");

        // Lớp lưu thông tin một từ vựng
        private class TuVung
        {
            public string Anh { get; set; }
            public string Viet { get; set; }
            public string NghiaViet { get; set; }

            public TuVung(string anh, string viet, string nghia)
            {
                Anh = anh;
                Viet = viet;
                NghiaViet = nghia;
            }
        }

        // Dữ liệu mẫu dùng chung cho hai chiều tra cứu
        private readonly TuVung[] tuDien =
        {
            new("student", "sinh viên", "Sinh viên, học sinh"),
            new("teacher", "giáo viên", "Giáo viên, thầy cô"),
            new("worker", "công nhân", "Công nhân, người lao động"),
            new("hat", "mũ", "Mũ, nón"),
            new("head", "đầu", "Đầu"),
            new("mouse", "chuột", "Con chuột"),
            new("cat", "mèo", "Con mèo"),
            new("dog", "chó", "Con chó"),
            new("snake", "rắn", "Con rắn"),
            new("lamb", "cừu non", "Cừu non"),
            new("loan", "khoản vay", "Khoản vay"),
            new("frog", "ếch", "Con ếch"),
            new("sheep", "cừu", "Con cừu"),
            new("book", "sách", "Quyển sách"),
            new("school", "trường học", "Trường học"),
            new("house", "ngôi nhà", "Ngôi nhà"),
            new("water", "nước", "Nước"),
            new("computer", "máy tính", "Máy tính"),
            new("apple", "táo", "Quả táo"),
            new("friend", "bạn bè", "Bạn bè")
        };
        public TuDienfm()
        {
            InitializeComponent();
            NapDuLieu();
        }

        // Nạp dữ liệu khi khởi tạo Form
        private void NapDuLieu()
        {
            foreach (TuVung tu in tuDien)
            {
                cboAnh.Items.Add(tu.Anh);
                lstAnh.Items.Add(tu.Anh);
            }

            var danhSachViet = tuDien
                .OrderBy(x => x.Viet,
                    StringComparer.Create(vi, true));

            foreach (TuVung tu in danhSachViet)
            {
                cboViet.Items.Add(tu.Viet);
                lstViet.Items.Add(tu.Viet);
            }
        }

        // Tìm từ có tiền tố khớp với chuỗi nhập
        private int TimTu(ListBox danhSach, string noiDung)
        {
            string tuCanTim = noiDung.Trim();

            if (tuCanTim.Length == 0)
                return -1;

            CompareInfo compareInfo = vi.CompareInfo;

            CompareOptions options =
                CompareOptions.IgnoreCase |
                CompareOptions.IgnoreNonSpace;

            // Ưu tiên khớp hoàn toàn
            for (int i = 0; i < danhSach.Items.Count; i++)
            {
                string tu = danhSach.Items[i]!.ToString()!;

                if (compareInfo.Compare(
                    tu, tuCanTim, options) == 0)
                {
                    return i;
                }
            }

            // Tìm từ bắt đầu bằng chuỗi đang nhập
            for (int i = 0; i < danhSach.Items.Count; i++)
            {
                string tu = danhSach.Items[i]!.ToString()!;

                if (compareInfo.IsPrefix(
                    tu, tuCanTim, options))
                {
                    return i;
                }
            }

            return -1;
        }

        // ============================
        // TAB ANH - VIỆT
        // ============================

        private void cboAnh_TextChanged(
            object sender, EventArgs e)
        {
            int index = TimTu(lstAnh, cboAnh.Text);

            lstAnh.SelectedIndex = index;

            if (index >= 0)
                lstAnh.TopIndex = index;

            txtViet.Clear();
        }

        // Hiển thị nghĩa của từ tiếng Anh
        private void HienThiAnhViet(string tu)
        {
            TuVung? ketQua = tuDien.FirstOrDefault(
                x => x.Anh.Equals(
                    tu, StringComparison.OrdinalIgnoreCase));

            if (ketQua == null)
            {
                txtViet.Text = "Không tìm thấy từ.";
                return;
            }

            cboAnh.Text = ketQua.Anh;
            txtViet.Text = ketQua.NghiaViet;
        }

        // Tra từ đang nhập trong ComboBox
        private void TraAnhViet()
        {
            int index = TimTu(lstAnh, cboAnh.Text);

            if (index == -1)
            {
                txtViet.Text = "Không tìm thấy từ phù hợp.";
                return;
            }

            string tu = lstAnh.Items[index]!.ToString()!;
            lstAnh.SelectedIndex = index;
            HienThiAnhViet(tu);
        }

        // Nhấn Enter trong ComboBox
        private void cboAnh_KeyDown(
            object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TraAnhViet();
                e.SuppressKeyPress = true;
            }
        }

        // Double Click một từ trong ListBox
        private void lstAnh_DoubleClick(
            object sender, EventArgs e)
        {
            if (lstAnh.SelectedItem == null)
                return;

            string tu = lstAnh.SelectedItem.ToString()!;
            HienThiAnhViet(tu);
        }

        // Nhấn Enter khi ListBox đang được chọn
        private void lstAnh_KeyDown(
            object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (lstAnh.SelectedItem != null)
                {
                    HienThiAnhViet(
                        lstAnh.SelectedItem.ToString()!);
                }

                e.SuppressKeyPress = true;
            }
        }

        // ============================
        // TAB VIỆT - ANH
        // ============================

        private void cboViet_TextChanged(
            object sender, EventArgs e)
        {
            int index = TimTu(lstViet, cboViet.Text);

            lstViet.SelectedIndex = index;

            if (index >= 0)
                lstViet.TopIndex = index;

            txtAnh.Clear();
        }

        // Hiển thị nghĩa tiếng Anh
        private void HienThiVietAnh(string tu)
        {
            TuVung? ketQua = tuDien.FirstOrDefault(
                x => vi.CompareInfo.Compare(
                    x.Viet, tu,
                    CompareOptions.IgnoreCase |
                    CompareOptions.IgnoreNonSpace) == 0);

            if (ketQua == null)
            {
                txtAnh.Text = "Không tìm thấy từ.";
                return;
            }

            cboViet.Text = ketQua.Viet;
            txtAnh.Text = ketQua.Anh;
        }

        // Tra từ tiếng Việt
        private void TraVietAnh()
        {
            int index = TimTu(lstViet, cboViet.Text);

            if (index == -1)
            {
                txtAnh.Text = "Không tìm thấy từ phù hợp.";
                return;
            }

            string tu = lstViet.Items[index]!.ToString()!;
            lstViet.SelectedIndex = index;
            HienThiVietAnh(tu);
        }

        // Nhấn Enter trong ComboBox
        private void cboViet_KeyDown(
            object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TraVietAnh();
                e.SuppressKeyPress = true;
            }
        }

        // Double Click một từ trong ListBox
        private void lstViet_DoubleClick(
            object sender, EventArgs e)
        {
            if (lstViet.SelectedItem == null)
                return;

            string tu = lstViet.SelectedItem.ToString()!;
            HienThiVietAnh(tu);
        }

        // Nhấn Enter trong ListBox
        private void lstViet_KeyDown(
            object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (lstViet.SelectedItem != null)
                {
                    HienThiVietAnh(
                        lstViet.SelectedItem.ToString()!);
                }

                e.SuppressKeyPress = true;
            }
        }

        // ============================
        // THOÁT CHƯƠNG TRÌNH
        // ============================

        private void btnThoat_Click(
            object sender, EventArgs e)
        {
            Close();
        }
    }
}
