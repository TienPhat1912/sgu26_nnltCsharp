using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace E_order_application_proj
{
    public partial class E_order : Form
    {
        private DataTable tb = new DataTable();
        public E_order()
        {
            InitializeComponent();
            tb.Columns.Add("FoodName", typeof(string));
            tb.Columns.Add("Quantity", typeof(int));

            dgvOrder.DataSource = tb;

            dgvOrder.Columns["FoodName"].HeaderText = "Món ăn";
            dgvOrder.Columns["Quantity"].HeaderText = "Số lượng";

            cboBan.Items.Add("Bàn 1");
            cboBan.Items.Add("Bàn 2");
            cboBan.Items.Add("Bàn 3");
            cboBan.Items.Add("Bàn 4");
            cboBan.Items.Add("Bàn 5");
            cboBan.Items.Add("Bàn 6");
            cboBan.Items.Add("Bàn 7");
            cboBan.Items.Add("Bàn 8");
            cboBan.Items.Add("Bàn 9");
            cboBan.Items.Add("Bàn 10");
        }

        private void FoodButton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            string foodName = btn.Text;

            foreach (DataRow row in tb.Rows)
            {
                if (row["FoodName"].ToString() == foodName)
                {
                    row["Quantity"] = Convert.ToInt32(row["Quantity"]) + 1;
                    return;
                }
            }

            DataRow newRow = tb.NewRow();

            newRow["FoodName"] = foodName;
            newRow["Quantity"] = 1;

            tb.Rows.Add(newRow);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvOrder.CurrentRow != null)
            {
                int index = dgvOrder.CurrentRow.Index;

                if (index >= 0 && index < tb.Rows.Count)
                {
                    tb.Rows.RemoveAt(index);
                }
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (cboBan.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Vui lòng chọn bàn!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            if (tb.Rows.Count == 0)
            {
                MessageBox.Show(
                    "Chưa có món ăn nào được chọn!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            MessageBox.Show(
                $"Order của {cboBan.Text} đã được gửi xuống bếp!",
                "Order thành công",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            tb.Clear();
            cboBan.SelectedIndex = -1;
        }
    }
}
