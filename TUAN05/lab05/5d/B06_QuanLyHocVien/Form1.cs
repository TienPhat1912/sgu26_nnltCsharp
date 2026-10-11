using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace B06_QuanLyHocVien;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        lstLopA.Items.AddRange(new object[] { "Trần Hùng", "Nguyễn Hưng", "Lâm Tử" });
        lstLopB.Items.AddRange(new object[] { "Tuấn Hưng", "Hồng Ngọc", "Anh Minh", "Bảo Lâm" });
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

    private static void Chuyen(ListBox source, ListBox target)
    {
        if (source.SelectedItems.Count == 0)
        { ThongBao("Hãy chọn học viên trước khi chuyển."); return; }
        foreach (object item in source.SelectedItems.Cast<object>().ToArray())
        {
            target.Items.Add(item);
            source.Items.Remove(item);
        }
    }

    private void menuNhap_Click(object? sender, EventArgs e)
    {
        using var dialog = new FrmNhapHocVien();
        if (dialog.ShowDialog(this) != DialogResult.OK) return;
        (dialog.LopDuocChon == "Lớp A" ? lstLopA : lstLopB)
            .Items.Add(dialog.HoTenHocVien);
    }

    private void menuSangA_Click(object? sender, EventArgs e) => Chuyen(lstLopB, lstLopA);
    private void menuSangB_Click(object? sender, EventArgs e) => Chuyen(lstLopA, lstLopB);

    private void menuXoa_Click(object? sender, EventArgs e)
    {
        if (lstLopA.SelectedItems.Count + lstLopB.SelectedItems.Count == 0)
        { ThongBao("Hãy chọn học viên cần xóa."); return; }
        foreach (ListBox list in new[] { lstLopA, lstLopB })
            foreach (object item in list.SelectedItems.Cast<object>().ToArray())
                list.Items.Remove(item);
    }

    private void menuKetThuc_Click(object? sender, EventArgs e) => Close();
    private void Form1_FormClosing(object? sender, FormClosingEventArgs e)
    {
        if (!XacNhan("Bạn có muốn kết thúc chương trình?")) e.Cancel = true;
    }
}
