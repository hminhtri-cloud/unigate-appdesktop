using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Threading.Tasks;
using UniGate.Shared.DTOs;

namespace UniGate.Student.myForm;

public partial class FormKetQuaToHop : Form
{
    private readonly HttpClient _http = new() { BaseAddress = new Uri("https://localhost:7030/") };

    public FormKetQuaToHop()
    {
        InitializeComponent();
        this.Load += async (s, e) => await LoadCombinationsAsync();
    }

    private async Task LoadCombinationsAsync()
    {
        lblStatus.Text = "Đang kết nối Server máy Mac để tính điểm...";

        try
        {
            // 1. Gắn Token bảo mật (Mục 8)
            if (!string.IsNullOrEmpty(UserSession.Token))
            {
                _http.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", UserSession.Token);
            }

            // 2. Gọi API tính toán tổ hợp mà mình vừa viết ở Server
            var response = await _http.GetAsync("api/UserScores/my-combinations");

            if (response.IsSuccessStatusCode)
            {
                var data = await response.Content.ReadFromJsonAsync<List<CombinationScoreDto>>();

                // 3. Hiển thị lên lưới (Mục 2: Xử lý dữ liệu)
                dgvCombinations.DataSource = data;

                if (data == null || data.Count == 0)
                    lblStatus.Text = "Anh chưa nhập đủ môn để cấu thành tổ hợp nào cả!";
                else
                    lblStatus.Text = $"Đã tìm thấy {data.Count} tổ hợp anh có thể xét tuyển.";
            }
            else
            {
                lblStatus.Text = "Lỗi: " + await response.Content.ReadAsStringAsync();
            }
        }
        catch (Exception ex)
        {
            lblStatus.Text = "Không thể kết nối Load Balancer: " + ex.Message;
        }
    }

    private async void btnRefresh_Click(object sender, EventArgs e)
    {
        await LoadCombinationsAsync();
    }
    private async void btnSaveTargets_Click(object sender, EventArgs e)
    {
        var selectedGroups = new List<string>();

        // Duyệt qua từng dòng trong Grid để xem dòng nào được tích chọn
        foreach (DataGridViewRow row in dgvCombinations.Rows)
        {
            bool isSelected = Convert.ToBoolean(row.Cells["colSelect"].Value);
            if (isSelected)
            {
                var groupCode = row.Cells["GroupCode"].Value.ToString();
                selectedGroups.Add(groupCode);
            }
        }

        if (selectedGroups.Count == 0)
        {
            MessageBox.Show("M phải chọn ít nhất một tổ hợp để lưu chứ!");
            return;
        }

        // Gửi danh sách lên Server
        var req = new SaveTargetsRequest { SelectedGroups = selectedGroups };
        var res = await _http.PostAsJsonAsync("api/UserScores/save-targets", req);

        if (res.IsSuccessStatusCode)
        {
            MessageBox.Show("Đã lưu mục tiêu vào MySQL trên Mac thành công. Sau này cứ thế mà dùng thôi!", "Ngon lành");
        }
    }
}