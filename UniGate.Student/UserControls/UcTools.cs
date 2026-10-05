using Guna.UI2.WinForms;
using System.Drawing; // Để dùng Color
using System.Net.Http.Headers;
using System.Net.Http.Json;
using UniGate.Shared.DTOs;
using static UniGate.Student.Program;

namespace UniGate.Student.UserControls
{
    public partial class UcTools : UserControl
    {
        private readonly HttpClient _http = GlobalConfig.GetClient();

        public UcTools()
        {
            InitializeComponent();

            // 1. Setup cột cho bảng thống kê (QUAN TRỌNG ĐỂ HIỆN ĐẸP)
            SetupGridColumns();

            this.Load += UcTools_Load;
            this.btnManageTargets.Click += BtnManageTargets_Click;
        }

        // --- HÀM SETUP CỘT CHO BẢNG ---
        private void SetupGridColumns()
        {
            dgvStats.AutoGenerateColumns = false;
            dgvStats.Columns.Clear();

            // Style Header
            dgvStats.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(14, 165, 233);
            dgvStats.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvStats.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvStats.RowTemplate.Height = 45;

            dgvStats.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Khối thi", DataPropertyName = "SubjectGroup" });
            dgvStats.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Điểm của bạn", DataPropertyName = "UserScore", DefaultCellStyle = new DataGridViewCellStyle { Format = "N2" } }); // 2 số lẻ
            dgvStats.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Vượt qua (thí sinh)", DataPropertyName = "LowerThanCount", DefaultCellStyle = new DataGridViewCellStyle { Format = "N0" } }); // Phẩy hàng nghìn
            dgvStats.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Tổng thí sinh", DataPropertyName = "TotalCandidates", DefaultCellStyle = new DataGridViewCellStyle { Format = "N0" } });

            // Cột Percentile hiển thị dạng thanh tiến độ (nếu muốn) hoặc số %
            var colPercent = new DataGridViewTextBoxColumn
            {
                HeaderText = "Phần trăm (Percentile)",
                DataPropertyName = "Percentile",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "0.00'%'", ForeColor = Color.DarkBlue, Font = new Font("Segoe UI", 9F, FontStyle.Bold) }
            };
            dgvStats.Columns.Add(colPercent);
        }

        private async void UcTools_Load(object? sender, EventArgs e)
        {
            await LoadData();
        }

        private async Task LoadData()
        {
            if (string.IsNullOrEmpty(UserSession.Token)) return;

            try
            {
                lblAdvice.Text = "⏳ Đang phân tích dữ liệu điểm thi của bạn...";
                dgvStats.Enabled = false;

                _http.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", UserSession.Token);

                // Gọi API lấy thống kê TẤT CẢ các khối đã chọn
                var data = await _http.GetFromJsonAsync<List<PercentileResultDto>>("api/SubjectGroups/my-targets-stats");

                if (data != null && data.Any(x => x.TotalCandidates > 0))
                {
                    // 1. Hiển thị khối tốt nhất lên Card to
                    var best = data.OrderByDescending(x => x.Percentile).First();
                    ShowBestResult(best);

                    // 2. Đổ TOÀN BỘ danh sách vào bảng bên dưới
                    dgvStats.DataSource = data;
                }
                else
                {
                    lblBestGroup.Text = "---";
                    lblBestPercentile.Text = "Chưa có dữ liệu";
                    lblAdvice.Text = "Hãy vào mục 'Quản lý Khối thi' để chọn khối và nhập điểm nhé.";
                    dgvStats.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
                lblAdvice.Text = "❌ Lỗi kết nối Server.";
            }
            finally
            {
                dgvStats.Enabled = true;
            }
        }

        private void ShowBestResult(PercentileResultDto best)
        {
            lblBestGroup.Text = $"Khối {best.SubjectGroup}";

            // Tính Top % (Ví dụ: Percentile 95 -> Top 5%)
            double topPercent = 100 - best.Percentile;
            lblBestPercentile.Text = $"Top {topPercent:0.##}%";

            // Logic tô màu và lời khuyên
            if (best.Percentile >= 90)
            {
                lblBestPercentile.ForeColor = Color.ForestGreen;
                lblAdvice.Text = $"Quá đỉnh! Với khối {best.SubjectGroup}, bạn đã vượt qua {best.Percentile}% thí sinh cả nước. Cơ hội đỗ NV1 rất cao.";
            }
            else if (best.Percentile >= 70)
            {
                lblBestPercentile.ForeColor = Color.DodgerBlue;
                lblAdvice.Text = $"Kết quả khối {best.SubjectGroup} khá khả quan! Bạn đang ở mức Khá-Giỏi.";
            }
            else if (best.Percentile >= 50)
            {
                lblBestPercentile.ForeColor = Color.DarkOrange;
                lblAdvice.Text = $"Khối {best.SubjectGroup} ở mức trung bình. Cần cố gắng hơn để vào trường Top.";
            }
            else
            {
                lblBestPercentile.ForeColor = Color.Crimson;
                lblAdvice.Text = $"Cảnh báo: Điểm khối {best.SubjectGroup} đang thấp hơn mặt bằng chung. Nên cân nhắc lại chiến thuật.";
            }
        }

        private void BtnManageTargets_Click(object? sender, EventArgs e)
        {
            if (this.ParentForm is FormMain mainForm)
            {
                mainForm.ShowView(new UcSubjectGroups(), mainForm.GetBtnSubjectGroup(), "Quản lý Khối thi Mục tiêu");
            }
        }
    }
}