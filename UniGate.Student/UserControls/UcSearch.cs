using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniGate.Shared.DTOs;
using static UniGate.Student.Program; // Để dùng GlobalConfig và UserSession

namespace UniGate.Student.UserControls
{
    public partial class UcSearch : UserControl
    {
        private readonly HttpClient _http = GlobalConfig.GetClient();
        
        public UcSearch()
        {
            InitializeComponent();

            /// Setup các bảng
            SetupGridColumns(dgvScore);
            SetupGridColumns(dgvTargets);
            SetupGridColumns(dgvHolland);
            SetupGridColumns(dgvDgnl);
            SetupGridColumns(dgvBestFit);

            // Gắn sự kiện
            this.tabControl.SelectedIndexChanged += TabControl_SelectedIndexChanged;
            this.btnFilter.Click += async (s, e) => await LoadByScore();

            // Gắn sự kiện BẤM TIM
            dgvScore.CellContentClick += Dgv_CellContentClick;
            dgvTargets.CellContentClick += Dgv_CellContentClick;
            dgvHolland.CellContentClick += Dgv_CellContentClick;
            dgvDgnl.CellContentClick += Dgv_CellContentClick;
            dgvBestFit.CellContentClick += Dgv_CellContentClick;

            // Load tab đầu tiên khi mở
            //this.Load += async (s, e) => await LoadByScore();

        }

        // --- CẤU HÌNH CỘT BẢNG ---
        private void SetupGridColumns(Guna2DataGridView grid)
        {
            grid.AutoGenerateColumns = false;
            grid.Columns.Clear();

            // Cột ẩn ID
            var colId = new DataGridViewTextBoxColumn { Name = "colId", DataPropertyName = "MajorId", Visible = false };

            // Các cột hiển thị (DataPropertyName phải khớp JSON chữ thường)
            var colUni = new DataGridViewTextBoxColumn { Name = "colUni", HeaderText = "Trường ĐH", DataPropertyName = "UniversityName" };
            var colMajor = new DataGridViewTextBoxColumn { Name = "colMajor", HeaderText = "Ngành", DataPropertyName = "MajorName" };
            var colGroup = new DataGridViewTextBoxColumn { Name = "colGroup", HeaderText = "Tổ hợp", DataPropertyName = "GroupCode", FillWeight = 40 };
            var colScore = new DataGridViewTextBoxColumn { Name = "colScore", HeaderText = "Điểm chuẩn", DataPropertyName = "CutoffScore", FillWeight = 40 };
            var colMyScore = new DataGridViewTextBoxColumn { Name = "colMyScore", HeaderText = "Điểm bạn", DataPropertyName = "UserScore", FillWeight = 40 };
            var colStatus = new DataGridViewTextBoxColumn { Name = "colStatus", HeaderText = "Đánh giá", DataPropertyName = "Status" };

            // Cột Nút Tim
            var colFav = new DataGridViewButtonColumn
            {
                Name = "colFavorite",
                HeaderText = "Lưu",
                Text = "❤",
                UseColumnTextForButtonValue = true,
                FillWeight = 30,
                FlatStyle = FlatStyle.Flat
            };

            grid.Columns.AddRange(colId, colUni, colMajor, colGroup, colScore, colMyScore, colStatus, colFav);

            // Style Header riêng (nếu cần ghi đè Designer)
            grid.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(14, 165, 233);
            grid.ThemeStyle.HeaderStyle.ForeColor = Color.White;
        }

        // --- XỬ LÝ CHUYỂN TAB ---
        private async void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Reset Token mỗi lần gọi cho chắc
            _http.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", UserSession.Token);

            switch (tabControl.SelectedIndex)
            {
                case 0: await LoadByScore(); break;   // Tab 1: Điểm
                case 1: await LoadByTargets(); break; // Tab 2: Khối
                case 2: await LoadByHolland(); break; // Tab 3: Holland
                case 3: await LoadByDgnl(); break;    // Tab 4: ĐGNL (Phải là case 3)
                case 4: await LoadBestFit(); break;   // Tab 5: AI (Phải là case 4)
            }
        }

        // --- CÁC HÀM LOAD DỮ LIỆU ---
        private async Task LoadByScore()
        {
            try
            {
                decimal margin = numMargin.Value; // Lấy giá trị 0.25, 0.5...
                var res = await _http.GetFromJsonAsync<List<MajorRecommendationDto>>($"api/Recommendation/by-score?margin={margin}");
                dgvScore.DataSource = res;
                ApplyColorCoding(dgvScore);
                lblStatus.Text = $"Tìm thấy {res?.Count ?? 0} kết quả với biên độ +/- {margin}.";
            }
            catch (Exception ex) { MessageBox.Show("Lỗi tải gợi ý điểm: " + ex.Message); }
        }

