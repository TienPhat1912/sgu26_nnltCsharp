using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace B02_ListView;

public partial class Form1 : Form
{
    public Form1()
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
        string id = txtMa.Text.Trim();
        string name = txtTen.Text.Trim();
        if (id.Length == 0 || name.Length == 0)
        { ThongBao("Nhập đầy đủ mã sinh viên và họ tên."); return; }
        bool duplicate = lvSinhVien.Items.Cast<ListViewItem>().Any(item =>
            string.Equals(item.Text, id, StringComparison.OrdinalIgnoreCase));
        if (duplicate) { ThongBao("Mã sinh viên đã tồn tại."); return; }
        lvSinhVien.Items.Add(new ListViewItem(new[] { id, name }));
        txtMa.Clear(); txtTen.Clear(); txtMa.Focus();
    }

    private void btnXoa_Click(object? sender, EventArgs e)
    {
        foreach (ListViewItem item in lvSinhVien.SelectedItems.Cast<ListViewItem>().ToArray())
            lvSinhVien.Items.Remove(item);
    }

    private void btnSua_Click(object? sender, EventArgs e)
    {
        if (lvSinhVien.SelectedItems.Count != 1)
        { ThongBao("Chọn một sinh viên để sửa."); return; }
        string id = txtMa.Text.Trim(), name = txtTen.Text.Trim();
        if (id.Length == 0 || name.Length == 0)
        { ThongBao("Thông tin không được để trống."); return; }
        ListViewItem item = lvSinhVien.SelectedItems[0];
        if (lvSinhVien.Items.Cast<ListViewItem>().Any(x => x != item &&
            string.Equals(x.Text, id, StringComparison.OrdinalIgnoreCase)))
        { ThongBao("Mã sinh viên đã tồn tại."); return; }
        item.Text = id;
        item.SubItems[1].Text = name;
    }

    private void lvSinhVien_SelectedIndexChanged(object? sender, EventArgs e)
    {
        if (lvSinhVien.SelectedItems.Count != 1) return;
        txtMa.Text = lvSinhVien.SelectedItems[0].Text;
        txtTen.Text = lvSinhVien.SelectedItems[0].SubItems[1].Text;
    }
}
