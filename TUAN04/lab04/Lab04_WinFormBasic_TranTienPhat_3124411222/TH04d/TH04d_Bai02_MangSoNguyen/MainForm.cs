namespace TH04d_Bai02_MangSoNguyen;

public partial class MainForm : Form
{
    private readonly MangSoNguyen array = new();

    public MainForm() { InitializeComponent(); }

    private static int[] ParseArray(string text) => text
        .Split(new[] { ' ', ',', ';' }, StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
        .ToArray();

    private bool EnsureArray()
    {
        if (array.Data.Count > 0) return true;
        MessageBox.Show("Hãy nhập mảng trước.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        return false;
    }

    private void RefreshArray() => txtResult.Text = string.Join(" ", array.Data);

    private void btnInput_Click(object? sender, EventArgs e)
    {
        try
        {
            int[] values = ParseArray(txtInput.Text);
            if (values.Length == 0) throw new FormatException();
            array.SetData(values);
            RefreshArray();
        }
        catch
        {
            MessageBox.Show("Nhập các số nguyên cách nhau bởi khoảng trắng, dấu phẩy hoặc dấu chấm phẩy.",
                "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    private void btnExecute_Click(object? sender, EventArgs e)
    {
        if (!EnsureArray()) return;

        try
        {
            bool didWork = false;

            // Nhóm sắp xếp.
            if (rdoSortAsc.Checked) { array.SortAscending(); didWork = true; }
            else if (rdoSortDesc.Checked) { array.SortDescending(); didWork = true; }

            // Nhóm tìm kiếm chỉ thực hiện khi người dùng đã nhập dữ liệu tìm.
            if (!string.IsNullOrWhiteSpace(txtFind.Text))
            {
                int key = int.Parse(txtFind.Text);
                if (rdoFindValue.Checked)
                {
                    int index = array.FindValue(key);
                    lblFindResult.Text = index >= 0 ? $"Vị trí tìm được: {index}" : "Không tìm thấy giá trị.";
                    didWork = true;
                }
                else if (rdoFindIndex.Checked)
                {
                    lblFindResult.Text = $"Số tìm được: {array.ValueAt(key)}";
                    didWork = true;
                }
            }

            // Nhóm xóa.
            if (!string.IsNullOrWhiteSpace(txtDelete.Text))
            {
                int key = int.Parse(txtDelete.Text);
                if (rdoDeleteValue.Checked) { array.DeleteValue(key); didWork = true; }
                else if (rdoDeleteIndex.Checked) { array.DeleteAt(key); didWork = true; }
            }

            // Nhóm thêm.
            if (rdoAdd.Checked && !string.IsNullOrWhiteSpace(txtAddValue.Text) && !string.IsNullOrWhiteSpace(txtAddIndex.Text))
            {
                array.Insert(int.Parse(txtAddIndex.Text), int.Parse(txtAddValue.Text));
                didWork = true;
            }

            // Nhóm thay thế.
            if (!string.IsNullOrWhiteSpace(txtReplaceTarget.Text) && !string.IsNullOrWhiteSpace(txtReplaceNew.Text))
            {
                int target = int.Parse(txtReplaceTarget.Text);
                int replacement = int.Parse(txtReplaceNew.Text);
                if (rdoReplaceValue.Checked) { array.ReplaceValue(target, replacement); didWork = true; }
                else if (rdoReplaceIndex.Checked) { array.ReplaceAt(target, replacement); didWork = true; }
            }

            if (!didWork)
            {
                MessageBox.Show("Hãy chọn chức năng và nhập dữ liệu cần thiết.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            RefreshArray();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Không thể thực hiện: " + ex.Message, "Lỗi",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    private void btnSum_Click(object? sender, EventArgs e)
    {
        if (!EnsureArray()) return;
        txtSum.Text = array.Sum().ToString();
        txtEven.Text = array.SumEven().ToString();
        txtOdd.Text = array.SumOdd().ToString();
    }

    private void btnMinMax_Click(object? sender, EventArgs e)
    {
        if (!EnsureArray()) return;
        txtMax.Text = array.Max().ToString();
        txtMin.Text = array.Min().ToString();
    }

    private static void ClearTextBoxes(Control parent)
    {
        foreach (Control control in parent.Controls)
        {
            if (control is TextBox textBox) textBox.Clear();
            if (control.HasChildren) ClearTextBoxes(control);
        }
    }

    private void btnReset_Click(object? sender, EventArgs e)
    {
        array.SetData(Array.Empty<int>());
        ClearTextBoxes(this);
        lblFindResult.Text = "";
        rdoSortAsc.Checked = false; rdoSortDesc.Checked = false;
        rdoFindValue.Checked = false; rdoFindIndex.Checked = false;
        rdoDeleteValue.Checked = false; rdoDeleteIndex.Checked = false;
        rdoAdd.Checked = false;
        rdoReplaceValue.Checked = false; rdoReplaceIndex.Checked = false;
        txtInput.Focus();
    }

    private void btnExit_Click(object? sender, EventArgs e) => Close();

    private void MainForm_FormClosing(object? sender, FormClosingEventArgs e)
    {
        if (MessageBox.Show("Bạn có chắc muốn thoát?", "Xác nhận",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            e.Cancel = true;
    }
}
