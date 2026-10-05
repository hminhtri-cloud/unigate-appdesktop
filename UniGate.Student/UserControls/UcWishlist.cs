using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing; // Thêm cái này để dùng Color
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniGate.Shared.DTOs;
using static UniGate.Student.Program;

namespace UniGate.Student.UserControls
{
    public partial class UcWishlist : UserControl
    {
        private readonly HttpClient _http = GlobalConfig.GetClient();

        // Dùng BindingSource để xử lý xóa dòng mượt mà hơn
        private BindingSource _bindingSource = new BindingSource();

        public UcWishlist()
        {
            InitializeComponent();

            // 1. SETUP CỘT CHO BẢNG (QUAN TRỌNG)
            SetupGridColumns();

            // 2. Events
            this.Load += UcWishlist_Load;
            this.btnRefresh.Click += (s, e) => LoadWishlist();
            this.dgvFavorites.CellContentClick += DgvFavorites_CellContentClick;
        }

        // --- HÀM SETUP CỘT (ĐỂ KHÔNG BỊ SAI INDEX) ---
        private void SetupGridColumns()
        {
            dgvFavorites.AutoGenerateColumns = false;
            dgvFavorites.Columns.Clear();

            // Style Header cho đẹp (Đồng bộ với UcSearch)
            dgvFavorites.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(14, 165, 233);
            dgvFavorites.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvFavorites.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvFavorites.RowTemplate.Height = 45;

            // Định nghĩa cột
            var colId = new DataGridViewTextBoxColumn { Name = "colId", DataPropertyName = "MajorId", Visible = false }; // Cột ẩn chứa ID
            var colUni = new DataGridViewTextBoxColumn { Name = "colUni", HeaderText = "Trường ĐH", DataPropertyName = "UniversityName" };
            var colMajor = new DataGridViewTextBoxColumn { Name = "colMajor", HeaderText = "Ngành", DataPropertyName = "MajorName" };
            var colGroup = new DataGridViewTextBoxColumn { Name = "colGroup", HeaderText = "Tổ hợp", DataPropertyName = "GroupCode" };
            var colScore = new DataGridViewTextBoxColumn { Name = "colScore", HeaderText = "Điểm chuẩn", DataPropertyName = "CutoffScore" };
            var colDate = new DataGridViewTextBoxColumn { Name = "colDate", HeaderText = "Ngày lưu", DataPropertyName = "SavedAt" };

            // Cột Nút Xóa
            var colDelete = new DataGridViewButtonColumn
            {
                Name = "colDelete", // Đặt tên chuẩn để bắt sự kiện
                HeaderText = "Xóa",
                Text = "🗑",
                UseColumnTextForButtonValue = true,
                FillWeight = 40,
                FlatStyle = FlatStyle.Flat
            };
            colDelete.DefaultCellStyle.ForeColor = Color.Red;

            dgvFavorites.Columns.AddRange(colId, colUni, colMajor, colGroup, colScore, colDate, colDelete);
        }

        private async void UcWishlist_Load(object? sender, EventArgs e)
        {
            await LoadWishlist();
        }

        private async Task LoadWishlist()
        {
            if (string.IsNullOrEmpty(UserSession.Token)) return;

            try
            {
                _http.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", UserSession.Token);
                var res = await _http.GetFromJsonAsync<List<FavoriteMajorDto>>("api/Favorites/my-favorites");

                if (res != null)
                {
                    // Gán vào BindingSource thay vì gán trực tiếp DataSource
                    _bindingSource.DataSource = res;
                    dgvFavorites.DataSource = _bindingSource;

                    lblCount.Text = $"Đã lưu: {res.Count} trường";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách: " + ex.Message);
            }
        }

        private async void DgvFavorites_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra index hợp lệ
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            // Kiểm tra bấm đúng cột có tên "colDelete"
            if (dgvFavorites.Columns[e.ColumnIndex].Name == "colDelete")
            {
                var confirm = MessageBox.Show("Bạn muốn xóa ngành này khỏi danh sách?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        // 1. Lấy ID an toàn từ cột tên "colId"
                        var cellValue = dgvFavorites.Rows[e.RowIndex].Cells["colId"].Value;
                        if (cellValue == null) return;

                        int majorId = Convert.ToInt32(cellValue);

                        // 2. GỌI API XÓA
                        _http.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", UserSession.Token);
                        var res = await _http.DeleteAsync($"api/Favorites/remove?majorId={majorId}");

                        if (res.IsSuccessStatusCode)
                        {
                            // 3. Xóa dòng khỏi BindingSource (An toàn hơn Rows.RemoveAt)
                            _bindingSource.RemoveAt(e.RowIndex);

                            // Cập nhật lại số lượng
                            lblCount.Text = $"Đã lưu: {_bindingSource.Count} trường";

                            MessageBox.Show("Đã xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Lỗi Server: " + await res.Content.ReadAsStringAsync());
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
}