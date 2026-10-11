namespace ListBoxSofm
{
    public partial class ListBoxSofm : Form
    {
        public ListBoxSofm()
        {
            InitializeComponent();
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

        private void btnThem_Click(object? sender, EventArgs e)
        {
            if (!int.TryParse(txtSo.Text, out int number) || number < 0)
            { ThongBao("Nhập số tự nhiên không âm."); return; }
            lstSo.Items.Add(number);
            txtSo.Clear();
            txtSo.Focus();
        }

        private void btnTinhTong_Click(object? sender, EventArgs e)
        {
            ThongBao("Tổng các phần tử: " + lstSo.Items.Cast<int>().Sum(x => (long)x));
        }

        private void btnXoaDauCuoi_Click(object? sender, EventArgs e)
        {
            if (lstSo.Items.Count == 0) return;
            lstSo.Items.RemoveAt(lstSo.Items.Count - 1);
            if (lstSo.Items.Count > 0) lstSo.Items.RemoveAt(0);
        }

        private void btnXoaChon_Click(object? sender, EventArgs e)
        {
            foreach (int index in lstSo.SelectedIndices.Cast<int>().OrderByDescending(i => i).ToArray())
                lstSo.Items.RemoveAt(index);
        }

        private void BienDoi(Func<int, int> function)
        {
            try
            {
                int[] values = lstSo.Items.Cast<int>().Select(function).ToArray();
                for (int i = 0; i < values.Length; i++) lstSo.Items[i] = values[i];
            }
            catch (OverflowException) { ThongBao("Giá trị vượt giới hạn int."); }
        }

        private void btnTangHai_Click(object? sender, EventArgs e) => BienDoi(x => checked(x + 2));
        private void btnBinhPhuong_Click(object? sender, EventArgs e) => BienDoi(x => checked(x * x));

        private void ChonTheoDieuKien(Func<int, bool> predicate)
        {
            lstSo.ClearSelected();
            for (int i = 0; i < lstSo.Items.Count; i++)
                if (predicate((int)lstSo.Items[i]!)) lstSo.SetSelected(i, true);
        }

        private void btnChonChan_Click(object? sender, EventArgs e) => ChonTheoDieuKien(x => x % 2 == 0);
        private void btnChonLe_Click(object? sender, EventArgs e) => ChonTheoDieuKien(x => x % 2 != 0);

        private void ListBoxSofm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show(
        "Bạn có chắc chắn muốn thoát?",
        "Xác nhận",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question
    );

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnQuit_Click(object sender, EventArgs e) => Close();
    }
}
