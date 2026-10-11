namespace Listboxfm
{
    public partial class fmListBox : Form
    {
        public fmListBox()
        {
            InitializeComponent();
        }
        private void btnQuaPhai_Click(object sender, EventArgs e)
        {
            if (lst_trai.SelectedItem == null)
                return;
            // Chuyển giá trị chọn bên trái sang phải
            lst_phai.Items.Add(lst_trai.SelectedItem);
            // Xóa giá trị chọn bên trái
            lst_trai.Items.Remove(lst_trai.SelectedItem);
        }

        private void btnQuaPhaiAll_Click(object sender, EventArgs e)
        {
            if (lst_trai.Items.Count == 0)
                return;

            lst_phai.Items.AddRange(lst_trai.Items);
            // Xóa giá trị bên trái
            lst_trai.Items.Clear();
        }

        private void btnQuaTrai_Click(object sender, EventArgs e)
        {
            if (lst_phai.SelectedItem == null)
                return;
           
            lst_trai.Items.Add(lst_phai.SelectedItem);
      
            lst_phai.Items.Remove(lst_phai.SelectedItem);
        }

        private void btnQuaTraiAll_Click(object sender, EventArgs e)
        {
            if (lst_phai.Items.Count == 0)
                return;
            
            lst_trai.Items.AddRange(lst_phai.Items);
           
            lst_phai.Items.Clear();
        }

        private void btnchuyen_Click(object sender, EventArgs e)
        {
            for (int i = lst_trai.Items.Count - 1; i >= 0; i--)
            {
                if (lst_trai.GetSelected(i))
                {
                    object item = lst_trai.Items[i];

                    lst_phai.Items.Add(item);
                    lst_trai.Items.RemoveAt(i);
                }
            }
        }

        private void fmListBox_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show(
        "Bạn có chắc chắn muốn thoát?",
        "Xác nhận",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question
    );

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
