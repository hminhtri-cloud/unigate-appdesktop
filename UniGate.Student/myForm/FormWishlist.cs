using System.Net.Http.Headers;
using System.Net.Http.Json;
using UniGate.Shared.DTOs;

namespace UniGate.Student.myForm;

public partial class FormWishlist : Form
{
    private readonly HttpClient _http = new() { BaseAddress = new Uri("https://localhost:7030/") };

    public FormWishlist()
    {
        InitializeComponent();
        this.Load += FormWishlist_Load;
    }

    private async void FormWishlist_Load(object? sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(UserSession.Token)) return;

        _http.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", UserSession.Token);

        try
        {
            var res = await _http.GetAsync("api/Favorites/my-favorites");
            if (res.IsSuccessStatusCode)
            {
                var list = await res.Content.ReadFromJsonAsync<List<FavoriteMajorDto>>();
                dgvFavorites.DataSource = list;

                // Ẩn cột ID cho đẹp
                if (dgvFavorites.Columns["MajorId"] != null)
                    dgvFavorites.Columns["MajorId"].Visible = false;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi tải danh sách: " + ex.Message);
        }
    }
}