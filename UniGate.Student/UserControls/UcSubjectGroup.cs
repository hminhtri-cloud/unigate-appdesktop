using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniGate.Shared.DTOs;
using static UniGate.Student.Program;

namespace UniGate.Student.UserControls
{
    public partial class UcSubjectGroups : UserControl
    {
        private readonly HttpClient _http = GlobalConfig.GetClient();
        private Button btnReload; // Nút tải lại (Code tay cho chắc)

        public UcSubjectGroups()
        {
            InitializeComponent();

            // Cấu hình bảng dữ liệu
            dgvSubjectGroups.AutoGenerateColumns = false;

            // Đăng ký sự kiện
            this.Load += async (s, e) => await LoadDataAsync();
            this.dgvSubjectGroups.CellContentClick += dgvSubjectGroups_CellContentClick;

            // Thêm nút tải lại
            SetupReloadButton();
        }

        private void SetupReloadButton()
        {
            btnReload = new Button();
            btnReload.Text = "🔄 Tải lại dữ liệu";
            btnReload.Size = new Size(140, 35);
            btnReload.BackColor = Color.Orange;
            btnReload.ForeColor = Color.White;
            btnReload.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            btnReload.FlatStyle = FlatStyle.Flat;
            btnReload.FlatAppearance.BorderSize = 0;
            btnReload.Cursor = Cursors.Hand;

            // Neo góc trên phải
            btnReload.Location = new Point(this.Width - 160, 15);
            btnReload.Anchor = AnchorStyles.Top | AnchorStyles.Right;

            btnReload.Click += async (s, e) => await LoadDataAsync();

            // Thêm vào Panel Header
            this.pnlHeader.Controls.Add(btnReload);
            btnReload.BringToFront();
        }

