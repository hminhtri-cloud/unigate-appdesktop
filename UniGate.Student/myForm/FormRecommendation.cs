using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Windows.Forms;
using UniGate.Shared.DTOs;

namespace UniGate.Student.myForm;

public partial class FormRecommendation : Form
{
    private readonly HttpClient _http = new() { BaseAddress = new Uri("https://localhost:7030/") };

    public FormRecommendation()
    {
        InitializeComponent();
        // Đăng ký sự kiện
        tabControl1.SelectedIndexChanged += TabControl1_SelectedIndexChanged;
    }

    private async void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
    {
        // Gán Token bảo mật một lần ở đây
        if (!string.IsNullOrEmpty(UserSession.Token))
            _http.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", UserSession.Token);

        try
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0: await LoadByScore(); break;
                case 1: await LoadByTargets(); break;
                case 2: await LoadByHolland(); break;
                case 3: await LoadBestFit(); break;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi kết nối Server: " + ex.Message);
        }
    }

    // --- LOGIC TỪNG TÍNH NĂNG ---

    private async Task LoadByScore()
    {
        // 1. Kiểm tra xem User đã có điểm trong hệ thống chưa (ví dụ lưu trong UserSession)

        // 2. Nếu chưa có điểm, gọi API lấy danh sách ngành "Xu hướng" 
        // Hoặc load với một mức điểm mặc định (ví dụ 20 điểm)
        var res = await _http.GetFromJsonAsync<List<MajorRecommendationDto>>("api/Recommendation/by-score?margin=20");
        dgvScore.DataSource = res;
        ApplyColorCoding(dgvScore);

        // Hiện thông báo nhẹ cho user biết
        lblStatus.Text = "Đang hiển thị các ngành quanh mức 20 điểm. Hãy nhập điểm của m để xem gợi ý chính xác nhé!";

    }

    // Sự kiện Click nút lọc (M nhớ đặt tên nút trên giao diện là btnFilter)
    private async void btnFilter_Click(object sender, EventArgs e)
    {
        decimal margin = numMargin.Value;
        var url = $"api/Recommendation/by-score?margin={margin}";

        var res = await _http.GetAsync(url);
        if (res.IsSuccessStatusCode)
        {
            var data = await res.Content.ReadFromJsonAsync<List<MajorRecommendationDto>>();
            dgvScore.DataSource = data;
            ApplyColorCoding(dgvScore); // Gọi hàm tô màu tối ưu
        }
    }

    private async Task LoadByTargets()
    {
        var res = await _http.GetFromJsonAsync<List<MajorRecommendationDto>>("api/Recommendation/by-targets");
        dgvTargets.DataSource = res;
        ApplyColorCoding(dgvTargets);
    }

    private async Task LoadByHolland()
    {
        var res = await _http.GetFromJsonAsync<List<MajorRecommendationDto>>("api/Recommendation/by-holland");
        dgvHolland.DataSource = res;
        ApplyColorCoding(dgvHolland);
    }

    private async Task LoadBestFit()
    {
        var res = await _http.GetFromJsonAsync<List<MajorRecommendationDto>>("api/Recommendation/best-fit");
        dgvBestFit.DataSource = res;

        if (res == null || res.Count == 0)
            MessageBox.Show("Chưa tìm thấy ngành nào thỏa mãn cả 3 tiêu chí của m!");
        else
            ApplyColorCoding(dgvBestFit);
    }

    // --- HÀM TÔ MÀU DÙNG CHUNG (TỐI ƯU) ---
    private void ApplyColorCoding(DataGridView dgv)
    {
        if (dgv.DataSource == null) return;

        foreach (DataGridViewRow row in dgv.Rows)
        {
            // Kiểm tra cột Status có tồn tại không để tránh crash
            if (row.Cells["Status"].Value != null)
            {
                string status = row.Cells["Status"].Value.ToString();

                if (status.Contains("An toàn"))
                    row.DefaultCellStyle.BackColor = Color.LightGreen;
                else if (status.Contains("Mạo hiểm"))
                    row.DefaultCellStyle.BackColor = Color.LightSalmon;
                else if (status.Contains("Rất khó"))
                    row.DefaultCellStyle.BackColor = Color.MistyRose;
            }
        }
    }

}