using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace B07_DemNguoc;

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

    private const int ThoiGianBanDau = 30 * 60;
    private int soGiayConLai = ThoiGianBanDau;

    private void HienThi()
    {
        lblThoiGian.Text = $"{soGiayConLai / 60:00}:{soGiayConLai % 60:00}";
    }

    private void btnBatDau_Click(object? sender, EventArgs e)
    {
        if (timerDemNguoc.Enabled)
        {
            timerDemNguoc.Stop();
            btnBatDau.Text = "Tiếp tục";
        }
        else
        {
            if (soGiayConLai == 0) soGiayConLai = ThoiGianBanDau;
            timerDemNguoc.Start();
            btnBatDau.Text = "Tạm dừng";
        }
        HienThi();
    }

    private void timerDemNguoc_Tick(object? sender, EventArgs e)
    {
        if (soGiayConLai > 0) soGiayConLai--;
        HienThi();
        if (soGiayConLai > 0) return;
        timerDemNguoc.Stop();
        btnBatDau.Text = "Bắt đầu lại";
        ThongBao("Đã hết thời gian!");
    }
}
