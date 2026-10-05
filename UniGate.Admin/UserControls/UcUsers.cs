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
    public partial class UcUsers : UserControl
    {
        private readonly HttpClient _http = GlobalConfig.GetClient();
        private int _selectedId = 0;

        public UcUsers()
        {
            InitializeComponent();
            dgvUsers.AutoGenerateColumns = false;

            this.Load += async (s, e) => await LoadData();
            dgvUsers.CellClick += DgvUsers_CellClick;

            btnAdd.Click += BtnAdd_Click;
            btnUpdate.Click += BtnUpdate_Click;
            btnDelete.Click += BtnDelete_Click;
            btnClear.Click += (s, e) => ClearForm();
        }

        private async Task LoadData()
        {
            try
            {
                var list = await _http.GetFromJsonAsync<List<UserDto>>("api/admin/users");
                dgvUsers.DataSource = list;
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
        }

        private void DgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            try
            {
                var row = dgvUsers.Rows[e.RowIndex];
                var item = row.DataBoundItem as UserDto;

                if (item != null)
                {
                    _selectedId = item.Id;
                    txtEmail.Text = item.Email;
                    txtFullName.Text = item.FullName;
                    cbRole.SelectedItem = item.Role;
                    cbRegion.SelectedItem = item.Region;

                    // QUAN TRỌNG: Không hiển thị mật khẩu cũ
                    txtPassword.Text = "";
                    txtPassword.PlaceholderText = "(Để trống nếu không đổi)";

                    // Không cho sửa Email (thường là định danh)
                    txtEmail.Enabled = false;

                    btnAdd.Enabled = false;
                    btnUpdate.Enabled = true;
                    btnDelete.Enabled = true;
                }
            }
            catch { }
        }

        private async void BtnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text)) { MessageBox.Show("Phải nhập mật khẩu cho user mới!"); return; }

            var req = GetFormData();
            var res = await _http.PostAsJsonAsync("api/admin/users", req);

            if (res.IsSuccessStatusCode) { MessageBox.Show("Thêm thành công!"); await LoadData(); ClearForm(); }
            else MessageBox.Show("Lỗi: " + await res.Content.ReadAsStringAsync());
        }

        private async void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (_selectedId == 0) return;
            var req = GetFormData();
            var res = await _http.PutAsJsonAsync($"api/admin/users/{_selectedId}", req);

            if (res.IsSuccessStatusCode) { MessageBox.Show("Cập nhật thành công!"); await LoadData(); ClearForm(); }
        }

        private async void BtnDelete_Click(object sender, EventArgs e)
        {
            if (_selectedId == 0) return;
            if (MessageBox.Show("Xóa user này?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var res = await _http.DeleteAsync($"api/admin/users/{_selectedId}");
                if (res.IsSuccessStatusCode) { MessageBox.Show("Đã xóa!"); await LoadData(); ClearForm(); }
            }
        }

        private UserDto GetFormData()
        {
            return new UserDto
            {
                Email = txtEmail.Text,
                FullName = txtFullName.Text,
                Password = txtPassword.Text, // Server sẽ check: nếu rỗng -> không đổi pass
                Role = cbRole.Text,
                Region = cbRegion.Text
            };
        }

        private void ClearForm()
        {
            _selectedId = 0;
            txtEmail.Clear(); txtEmail.Enabled = true;
            txtFullName.Clear();
            txtPassword.Clear(); txtPassword.PlaceholderText = "";
            cbRole.SelectedIndex = 0;

            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }
    }
}