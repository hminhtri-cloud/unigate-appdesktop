using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Windows.Forms.DataVisualization.Charting; // Nhớ using cái này
using UniGate.Shared.DTOs;
using static UniGate.Admin.Program;


namespace UniGate.Admin.UserControls;

public partial class UcDashboard : UserControl
{
    private readonly HttpClient _http = GlobalConfig.GetClient();
    // Khai báo biến biểu đồ ở đây (thay vì Designer)
    private Chart chartRegion = new Chart();

    public UcDashboard()
    {
        InitializeComponent();

        // --- THÊM ĐOẠN NÀY ĐỂ TẠO BIỂU ĐỒ ---
        SetupChart();

        this.Load += UcDashboard_Load;
    }

    // Hàm này để khởi tạo biểu đồ bằng Code
    private void SetupChart()
    {
        // 1. Cấu hình cơ bản
        chartRegion.Dock = DockStyle.Fill; // Tràn đầy cái Panel chứa nó
        chartRegion.BackColor = Color.WhiteSmoke;

        // 2. Tạo vùng vẽ (ChartArea)
        ChartArea area = new ChartArea("MainArea");
        area.BackColor = Color.White;
        chartRegion.ChartAreas.Add(area);

        // 3. Tạo Tiêu đề
        Title title = new Title("Phân bố Trường ĐH theo Khu vực");
        title.Font = new Font("Segoe UI", 12, FontStyle.Bold);
        chartRegion.Titles.Add(title);

        // 4. Tạo Legend (Chú thích)
        Legend legend = new Legend("MainLegend");
        legend.Docking = Docking.Bottom; // Nằm ở dưới đáy
        chartRegion.Legends.Add(legend);

        // 5. NHÉT VÀO PANEL (Quan trọng nhất)
        // Đảm bảo m đã tạo pnlChartContainer bên Designer
        pnlChartContainer.Controls.Add(chartRegion);
    }

    private async void UcDashboard_Load(object? sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(AdminSession.Token))
            _http.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", AdminSession.Token);

        await LoadData();
    }

    private async Task LoadData()
    {
        try
        {
            var stats = await _http.GetFromJsonAsync<DashboardStatsDto>("api/admin/dashboard/stats");

            if (stats != null)
            {
                // Hiển thị số liệu lên Label (nhớ đặt tên Label bên Designer cho đúng)
                // Ví dụ: lblTotalStudents, lblTotalUnis...
                // lblTotalStudents.Text = stats.TotalUsers.ToString("N0");

                // Vẽ dữ liệu lên biểu đồ
                DrawChartData(stats.UnisByRegion);
            }
        }
        catch { }
    }

    private void DrawChartData(Dictionary<string, int> data)
    {
        // Xóa dữ liệu cũ nếu có
        chartRegion.Series.Clear();

        // Tạo Series mới (Kiểu Doughnut - Bánh vòng)
        Series series = new Series("KhuVuc");
        series.ChartType = SeriesChartType.Doughnut;
        series.IsValueShownAsLabel = true;
        series.LabelForeColor = Color.White;
        series.Font = new Font("Segoe UI", 10, FontStyle.Bold);

        // Đổ dữ liệu
        foreach (var item in data)
        {
            // AddXY(Tên, Giá trị)
            int index = series.Points.AddXY(item.Key, item.Value);

            // Set nhãn hiển thị: "Miền Bắc: 15"
            series.Points[index].Label = $"{item.Key}: {item.Value}";
            series.Points[index].LegendText = item.Key; // Hiện ở chú thích dưới đáy
        }

        chartRegion.Series.Add(series);
        chartRegion.Palette = ChartColorPalette.SeaGreen; // Màu xanh biển đẹp mắt
    }
}