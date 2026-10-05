using System.Net.Http.Headers;
using System.Net.Http.Json;
using UniGate.Shared.DTOs;

namespace UniGate.Student.myForm;

public partial class FormCompareMajor : Form
{
    private readonly HttpClient _http = new() { BaseAddress = new Uri("https://localhost:7030/") };

    // Sửa: Dùng MajorDetailDto thay vì FavoriteMajorDto
    private List<MajorDetailDto> _allMajors = new();

    public FormCompareMajor()
    {
        InitializeComponent();
        this.Load += FormCompareMajor_Load;
        SetupGrid(); // Hàm tạo cột cho bảng
    }

    private void SetupGrid()
    {
        dgvCompare.Columns.Clear();
        dgvCompare.Columns.Add("Criteria", "Tiêu chí");
        dgvCompare.Columns.Add("Major1", "Ngành 1");
        dgvCompare.Columns.Add("Major2", "Ngành 2");
        dgvCompare.Columns.Add("Major3", "Ngành 3");

        // Cột tiêu chí rộng hơn xíu
        dgvCompare.Columns[0].Width = 150;
    }

    private async void FormCompareMajor_Load(object? sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(UserSession.Token)) return;
        _http.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", UserSession.Token);

        try
        {
            // Gọi API mới: all-details
            var res = await _http.GetAsync("api/Majors/all-details");
            if (res.IsSuccessStatusCode)
            {
                _allMajors = await res.Content.ReadFromJsonAsync<List<MajorDetailDto>>() ?? new List<MajorDetailDto>();

                // Load vào ComboBox (Lưu ID ẩn để tìm cho chính xác)
                // Mẹo: Dùng DisplayMember và ValueMember nếu muốn xịn, còn đây t làm cách đơn giản cho m:
                foreach (var m in _allMajors)
                {
                    string item = $"{m.Id} - {m.UniversityName} - {m.MajorName}";
                    cbMajor1.Items.Add(item);
                    cbMajor2.Items.Add(item);
                    cbMajor3.Items.Add(item);
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi tải danh sách: " + ex.Message);
        }
    }

    private void btnCompare_Click(object sender, EventArgs e)
    {
        dgvCompare.Rows.Clear();

        // 1. Lấy 3 ngành được chọn dựa trên ID ở đầu chuỗi
        var listSelected = new List<MajorDetailDto?>();
        listSelected.Add(GetSelectedMajor(cbMajor1.Text));
        listSelected.Add(GetSelectedMajor(cbMajor2.Text));
        listSelected.Add(GetSelectedMajor(cbMajor3.Text));

        // 2. Thêm từng dòng tiêu chí vào bảng so sánh dọc
        AddCompareRow("Tên Trường", listSelected, m => m.UniversityName);
        AddCompareRow("Tên Ngành", listSelected, m => m.MajorName);
        AddCompareRow("Tổ hợp môn", listSelected, m => m.GroupCode);
        AddCompareRow("Điểm Chuẩn", listSelected, m => m.CutoffScore.ToString("0.##"));
        AddCompareRow("Học Phí", listSelected, m => m.Tuition.ToString("N0") + " VNĐ");
        AddCompareRow("Holland", listSelected, m => m.HollandCode);
        AddCompareRow("Mô tả", listSelected, m => m.Description);
    }

    // Hàm phụ để tìm ngành dựa trên text trong ComboBox (ID - Name)
    private MajorDetailDto? GetSelectedMajor(string text)
    {
        if (string.IsNullOrEmpty(text)) return null;
        try
        {
            // Tách lấy ID ở đầu chuỗi (VD: "15 - Hutech - CNTT")
            int id = int.Parse(text.Split(" - ")[0]);
            return _allMajors.FirstOrDefault(m => m.Id == id);
        }
        catch { return null; }
    }

    // Hàm phụ để thêm dòng vào Grid cho gọn code
    private void AddCompareRow(string title, List<MajorDetailDto?> majors, Func<MajorDetailDto, string> selector)
    {
        string val1 = majors[0] != null ? selector(majors[0]!) : "---";
        string val2 = majors[1] != null ? selector(majors[1]!) : "---";
        string val3 = majors[2] != null ? selector(majors[2]!) : "---";

        dgvCompare.Rows.Add(title, val1, val2, val3);
    }
}