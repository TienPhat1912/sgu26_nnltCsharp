namespace dantocfm
{
    public partial class ComboBoxfm : Form
    {
        public ComboBoxfm()
        {
            InitializeComponent();
        }


        private void btnLoad_Click(object sender, EventArgs e)
        {
            string[] dt = { "Kinh", "Tày", "Thái", "Hoa", "Khơ me" };
            foreach (string i in dt)
            {
                cbo_dt.Items.Add(i);
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            string s = "Dân tộc được chọn: ";
            if (cbo_dt.SelectedIndex >= 0)
                lbKQ.Text = s + cbo_dt.SelectedItem.ToString();
            else
                lbKQ.Text = "Bạn chưa chọn dân tộc";
        }

        private void cbo_dt_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Dân tộc được chọn:" + cbo_dt.SelectedItem.ToString());
        }
    }
}
