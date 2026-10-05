using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniGate.Shared.DTOs;
using static UniGate.Admin.Program;

namespace UniGate.Admin.UserControls
{
    public partial class UcSubjectGroups : UserControl
    {
        private readonly HttpClient _http = GlobalConfig.GetClient();
        private int _selectedId = 0;

        public UcSubjectGroups()
        {
            InitializeComponent();

            // Cấu hình Grid
            dgvGroups.AutoGenerateColumns = false;

            // Sự kiện
            this.Load += async (s, e) => await LoadData();
            dgvGroups.CellClick += DgvGroups_CellClick;

            // Nút bấm
            btnAdd.Click += BtnAdd_Click;
            btnUpdate.Click += BtnUpdate_Click;
            btnDelete.Click += BtnDelete_Click;
            btnClear.Click += (s, e) => ClearForm();
        }

        private async Task LoadData()
        {
            try
            {
                var list = await _http.GetFromJsonAsync<List<SubjectGroupDto>>("api/admin/subject-groups");
                dgvGroups.DataSource = list;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message);
            }
        }

        // --- CLICK BẢNG AN TOÀN ---
        private void DgvGroups_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            try
            {
                var row = dgvGroups.Rows[e.RowIndex];
                var item = row.DataBoundItem as SubjectGroupDto;

                if (item != null)
                {
                    _selectedId = item.Id;
                    txtCode.Text = item.GroupCode;
                    txtSubjects.Text = item.Subjects;
                    txtDesc.Text = item.Description;

                    // Quản lý nút
                    btnAdd.Enabled = false;
                    txtCode.Enabled = false; // Mã khối thường không nên sửa để tránh lỗi hệ thống
                    btnUpdate.Enabled = true;
                    btnDelete.Enabled = true;
                }
            }
            catch { }
        }

        // --- THÊM ---
        private async void BtnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCode.Text)) { MessageBox.Show("Chưa nhập mã khối!"); return; }

            var req = GetFormData();
            var res = await _http.PostAsJsonAsync("api/admin/subject-groups", req);

            if (res.IsSuccessStatusCode)
            {
                MessageBox.Show("Thêm thành công!");
                await LoadData();
                ClearForm();
            }
            else MessageBox.Show("Lỗi: " + await res.Content.ReadAsStringAsync());
        }

        // --- SỬA ---
        private async void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (_selectedId == 0) return;
            var req = GetFormData();

            // Vì txtCode bị khóa khi sửa, nên phải gán lại mã cũ để không bị null
            req.GroupCode = txtCode.Text;

            var res = await _http.PutAsJsonAsync($"api/admin/subject-groups/{_selectedId}", req);
            if (res.IsSuccessStatusCode)
            {
                MessageBox.Show("Cập nhật thành công!");
                await LoadData();
                ClearForm();
            }
        }

        // --- XÓA ---
        private async void BtnDelete_Click(object sender, EventArgs e)
        {
            if (_selectedId == 0) return;
            if (MessageBox.Show($"Bạn có chắc muốn xóa khối {txtCode.Text}?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                var res = await _http.DeleteAsync($"api/admin/subject-groups/{_selectedId}");
                if (res.IsSuccessStatusCode)
                {
                    MessageBox.Show("Đã xóa!");
                    await LoadData();
                    ClearForm();
                }
                else MessageBox.Show("Không thể xóa: " + await res.Content.ReadAsStringAsync());
            }
        }

        private SubjectGroupDto GetFormData()
        {
            return new SubjectGroupDto
            {
                GroupCode = txtCode.Text.ToUpper(), // Tự động viết hoa (a00 -> A00)
                Subjects = txtSubjects.Text,
                Description = txtDesc.Text
            };
        }

        private void ClearForm()
        {
            _selectedId = 0;
            txtCode.Clear();
            txtSubjects.Clear();
            txtDesc.Clear();

            txtCode.Enabled = true; // Mở lại cho nhập mới
            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }
    }
}