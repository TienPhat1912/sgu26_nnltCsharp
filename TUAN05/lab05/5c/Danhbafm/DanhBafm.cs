using System.Globalization;
using System.Text;

namespace DanhBafm
{
    public partial class DanhBafm : Form
    {
        public DanhBafm()
        {
            InitializeComponent();
            for (char letter = 'A'; letter <= 'Z'; letter++)
                treeDanhBa.Nodes.Add(letter.ToString(), letter.ToString());
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

        private static char LayChuCaiDauCuaTen(string fullName)
        {
            string name = fullName.Trim().Split(' ', StringSplitOptions.RemoveEmptyEntries).Last();
            string decomposed = name.Normalize(NormalizationForm.FormD);
            var result = new StringBuilder();
            foreach (char c in decomposed)
            {
                if (CharUnicodeInfo.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark)
                    result.Append(c);
            }
            string normalized = result.ToString().Normalize(NormalizationForm.FormC)
                .Replace('đ', 'd').Replace('Đ', 'D').ToUpperInvariant();
            return normalized[0];
        }

        private void btnThem_Click(object? sender, EventArgs e)
        {
            string name = txtHoTen.Text.Trim();
            if (name.Length == 0) { ThongBao("Hãy nhập họ tên."); txtHoTen.Focus(); return; }
            char letter = LayChuCaiDauCuaTen(name);
            if (letter < 'A' || letter > 'Z') { ThongBao("Tên không hợp lệ."); return; }
            TreeNode? group = treeDanhBa.Nodes[letter.ToString()];
            if (group is null) return;
            group.Nodes.Add(name);
            group.Expand();
            txtHoTen.Clear();
            txtHoTen.Focus();
        }
    }
}
