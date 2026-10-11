using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace B05_QuanLyTaiKhoan;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        SetEditable(false);
        btnLuu.Enabled = false;
        btnXoa.Enabled = false;
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

    private bool dangThem;

    private void SetEditable(bool editable)
    {
        foreach (TextBox box in new[] { txtSoTaiKhoan, txtKhachHang, txtDiaChi, txtSoTien })
            box.ReadOnly = !editable;
    }

    private void XoaTrang()
    {
        txtSoTaiKhoan.Clear(); txtKhachHang.Clear(); txtDiaChi.Clear(); txtSoTien.Clear();
    }

    private void HienThiDongChon()
    {
        if (lvTaiKhoan.SelectedItems.Count != 1) return;
        ListViewItem item = lvTaiKhoan.SelectedItems[0];
        txtSoTaiKhoan.Text = item.SubItems[1].Text;
        txtKhachHang.Text = item.SubItems[2].Text;
        txtDiaChi.Text = item.SubItems[3].Text;
        txtSoTien.Text = item.SubItems[4].Text;
    }

    private void TinhTong()
    {
        decimal total = 0;
        int index = 0;
        foreach (ListViewItem item in lvTaiKhoan.Items)
        {
            item.Text = (++index).ToString();
            if (decimal.TryParse(item.SubItems[4].Text, NumberStyles.Number,
                CultureInfo.CurrentCulture, out decimal amount)) total += amount;
        }
        txtTong.Text = total.ToString("N0");
        btnXoa.Enabled = !dangThem && lvTaiKhoan.SelectedItems.Count > 0;
    }

    private void btnThem_Click(object? sender, EventArgs e)
    {
        dangThem = !dangThem;
        btnThem.Text = dangThem ? "Hủy" : "Thêm";
        btnLuu.Enabled = dangThem;
        SetEditable(dangThem);
        if (dangThem)
        {
            XoaTrang();
            foreach (ListViewItem item in lvTaiKhoan.SelectedItems.Cast<ListViewItem>().ToArray())
                item.Selected = false;
            txtSoTaiKhoan.Focus();
        }
        else HienThiDongChon();
        btnXoa.Enabled = !dangThem && lvTaiKhoan.SelectedItems.Count > 0;
    }

    private void btnLuu_Click(object? sender, EventArgs e)
    {
        if (!dangThem) return;
        string id = txtSoTaiKhoan.Text.Trim();
        string name = txtKhachHang.Text.Trim();
        string addr = txtDiaChi.Text.Trim();
        if (id == "" || name == "" || addr == "" || txtSoTien.Text.Trim() == "")
        { ThongBao("Hãy nhập đầy đủ thông tin tài khoản."); return; }
        if (lvTaiKhoan.Items.Cast<ListViewItem>().Any(item =>
            string.Equals(item.SubItems[1].Text, id, StringComparison.OrdinalIgnoreCase)))
        { ThongBao("Số tài khoản đã tồn tại."); return; }
        bool ok = decimal.TryParse(txtSoTien.Text, NumberStyles.Number,
            CultureInfo.CurrentCulture, out decimal amount);
        if (!ok) ok = decimal.TryParse(txtSoTien.Text, NumberStyles.Number,
            CultureInfo.InvariantCulture, out amount);
        if (!ok || amount < 0) { ThongBao("Số tiền phải là số không âm."); return; }
        lvTaiKhoan.Items.Add(new ListViewItem(new[]
            { "", id, name, addr, amount.ToString("N0") }));
        dangThem = false;
        btnThem.Text = "Thêm";
        btnLuu.Enabled = false;
        SetEditable(false);
        XoaTrang();
        TinhTong();
    }

    private void btnXoa_Click(object? sender, EventArgs e)
    {
        foreach (ListViewItem item in lvTaiKhoan.SelectedItems.Cast<ListViewItem>().ToArray())
            lvTaiKhoan.Items.Remove(item);
        XoaTrang();
        TinhTong();
    }

    private void lvTaiKhoan_SelectedIndexChanged(object? sender, EventArgs e)
    {
        btnXoa.Enabled = !dangThem && lvTaiKhoan.SelectedItems.Count > 0;
        if (!dangThem) HienThiDongChon();
    }

    private void btnThoat_Click(object? sender, EventArgs e) => Close();
}