        public async Task LoadDataAsync()
        {
            if (UserSession.UserId <= 0)
            {
                MessageBox.Show("Vui lòng đăng nhập lại!", "Lỗi Session");
                return;
            }

            try
            {
                if (btnReload != null) btnReload.Text = "⏳ Đang tải...";

                // 1. Lấy danh sách khối (A00, A01...)
                var groups = await _http.GetFromJsonAsync<List<SubjectGroupDto>>("api/SubjectGroups");


                // 2. Lấy điểm user (để tính toán)
                UserScoreRequest myScore = null;
                try { myScore = await _http.GetFromJsonAsync<UserScoreRequest>("api/UserScores/my-score"); } catch { }

                // 3. Lấy danh sách đã chọn (để tô màu)
                List<string> myTargets = new List<string>();
                try
                {
                    var targets = await _http.GetFromJsonAsync<List<PercentileResultDto>>("api/UserScores/my-targets-stats");
                    if (targets != null) myTargets = targets.Select(t => t.SubjectGroup).ToList();
                }
                catch { }

                // 4. Đổ dữ liệu
                dgvSubjectGroups.Rows.Clear();
                if (groups != null)
                {
                    foreach (var g in groups)
                    {
                        // Tính điểm thông minh (Xem hàm bên dưới)
                        decimal scoreVal = CalculateSmartScore(g.GroupCode, myScore);

                        // Trạng thái chọn
                        bool isSelected = myTargets.Contains(g.GroupCode);
                        string btnText = isSelected ? "Đã chọn" : "Chọn";

                        int idx = dgvSubjectGroups.Rows.Add(g.GroupCode, g.Subjects, scoreVal, btnText);

                        // Tô màu nếu đã chọn
                        if (isSelected)
                        {
                            dgvSubjectGroups.Rows[idx].DefaultCellStyle.BackColor = Color.FromArgb(220, 255, 220); // Xanh nhạt
                            dgvSubjectGroups.Rows[idx].Cells["colAction"].Style.ForeColor = Color.Green;
                            dgvSubjectGroups.Rows[idx].Cells["colAction"].Style.SelectionForeColor = Color.Green;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }
            finally
            {
                if (btnReload != null) btnReload.Text = "🔄 Tải lại dữ liệu";
            }
        }

        // --- BỘ NÃO TÍNH ĐIỂM (SỬA LỖI 0 ĐIỂM) ---
        private decimal CalculateSmartScore(string group, UserScoreRequest s)
        {
            if (s == null) return 0;
            decimal t = 0;

            // Định nghĩa cứng các khối phổ biến để tránh lỗi logic
            if (group == "A00") t = GetScore(s, "Toán") + GetScore(s, "Lý") + GetScore(s, "Hóa");
            else if (group == "A01") t = GetScore(s, "Toán") + GetScore(s, "Lý") + GetScore(s, "Anh");
            else if (group == "B00") t = GetScore(s, "Toán") + GetScore(s, "Hóa") + GetScore(s, "Sinh");
            else if (group == "C00") t = GetScore(s, "Văn") + GetScore(s, "Sử") + GetScore(s, "Địa");
            else if (group == "D01") t = GetScore(s, "Toán") + GetScore(s, "Văn") + GetScore(s, "Anh");
            else if (group == "D07") t = GetScore(s, "Toán") + GetScore(s, "Hóa") + GetScore(s, "Anh");

            // Nếu có điểm -> Cộng điểm ưu tiên
            if (t > 0)
            {
                decimal kv = s.KhuVuc switch { "KV1" => 0.75m, "KV2-NT" => 0.5m, "KV2" => 0.25m, _ => 0 };
                decimal dt = s.DoiTuong switch { "UT1" => 2.0m, "UT2" => 1.0m, _ => 0 };
                return t + kv + dt;
            }
            return 0;
        }

        // Hàm tìm điểm chấp hết các loại tên
        private decimal GetScore(UserScoreRequest s, string keyword)
        {
            // 1. Check môn bắt buộc
            if (keyword == "Toán") return s.Thpt_Toan ?? s.HB_Toan ?? 0;
            if (keyword == "Văn") return s.Thpt_Van ?? s.HB_Van ?? 0;

            // 2. Check môn tự chọn (Quan trọng: So sánh có chứa từ khóa)
            // Ví dụ: keyword="Lý" sẽ khớp với "Vật Lý", "Vật lí", "Môn Lý"...
            if (ContainsKeyword(s.Thpt_TuChon1_Mon, keyword)) return s.Thpt_TuChon1_Diem ?? 0;
            if (ContainsKeyword(s.Thpt_TuChon2_Mon, keyword)) return s.Thpt_TuChon2_Diem ?? 0;

            // 3. Check học bạ (Cứu cánh cuối cùng)
            if (keyword == "Anh") return s.HB_Anh ?? 0;
            if (keyword == "Lý") return s.HB_Ly ?? 0;
            if (keyword == "Hóa") return s.HB_Hoa ?? 0;
            if (keyword == "Sinh") return s.HB_Sinh ?? 0;
            if (keyword == "Sử") return s.HB_Su ?? 0;
            if (keyword == "Địa") return s.HB_Dia ?? 0;
            if (keyword == "GDCD") return s.HB_GDKTPL ?? 0;

            return 0;
        }

        private bool ContainsKeyword(string subjectName, string keyword)
        {
            if (string.IsNullOrEmpty(subjectName)) return false;
            string lowerName = subjectName.ToLower();
            string lowerKey = keyword.ToLower();

            // Xử lý đặc biệt cho Lý/Lí, Hóa/Hoá
            if (lowerKey == "lý" || lowerKey == "lí")
                return lowerName.Contains("lý") || lowerName.Contains("lí") || lowerName.Contains("vật");

            if (lowerKey == "hóa" || lowerKey == "hoá")
                return lowerName.Contains("hóa") || lowerName.Contains("hoá");

            if (lowerKey == "anh")
                return lowerName.Contains("anh") || lowerName.Contains("ngoại");

            return lowerName.Contains(lowerKey);
        }

        private async void dgvSubjectGroups_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            // Chỉ xử lý nút bấm
            if (e.RowIndex >= 0 && dgvSubjectGroups.Columns[e.ColumnIndex].Name == "colAction")
            {
                string groupCode = dgvSubjectGroups.Rows[e.RowIndex].Cells["colGroupCode"].Value.ToString();
                dgvSubjectGroups.Enabled = false; // Chặn bấm liên tục

                try
                {
                    var req = new UserTargetDto { GroupCode = groupCode }; // UserId không cần gửi cũng được vì Server lấy từ Token
                    _http.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", UserSession.Token);

                   
                    // Sửa dòng này:
                    var res = await _http.PostAsJsonAsync("api/SubjectGroups/set-target", req);

                    if (res.IsSuccessStatusCode)
                    {
                        await LoadDataAsync(); // Tải lại để cập nhật màu và chữ
                        MessageBox.Show($"Cập nhật khối {groupCode} thành công!", "Thông báo");
                    }
                    else
                    {
                        MessageBox.Show("Lỗi Server: " + await res.Content.ReadAsStringAsync());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi mạng: " + ex.Message);
                }
                finally
                {
                    dgvSubjectGroups.Enabled = true;
                }
            }
        }
    }
}