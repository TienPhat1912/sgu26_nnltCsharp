using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace B01_DongHo;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        HienThiGio();
        timerDongHo.Start();
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

    private void HienThiGio()
    {
        lblDongHo.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
    }

    private void timerDongHo_Tick(object? sender, EventArgs e)
    {
        HienThiGio();
    }
}
