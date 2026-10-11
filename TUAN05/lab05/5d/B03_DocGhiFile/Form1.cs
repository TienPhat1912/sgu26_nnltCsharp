using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace B03_DocGhiFile;

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

    private void btnMo_Click(object? sender, EventArgs e)
    {
        using var dialog = new OpenFileDialog
        {
            Filter = "Văn bản (*.txt)|*.txt",
            Title = "Mở tệp văn bản"
        };
        if (dialog.ShowDialog() != DialogResult.OK) return;
        try
        {
            rtbNoiDung.Text = File.ReadAllText(dialog.FileName);
            txtDuongDan.Text = dialog.FileName;
        }
        catch (Exception ex)
        {
            ThongBao("Không đọc được tệp: " + ex.Message);
        }
    }

    private void btnLuu_Click(object? sender, EventArgs e)
    {
        using var dialog = new SaveFileDialog
        {
            Filter = "Văn bản (*.txt)|*.txt",
            DefaultExt = "txt",
            AddExtension = true,
            Title = "Lưu tệp văn bản"
        };
        if (dialog.ShowDialog() != DialogResult.OK) return;
        try
        {
            File.WriteAllText(dialog.FileName, rtbNoiDung.Text);
            txtDuongDan.Text = dialog.FileName;
            ThongBao("Đã lưu tệp thành công.");
        }
        catch (Exception ex)
        {
            ThongBao("Không lưu được tệp: " + ex.Message);
        }
    }
}
