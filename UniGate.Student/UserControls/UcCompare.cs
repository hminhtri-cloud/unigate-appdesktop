using Guna.UI2.WinForms;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using UniGate.Shared.DTOs;
using static UniGate.Student.Program;

namespace UniGate.Student.UserControls
{
    public partial class UcCompare : UserControl
    {

        private readonly HttpClient _http = GlobalConfig.GetClient();
        // Danh sách chứa tất cả các ngành (để tìm kiếm)

        private List<MajorDetailDto> _allMajors = new();

        public UcCompare()
        {
            InitializeComponent();

            this.Load += UcCompare_Load;
            this.btnCompare.Click += BtnCompare_Click;
        }

        private async void UcCompare_Load(object? sender, EventArgs e)
        {
            await LoadAllMajors();
        }

        private async Task LoadAllMajors()
        {
            if (string.IsNullOrEmpty(UserSession.Token)) return;

            try
            {
                _http.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", UserSession.Token);

                // Gọi API lấy toàn bộ chi tiết ngành (ID, Tên, Trường, Học phí, Holland...)
                // Đảm bảo m đã viết API này: [HttpGet("all-details")] trong MajorsController
                var res = await _http.GetAsync("api/Majors/all-details");

                if (res.IsSuccessStatusCode)
                {
                    _allMajors = await res.Content.ReadFromJsonAsync<List<MajorDetailDto>>() ?? new List<MajorDetailDto>();

                    // Đổ dữ liệu vào 3 ComboBox
                    // Format: "ID - Tên Trường - Tên Ngành"
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
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }
        }

        private void BtnCompare_Click(object? sender, EventArgs e)
        {
            // Xóa dữ liệu cũ
            dgvCompare.Rows.Clear();

            // 1. Lấy ra 3 object MajorDetailDto từ 3 cái ComboBox
            var listSelected = new List<MajorDetailDto?>();
            listSelected.Add(GetSelectedMajor(cbMajor1.Text));
            listSelected.Add(GetSelectedMajor(cbMajor2.Text));
            listSelected.Add(GetSelectedMajor(cbMajor3.Text));

            // Kiểm tra xem có chọn cái nào không
            if (listSelected.All(x => x == null))
            {
                MessageBox.Show("Vui lòng chọn ít nhất 1 ngành để so sánh!");
                return;
            }

            // 2. Thêm từng dòng tiêu chí vào bảng
            // Cột 1: Tiêu chí | Cột 2: Ngành 1 | Cột 3: Ngành 2 | Cột 4: Ngành 3
            AddCompareRow("Tên Trường", listSelected, m => m.UniversityName);
            AddCompareRow("Tên Ngành", listSelected, m => m.MajorName);
            AddCompareRow("Mã Tổ hợp", listSelected, m => m.GroupCode);
            AddCompareRow("Điểm Chuẩn", listSelected, m => m.CutoffScore.ToString("0.##"));
            AddCompareRow("Học Phí (năm)", listSelected, m => m.Tuition.ToString("N0") + " VNĐ");
            AddCompareRow("Nhóm Holland", listSelected, m => m.HollandCode);

            // Dòng Mô tả này dài, Grid sẽ tự động wrap text xuống dòng
            AddCompareRow("Mô tả / Ghi chú", listSelected, m => m.Description);
        }

        // Hàm phân tích chuỗi "15 - Hutech - CNTT" để lấy ra ID = 15
        private MajorDetailDto? GetSelectedMajor(string text)
        {
            if (string.IsNullOrEmpty(text)) return null;
            try
            {
                // Tách chuỗi bằng dấu " - "
                string[] parts = text.Split(new string[] { " - " }, StringSplitOptions.RemoveEmptyEntries);
                if (parts.Length > 0)
                {
                    int id = int.Parse(parts[0]); // Lấy phần tử đầu tiên làm ID
                    return _allMajors.FirstOrDefault(m => m.Id == id);
                }
                return null;
            }
            catch { return null; }
        }

        // Hàm thêm dòng vào bảng (giúp code gọn hơn)
        private void AddCompareRow(string title, List<MajorDetailDto?> majors, Func<MajorDetailDto, string> selector)
        {
            // Nếu ngành đó null (chưa chọn) thì hiện "---"
            string val1 = majors[0] != null ? selector(majors[0]!) : "---";
            string val2 = majors[1] != null ? selector(majors[1]!) : "---";
            string val3 = majors[2] != null ? selector(majors[2]!) : "---";

            dgvCompare.Rows.Add(title, val1, val2, val3);
        }
    }
}