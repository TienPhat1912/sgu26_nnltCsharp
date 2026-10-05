namespace TH04d_Bai02_MangSoNguyen;

// Lớp lưu trữ và xử lý mảng một chiều số nguyên theo yêu cầu bài tập.
public class MangSoNguyen
{
    private readonly List<int> data = new();
    public IReadOnlyList<int> Data => data;

    public void SetData(IEnumerable<int> values) { data.Clear(); data.AddRange(values); }
    public void SortAscending() => data.Sort();
    public void SortDescending() => data.Sort((x, y) => y.CompareTo(x));
    public int FindValue(int value) => data.IndexOf(value);
    public int ValueAt(int index) => data[index];
    public void DeleteValue(int value) { if (!data.Remove(value)) throw new InvalidOperationException("Không tìm thấy giá trị cần xóa."); }
    public void DeleteAt(int index) { if (index < 0 || index >= data.Count) throw new ArgumentOutOfRangeException(nameof(index)); data.RemoveAt(index); }
    public void Insert(int index, int value) { if (index < 0 || index > data.Count) throw new ArgumentOutOfRangeException(nameof(index)); data.Insert(index, value); }
    public int Sum() => data.Sum();
    public int SumEven() => data.Where(x => x % 2 == 0).Sum();
    public int SumOdd() => data.Where(x => x % 2 != 0).Sum();
    public int Max() => data.Count == 0 ? throw new InvalidOperationException("Mảng rỗng.") : data.Max();
    public int Min() => data.Count == 0 ? throw new InvalidOperationException("Mảng rỗng.") : data.Min();
    public void ReplaceValue(int oldValue, int newValue) { int i=data.IndexOf(oldValue); if(i<0)throw new InvalidOperationException("Không tìm thấy giá trị cần thay thế."); data[i]=newValue; }
    public void ReplaceAt(int index, int newValue) { if(index<0||index>=data.Count)throw new ArgumentOutOfRangeException(nameof(index));data[index]=newValue; }
}
