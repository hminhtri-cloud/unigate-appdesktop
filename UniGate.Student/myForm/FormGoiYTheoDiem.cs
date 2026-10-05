using System.Net.Http.Headers;
using System.Net.Http.Json;
using UniGate.Shared.DTOs;


namespace UniGate.Student.myForm
{

    public partial class FormGoiYTheoDiem : Form
    {
        private readonly HttpClient _http = new() { BaseAddress = new Uri("https://localhost:7030/") };
        public FormGoiYTheoDiem()
        {
            InitializeComponent();
        }
        private async void btnFilter_Click(object sender, EventArgs e)
        {
            decimal margin = numMargin.Value;

            // Gọi API với tham số margin
            var url = $"api/Recommendation/by-score?margin={margin}";

            if (!string.IsNullOrEmpty(UserSession.Token))
                _http.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", UserSession.Token);

            var res = await _http.GetAsync(url);
            if (res.IsSuccessStatusCode)
            {
                var data = await res.Content.ReadFromJsonAsync<List<MajorRecommendationDto>>();
                dgvResults.DataSource = data;

                // Tô màu cho "xịn" (Mục 2: Xử lý dữ liệu)
                ColorRows();
            }
        }

        private void ColorRows()
        {
            foreach (DataGridViewRow row in dgvResults.Rows)
            {
                string status = row.Cells["Status"].Value?.ToString() ?? "";
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
