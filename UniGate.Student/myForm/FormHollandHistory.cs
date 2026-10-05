using System.Net.Http.Headers;
using System.Net.Http.Json;
using UniGate.Shared.DTOs;

namespace UniGate.Student.myForm;

public partial class FormHollandHistory : Form
{
    private readonly HttpClient _http = new() { BaseAddress = new Uri("https://localhost:7030/") };

    public FormHollandHistory()
    {
        InitializeComponent();
        this.Load += async (s, e) => await LoadHistoryAsync();
    }

    private async Task LoadHistoryAsync()
    {
        // Gắn Token bảo mật từ Session
        if (UserSession.IsLoggedIn)
        {
            _http.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", UserSession.Token);
        }

        try
        {
            var data = await _http.GetFromJsonAsync<List<HollandHistoryDto>>("api/Holland/history");
            dgvHistory.DataSource = data;
        }
        catch (Exception)
        {
            MessageBox.Show("Lỗi kết nối dữ liệu lịch sử!");
        }
    }

    private void btnDetail_Click(object sender, EventArgs e)
    {
        if (dgvHistory.CurrentRow?.DataBoundItem is HollandHistoryDto selected)
        {
            // Khi nhấn xem chi tiết, anh có thể mở lại Form kết quả với mã HollandCode của dòng đó
            MessageBox.Show($"Lần test ngày {selected.TestDate:dd/MM/yyyy}\nKết quả: {selected.HollandCode}", "Chi tiết");
        }
    }
}