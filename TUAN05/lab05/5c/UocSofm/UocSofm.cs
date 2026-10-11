using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace UocSofm
{
    public partial class UocSofm : Form
    {
        public UocSofm()
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

        private void btnCapNhat_Click(object? sender, EventArgs e)
        {
            if (!int.TryParse(txtSo.Text, out int number) || number <= 0)
            { ThongBao("Chỉ được nhập số nguyên dương."); txtSo.Focus(); return; }
            if (cboSo.Items.Contains(number)) { ThongBao("Số này đã có trong danh sách."); return; }
            cboSo.Items.Add(number);
            cboSo.SelectedItem = number;
            txtSo.Clear(); txtSo.Focus();
        }

        private void cboSo_SelectedIndexChanged(object? sender, EventArgs e)
        {
            lstUoc.Items.Clear();
            if (cboSo.SelectedItem is not int number) return;
            var factors = new List<int>();
            for (int i = 1; i <= number / i; i++)
            {
                if (number % i != 0) continue;
                factors.Add(i);
                if (i != number / i) factors.Add(number / i);
            }
            factors.Sort();
            foreach (int factor in factors) lstUoc.Items.Add(factor);
        }

        private void btnTong_Click(object? sender, EventArgs e)
        {
            long total = lstUoc.Items.Cast<int>().Sum(x => (long)x);
            ThongBao("Tổng các ước: " + total);
        }

        private void btnUocChan_Click(object? sender, EventArgs e)
        {
            int total = lstUoc.Items.Cast<int>().Count(x => x % 2 == 0);
            ThongBao("Số lượng ước chẵn: " + total);
        }

        private static bool IsPrime(int number)
        {
            if (number < 2) return false;
            for (int i = 2; i <= number / i; i++)
                if (number % i == 0) return false;
            return true;
        }

        private void btnUocNguyenTo_Click(object? sender, EventArgs e)
        {
            int total = lstUoc.Items.Cast<int>().Count(IsPrime);
            ThongBao("Số lượng ước nguyên tố: " + total);
        }

        private void btnThoat_Click(object? sender, EventArgs e) => Close();
        private void Form1_FormClosing(object? sender, FormClosingEventArgs e)
        {
            if (!XacNhan("Bạn muốn thoát?")) e.Cancel = true;
        }
    }
}
