
using Microsoft.VisualBasic;
using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Chuoifm
{
    public partial class Chuoifm : Form
    {
        private readonly Random random = new Random();

        private readonly CultureInfo vi =
            new CultureInfo("vi-VN");

        private readonly string[] HO =
        {
            "Lê", "Nguyễn", "Lý", "Trần", "Lâm",
            "Hồ", "Lai", "Huỳnh", "La"
        };

        private readonly string[] TENLOT =
        {
            "Quang", "Thành", "Ngọc", "Anh",
            "Xuân", "Bảo", "Cẩm", "Thị",
            "Kim", "Thái", "Hồng"
        };

        private readonly string[] TEN =
        {
            "Hà", "Danh", "Sơn", "Mai",
            "Thắng", "Kỳ", "Thành", "Lâm",
            "Tâm", "Phụng", "Thắm"
        };

        public Chuoifm()
        {
            InitializeComponent();
        }

        // =====================================
        // 1. THÊM 50 HỌ TÊN NGẪU NHIÊN
        // =====================================

        private void btnNgauNhien_Click(
            object sender, EventArgs e)
        {
            for (int i = 0; i < 50; i++)
            {
                string ho = HO[random.Next(HO.Length)];
                string tenLot = TENLOT[random.Next(TENLOT.Length)];
                string ten = TEN[random.Next(TEN.Length)];

                string hoTen = ho + " " + tenLot + " " + ten;

                lstHoTen.Items.Add(hoTen);
            }
        }

        // =====================================
        // 2. XÓA CÁC PHẦN TỬ ĐANG CHỌN
        // =====================================

        private void btnXoaChon_Click(
            object sender, EventArgs e)
        {
            if (lstHoTen.SelectedIndices.Count == 0)
            {
                MessageBox.Show(
                    "Vui lòng chọn phần tử cần xóa!");
                return;
            }

            int[] indices = lstHoTen.SelectedIndices
                .Cast<int>()
                .OrderByDescending(i => i)
                .ToArray();

            foreach (int index in indices)
            {
                lstHoTen.Items.RemoveAt(index);
            }
        }

        // =====================================
        // 3. XÓA PHẦN TỬ CÓ TÊN LÀ SƠN
        // =====================================

        private void btnXoaTenSon_Click(
            object sender, EventArgs e)
        {
            for (int i = lstHoTen.Items.Count - 1; i >= 0; i--)
            {
                string hoTen =
                    lstHoTen.Items[i]!.ToString()!;

                string[] words = hoTen.Split(
                    ' ',
                    StringSplitOptions.RemoveEmptyEntries);

                if (words.Length == 0)
                    continue;

                string ten = words[words.Length - 1];

                if (ten.Equals(
                    "Sơn",
                    StringComparison.OrdinalIgnoreCase))
                {
                    lstHoTen.Items.RemoveAt(i);
                }
            }
        }

        // =====================================
        // 4. XÓA PHẦN TỬ CÓ HỌ LÀ LÊ
        // =====================================

        private void btnXoaHoLe_Click(
            object sender, EventArgs e)
        {
            for (int i = lstHoTen.Items.Count - 1; i >= 0; i--)
            {
                string hoTen =
                    lstHoTen.Items[i]!.ToString()!;

                string[] words = hoTen.Split(
                    ' ',
                    StringSplitOptions.RemoveEmptyEntries);

                if (words.Length == 0)
                    continue;

                string ho = words[0];

                if (ho.Equals(
                    "Lê",
                    StringComparison.OrdinalIgnoreCase))
                {
                    lstHoTen.Items.RemoveAt(i);
                }
            }
        }

        // =====================================
        // 5. PHƯƠNG THỨC CHUYỂN ĐỔI CHỮ
        // =====================================

        private void ChuyenDangChu(
            Func<string, string> convert)
        {
            // Lưu chỉ số các phần tử đang chọn
            int[] selectedIndices =
                lstHoTen.SelectedIndices
                    .Cast<int>()
                    .ToArray();

            if (selectedIndices.Length == 0)
            {
                MessageBox.Show(
                    "Vui lòng chọn họ tên cần chuyển đổi!");
                return;
            }

            // Sao chép toàn bộ danh sách
            string[] danhSach = lstHoTen.Items
                .Cast<object>()
                .Select(item => item.ToString() ?? "")
                .ToArray();

            // Lưu vị trí cuộn
            int topIndex = lstHoTen.TopIndex;

            // Chuyển đổi các phần tử đã chọn
            foreach (int index in selectedIndices)
            {
                danhSach[index] = convert(danhSach[index]);
            }

            // Cập nhật lại toàn bộ ListBox
            lstHoTen.BeginUpdate();

            try
            {
                lstHoTen.Items.Clear();

                lstHoTen.Items.AddRange(danhSach);

                // Khôi phục những phần tử đang chọn
                foreach (int index in selectedIndices)
                {
                    lstHoTen.SetSelected(index, true);
                }

                // Khôi phục vị trí cuộn
                if (lstHoTen.Items.Count > 0)
                {
                    lstHoTen.TopIndex = Math.Min(
                        topIndex,
                        lstHoTen.Items.Count - 1);
                }
            }
            finally
            {
                lstHoTen.EndUpdate();
            }
        }

        // =====================================
        // 6. CHUYỂN THÀNH CHỮ HOA
        // =====================================

        private void btnChuHoa_Click(
            object sender, EventArgs e)
        {
            ChuyenDangChu(
                hoTen => hoTen.ToUpper(vi));
        }

        // =====================================
        // 7. CHUYỂN THÀNH CHỮ THƯỜNG
        // =====================================

        private void btnChuThuong_Click(
            object sender, EventArgs e)
        {
            ChuyenDangChu(
                hoTen => hoTen.ToLower(vi));
        }

        // =====================================
        // 8. VIẾT HOA ĐẦU MỖI TỪ
        // =====================================

        private void btnVietHoa_Click(
            object sender, EventArgs e)
        {
            ChuyenDangChu(hoTen =>
                vi.TextInfo.ToTitleCase(
                    hoTen.ToLower(vi)));
        }

        // =====================================
        // 9. XÓA TẤT CẢ PHẦN TỬ
        // =====================================

        private void btnXoaTatCa_Click(
            object sender, EventArgs e)
        {
            lstHoTen.Items.Clear();
        }

        // =====================================
        // 10. DOUBLE CLICK CHỈNH SỬA HỌ TÊN
        // =====================================

        private void lstHoTen_MouseDoubleClick(
            object sender, MouseEventArgs e)
        {
            int index = lstHoTen.IndexFromPoint(e.Location);

            if (index == ListBox.NoMatches)
                return;

            string hoTenCu =
                lstHoTen.Items[index]!.ToString()!;

            string hoTenMoi = Interaction.InputBox(
                "Nhập họ tên mới:",
                "Chỉnh sửa họ tên",
                hoTenCu
            );

            // Không cập nhật nếu để trống hoặc nhấn Cancel
            if (string.IsNullOrWhiteSpace(hoTenMoi))
                return;

            lstHoTen.Items[index] = hoTenMoi.Trim();

            lstHoTen.ClearSelected();
            lstHoTen.SetSelected(index, true);
        }
    }
}
