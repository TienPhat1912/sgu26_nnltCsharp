using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace B04_QuanLySinhVien;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        cboDanToc.Items.AddRange(new object[]
        { "Kinh", "Tày", "Thái", "Mường", "Khmer", "Hoa", "Nùng", "H'Mông", "Khác" });
        cboDanToc.SelectedIndex = 0;
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

    private string NgoaiNgu()
    {
        return string.Join(", ", new[]
        {
            chkAnh.Checked ? "Anh" : null,
            chkPhap.Checked ? "Pháp" : null,
            chkHoa.Checked ? "Hoa" : null
        }.Where(x => x != null));
    }

    private void XoaTrang()
    {
        txtTen.Clear(); txtMa.ReadOnly = false; txtMa.Clear();
        rdoNam.Checked = true;
        chkAnh.Checked = chkPhap.Checked = chkHoa.Checked = false;
        cboDanToc.SelectedIndex = 0;
        txtTen.Focus();
    }

    private void btnThem_Click(object? sender, EventArgs e)
    {
        string id = txtMa.Text.Trim(), name = txtTen.Text.Trim();
        if (id == "" || name == "") { ThongBao("Nhập đầy đủ họ tên và mã sinh viên."); return; }
        if (lvSinhVien.Items.Cast<ListViewItem>().Any(i =>
            string.Equals(i.SubItems[1].Text, id, StringComparison.OrdinalIgnoreCase)))
        { ThongBao("Mã sinh viên đã tồn tại."); return; }
        lvSinhVien.Items.Add(new ListViewItem(new[]
            { name, id, rdoNam.Checked ? "Nam" : "Nữ", NgoaiNgu(), cboDanToc.Text }));
        XoaTrang();
    }

    private void XoaSinhVien()
    {
        foreach (ListViewItem item in lvSinhVien.SelectedItems.Cast<ListViewItem>().ToArray())
            lvSinhVien.Items.Remove(item);
        XoaTrang();
    }

    private void btnXoa_Click(object? sender, EventArgs e) => XoaSinhVien();
    private void menuXoa_Click(object? sender, EventArgs e) => XoaSinhVien();

    private void btnSua_Click(object? sender, EventArgs e)
    {
        if (lvSinhVien.SelectedItems.Count != 1)
        { ThongBao("Hãy chọn một sinh viên."); return; }
        if (txtTen.Text.Trim() == "") { ThongBao("Họ tên không được để trống."); return; }
        ListViewItem item = lvSinhVien.SelectedItems[0];
        item.SubItems[0].Text = txtTen.Text.Trim();
        item.SubItems[2].Text = rdoNam.Checked ? "Nam" : "Nữ";
        item.SubItems[3].Text = NgoaiNgu();
        item.SubItems[4].Text = cboDanToc.Text;
    }

    private void lvSinhVien_SelectedIndexChanged(object? sender, EventArgs e)
    {
        if (lvSinhVien.SelectedItems.Count != 1) { txtMa.ReadOnly = false; return; }
        ListViewItem item = lvSinhVien.SelectedItems[0];
        txtTen.Text = item.SubItems[0].Text;
        txtMa.Text = item.SubItems[1].Text;
        txtMa.ReadOnly = true;
        rdoNam.Checked = item.SubItems[2].Text == "Nam";
        rdoNu.Checked = !rdoNam.Checked;
        string[] languages = item.SubItems[3].Text.Split(", ");
        chkAnh.Checked = languages.Contains("Anh");
        chkPhap.Checked = languages.Contains("Pháp");
        chkHoa.Checked = languages.Contains("Hoa");
        cboDanToc.SelectedItem = item.SubItems[4].Text;
    }

    private void Form1_FormClosing(object? sender, FormClosingEventArgs e)
    {
        if (!XacNhan("Bạn muốn đóng form?")) e.Cancel = true;
    }
}
