using System.Net.Http.Headers;
using System.Net.Http.Json;
using UniGate.Shared.DTOs;
using System.Diagnostics; // Dùng để Debug cho chuyên nghiệp

using static UniGate.Student.Program;

namespace UniGate.Student.UserControls
{
    public partial class UcDashboard : UserControl
    {
        // Khởi tạo HttpClient kết nối tới Server
        private readonly HttpClient _http = GlobalConfig.GetClient();

        public UcDashboard()
        {
            InitializeComponent();

            // SỬA ĐOẠN NÀY: Gom hết vào sự kiện Load cho chắc ăn 100%
            this.Load += async (s, e) =>
            {
                // 1. Chạy đếm ngược
                CalculateExamCountdown();

                // 2. Gọi API tải dữ liệu ngay khi mở
                await LoadStats();
            };

            // Hiển thị ngày tháng
            lblDate.Text = "Hôm nay là " + DateTime.Now.ToString("dddd, dd/MM/yyyy");
        }

        // --- HÀM 1: ĐẾM NGƯỢC NGÀY THI ---
        private void CalculateExamCountdown()
        {
            try
            {
                // Giả định ngày thi là 28/06/2026
                DateTime examDate = new DateTime(2026, 06, 28);
                TimeSpan diff = examDate - DateTime.Now;

                int daysLeft = diff.Days;
                if (daysLeft < 0) daysLeft = 0;

                lblDaysLeft.Text = $"{daysLeft}\nNgày";

                // Vẽ vòng tròn tiến độ (mốc 365 ngày)
                double totalScope = 365;
                int progress = (int)((totalScope - daysLeft) / totalScope * 100);

                if (progress < 0) progress = 0;
                if (progress > 100) progress = 100;

                circleProgress.Value = progress;
            }
            catch { /* Bỏ qua lỗi vẽ UI */ }
        }

        // --- HÀM 2: TẢI DỮ LIỆU TỪ SERVER ---

        private async Task LoadStats()
        {
            // Check 1: Token có chưa?
            if (string.IsNullOrEmpty(UserSession.Token))
            {
                // MessageBox.Show("Chưa có Token đăng nhập!"); 
                return;
            }

            try
            {
                _http.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", UserSession.Token);

                // Gọi API
                var stats = await _http.GetFromJsonAsync<StudentDashboardStatsDto>("api/Dashboard/dashboard-stats");

                // Check 2: Dữ liệu về đến tay C# chưa?
                if (stats != null)
                {
                    // BẬT CÁI NÀY LÊN ĐỂ KIỂM TRA:
                    // MessageBox.Show($"Debug:\nTên: {stats.FullName}\nĐiểm: {stats.HighestScore}\nWishlist: {stats.WishlistCount}", "Kiểm tra dữ liệu");

                    // --- GÁN DỮ LIỆU VÀO UI ---

                    // 1. Tên
                    if (lblWelcome != null)
                        lblWelcome.Text = $"Chào {stats.FullName}, chúc học tốt!";

                    // 2. Điểm
                    if (lblScoreVal != null)
                    {
                        // Format số đẹp (nếu null thì hiện Chưa nhập)
                        string scoreText = (stats.HighestScore.HasValue && stats.HighestScore > 0)
                                            ? stats.HighestScore.Value.ToString("0.##")
                                            : "Chưa nhập";
                        lblScoreVal.Text = scoreText;
                    }

                    // 3. Nguyện vọng
                    if (lblWishlistVal != null)
                        lblWishlistVal.Text = stats.WishlistCount.ToString();

                    // 4. Holland
                    if (lblHollandVal != null)
                        lblHollandVal.Text = stats.HasHolland ? stats.HollandResult : "Chưa test";
                }
                else
                {
                    MessageBox.Show("Stats bị Null (API trả về rỗng)!");
                }
            }
            catch (Exception ex)
            {
                // Nếu lỗi thì hiện ra để biết đường sửa
                MessageBox.Show("Lỗi Crash: " + ex.Message);
            }
        }
        private async Task LoadStatsold()
        {
            if (string.IsNullOrEmpty(UserSession.Token)) return;

            try
            {
                _http.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", UserSession.Token);
                var stats = await _http.GetFromJsonAsync<StudentDashboardStatsDto>("api/Dashboard/dashboard-stats");

                if (stats != null)
                {
                    // Cập nhật lời chào
                    if (lblWelcome != null)
                        lblWelcome.Text = $"Chào {stats.FullName?.Split(' ').Last() ?? "Bạn"}, chúc học tốt!";

                    // Thẻ điểm
                    if (lblScoreVal != null)
                        lblScoreVal.Text = (stats.HighestScore.HasValue && stats.HighestScore > 0)
                                           ? stats.HighestScore.Value.ToString("0.##") : "Chưa nhập";

                    // Thẻ nguyện vọng
                    if (lblWishlistVal != null)
                        lblWishlistVal.Text = stats.WishlistCount.ToString();

                    // Thẻ Holland
                    if (lblHollandVal != null)
                        lblHollandVal.Text = stats.HasHolland ? stats.HollandResult : "Chưa test";
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("!!! LỖI: " + ex.Message);
            }
        }
    }
}