        private async Task LoadByTargets()
        {
            try
            {
                var res = await _http.GetFromJsonAsync<List<MajorRecommendationDto>>("api/Recommendation/by-targets");
                dgvTargets.DataSource = res;
                ApplyColorCoding(dgvTargets);
            }
            catch { }
        }

        private async Task LoadByHolland()
        {
            try
            {
                // Debug: Hiện thông báo bắt đầu tải
                // MessageBox.Show("Đang gọi API Holland..."); 

                var res = await _http.GetFromJsonAsync<List<MajorRecommendationDto>>("api/Recommendation/by-holland");

                if (res == null || res.Count == 0)
                {
                    MessageBox.Show("Server trả về danh sách rỗng (0 kết quả)!", "Thông báo");
                    return;
                }

                dgvHolland.DataSource = res;
                ApplyColorCoding(dgvHolland);
            }
            catch (HttpRequestException httpEx)
            {
                // Bắt lỗi HTTP (400, 404, 500...)
                MessageBox.Show($"Lỗi gọi API ({httpEx.StatusCode}): {httpEx.Message}", "Lỗi mạng");
            }
            catch (Exception ex)
            {
                // Bắt lỗi khác (Code C# bị sai)
                MessageBox.Show("Lỗi lạ: " + ex.Message, "Lỗi");
            }
        }

        private async Task LoadByDgnl()
        {
            try
            {
                var res = await _http.GetFromJsonAsync<List<MajorRecommendationDto>>("api/Recommendation/by-dgnl");
                dgvDgnl.DataSource = res;
                ApplyColorCoding(dgvDgnl);
            }
            catch (Exception ex) { MessageBox.Show("Lỗi tải ĐGNL: " + ex.Message); }
        }

        private async Task LoadBestFit()
        {
            try
            {
                var res = await _http.GetFromJsonAsync<List<MajorRecommendationDto>>("api/Recommendation/best-fit");
                dgvBestFit.DataSource = res;
                ApplyColorCoding(dgvBestFit);
            }
            catch { }
        }

        // --- TÔ MÀU TRẠNG THÁI ---
        private void ApplyColorCoding(Guna2DataGridView grid)
        {
            if (grid.DataSource == null || grid.Rows.Count == 0) return;

            foreach (DataGridViewRow row in grid.Rows)
            {
                // Lấy giá trị cột Status
                var status = row.Cells["colStatus"].Value?.ToString() ?? "";

                // Logic tô màu xịn xò
                if (status.Contains("PERFECT") || status.Contains("An toàn"))
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(220, 252, 231); // Xanh lá nhạt
                    row.DefaultCellStyle.ForeColor = Color.FromArgb(20, 83, 45);    // Xanh lá đậm
                    row.Cells["colStatus"].Style.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
                }
                else if (status.Contains("Mơ ước") || status.Contains("Mục tiêu"))
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(254, 249, 195); // Vàng nhạt
                    row.DefaultCellStyle.ForeColor = Color.FromArgb(161, 98, 7);    // Vàng nâu
                }
                else if (status.Contains("Mạo hiểm") || status.Contains("khó"))
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(254, 226, 226); // Đỏ nhạt
                    row.DefaultCellStyle.ForeColor = Color.FromArgb(127, 29, 29);   // Đỏ đậm
                }
            }
        }

        // --- XỬ LÝ BẤM TIM (LƯU NGÀNH) ---
        private async void Dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var grid = sender as Guna2DataGridView;
            if (grid == null || e.RowIndex < 0) return;

            if (grid.Columns[e.ColumnIndex].Name == "colFavorite")
            {
                try
                {
                    var idVal = grid.Rows[e.RowIndex].Cells["colId"].Value;
                    if (idVal == null) return;

                    var majorId = Convert.ToInt32(idVal);
                    var req = new ToggleFavoriteRequest { MajorId = majorId };

                    _http.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", UserSession.Token);
                    var res = await _http.PostAsJsonAsync("api/Favorites/toggle", req);

                    if (res.IsSuccessStatusCode)
                    {
                        // Hiệu ứng đã lưu
                        grid.Rows[e.RowIndex].Cells["colFavorite"].Style.ForeColor = Color.Red;
                        MessageBox.Show("Đã cập nhật danh sách yêu thích! ❤", "Thành công");
                    }
                    else
                    {
                        MessageBox.Show("Lỗi: " + await res.Content.ReadAsStringAsync());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        

        
    }
}