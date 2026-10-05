using System.Net.Http.Headers;
using System.Net.Http.Json;
using UniGate.Shared.DTOs;

namespace UniGate.Student.myForm;

public partial class ScoreDistribution : Form
{
    // Nhớ sửa cái Port 7030 này cho đúng máy m nha
    private readonly HttpClient _http = new() { BaseAddress = new Uri("https://localhost:7030/") };

    public ScoreDistribution()
    {
        InitializeComponent();
        this.Load += FormMyStats_Load; // Đăng ký sự kiện Load
    }

    private async void FormMyStats_Load(object? sender, EventArgs e)
    {
        await LoadData();
    }

    private async Task LoadData()
    {
        // 1. Kiểm tra Token (Quan trọng!)
        if (string.IsNullOrEmpty(UserSession.Token))
        {
            MessageBox.Show("M chưa đăng nhập, biến ra ngoài đăng nhập đi!");
            this.Close();
            return;
        }

        _http.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", UserSession.Token);

        try
        {
            // 2. Gọi cái API "thông minh" mình vừa viết
            var response = await _http.GetAsync("api/UserScores/my-targets-stats");

            if (response.IsSuccessStatusCode)
            {
                var data = await response.Content.ReadFromJsonAsync<List<PercentileResultDto>>();

                // 3. Xử lý hiển thị
                if (data != null && data.Any())
                {
                    // --- Hiển thị cái NGON NHẤT lên trên cùng ---
                    var best = data.First(); // Vì API đã sort giảm dần rồi
                    ShowBestResult(best);

                    // --- Đổ dữ liệu vào bảng ---
                    dgvStats.DataSource = data;
                    FormatGrid(); // Hàm trang trí bảng cho đẹp
                }
                else
                {
                    // Trường hợp chưa chọn khối nào
                    lblBestGroup.Text = "???";
                    lblBestPercentile.Text = "Chưa có dữ liệu";
                    lblAdvice.Text = "M chưa chọn khối thi mục tiêu nào cả. Bấm nút Sửa để chọn đi!";
                    dgvStats.DataSource = null;
                }
            }
            else
            {
                // Có thể do chưa nhập điểm
                lblAdvice.Text = "Có vẻ m chưa nhập điểm học bạ/thi thử?";
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi kết nối Server: " + ex.Message);
        }
    }

    private void ShowBestResult(PercentileResultDto best)
    {
        lblBestGroup.Text = $"Khối {best.SubjectGroup}";
        lblBestPercentile.Text = $"Top {100 - best.Percentile:0.##}%"; // Top 5%, Top 10% nghe xịn hơn

        // Logic đổi màu và lời khuyên
        if (best.Percentile >= 90)
        {
            lblBestPercentile.ForeColor = Color.Green;
            lblAdvice.Text = "Quá đỉnh! M đang nằm trong top dẫn đầu.";
        }
        else if (best.Percentile >= 70)
        {
            lblBestPercentile.ForeColor = Color.Blue;
            lblAdvice.Text = "Khá lắm, cố chút nữa là vào trường Top.";
        }
        else if (best.Percentile >= 50)
        {
            lblBestPercentile.ForeColor = Color.Orange;
            lblAdvice.Text = "Mức trung bình, cần cày cuốc thêm nhiều nha.";
        }
        else
        {
            lblBestPercentile.ForeColor = Color.Red;
            lblAdvice.Text = "Nguy hiểm! Cần xem lại phương pháp học gấp.";
        }
    }

    private void FormatGrid()
    {
        // Đặt tên tiếng Việt cho các cột nhìn cho chuyên nghiệp
        if (dgvStats.Columns["SubjectGroup"] != null) dgvStats.Columns["SubjectGroup"].HeaderText = "Khối Thi";
        if (dgvStats.Columns["UserScore"] != null) dgvStats.Columns["UserScore"].HeaderText = "Điểm Của M";
        if (dgvStats.Columns["Percentile"] != null) dgvStats.Columns["Percentile"].HeaderText = "Phân Vị (%)";

        // Ẩn mấy cột không cần thiết nếu muốn
        if (dgvStats.Columns["TotalCandidates"] != null) dgvStats.Columns["TotalCandidates"].Visible = false;
        if (dgvStats.Columns["LowerThanCount"] != null) dgvStats.Columns["LowerThanCount"].Visible = false;

        dgvStats.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
    }

    // Nút mở Form chọn khối (UserTargets)
    private void btnManageTargets_Click(object sender, EventArgs e)
    {
        // var frm = new FormSelectTargets(); // Form này m tự làm nhé
        // frm.ShowDialog();
        // Sau khi tắt form chọn khối thì load lại dữ liệu
        // await LoadData();
    }
}