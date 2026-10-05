using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniGate.Shared.DTOs;
using static UniGate.Admin.Program;

namespace UniGate.Admin.UserControls
{
    public partial class UcUniversities : UserControl
    {
        private readonly HttpClient _http = GlobalConfig.GetClient();
        private int _selectedId = 0;

        public UcUniversities()
        {
            InitializeComponent();

            // Cấu hình Grid
            dgvUni.AutoGenerateColumns = false;

            // Sự kiện
            this.Load += async (s, e) => await LoadData();
            dgvUni.CellClick += DgvUni_CellClick;

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
                var list = await _http.GetFromJsonAsync<List<UniversityDto>>("api/admin/universities");
                dgvUni.DataSource = list;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }
        }

        // --- XỬ LÝ CLICK BẢNG AN TOÀN ---
        private void DgvUni_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            try
            {
                var row = dgvUni.Rows[e.RowIndex];
                var item = row.DataBoundItem as UniversityDto;

                if (item != null)
                {
                    _selectedId = item.Id;

                    // Đổ dữ liệu vào TextBox
                    txtCode.Text = item.Code;
                    txtName.Text = item.Name;
                    cbRegion.Text = item.Region; // ComboBox Miền
                    txtAddress.Text = item.Address;
                    txtWebsite.Text = item.Website;
                    txtLogo.Text = item.LogoUrl;
                    txtDesc.Text = item.Description;

                    // Quản lý trạng thái nút
                    btnAdd.Enabled = false;
                    btnUpdate.Enabled = true;
                    btnDelete.Enabled = true;
                }
            }
            catch { }
        }

        // --- CÁC NÚT CRUD ---
        private async void BtnAdd_Click(object sender, EventArgs e)
        {
            var req = GetFormData();
            var res = await _http.PostAsJsonAsync("api/admin/universities", req);
            if (res.IsSuccessStatusCode)
            {
                MessageBox.Show("Thêm trường thành công!");
                await LoadData();
                ClearForm();
            }
            else MessageBox.Show("Lỗi: " + await res.Content.ReadAsStringAsync());
        }

        private async void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (_selectedId == 0) return;
            var req = GetFormData();
            var res = await _http.PutAsJsonAsync($"api/admin/universities/{_selectedId}", req);
            if (res.IsSuccessStatusCode)
            {
                MessageBox.Show("Cập nhật thành công!");
                await LoadData();
                ClearForm();
            }
        }

        private async void BtnDelete_Click(object sender, EventArgs e)
        {
            if (_selectedId == 0) return;
            if (MessageBox.Show("Bạn có chắc muốn xóa trường này?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                var res = await _http.DeleteAsync($"api/admin/universities/{_selectedId}");
                if (res.IsSuccessStatusCode)
                {
                    MessageBox.Show("Đã xóa!");
                    await LoadData();
                    ClearForm();
                }
                else MessageBox.Show("Lỗi: " + await res.Content.ReadAsStringAsync());
            }
        }

        // Helpers
        private UniversityDto GetFormData()
        {
            return new UniversityDto
            {
                Code = txtCode.Text,
                Name = txtName.Text,
                Region = cbRegion.Text,
                Address = txtAddress.Text,
                Website = txtWebsite.Text,
                LogoUrl = txtLogo.Text,
                Description = txtDesc.Text
            };
        }

        private void ClearForm()
        {
            _selectedId = 0;
            txtCode.Clear(); txtName.Clear(); txtAddress.Clear();
            txtWebsite.Clear(); txtLogo.Clear(); txtDesc.Clear();
            cbRegion.SelectedIndex = -1;

            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }
    }
}