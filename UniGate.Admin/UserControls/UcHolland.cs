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
    public partial class UcHollandQuestions : UserControl
    {
        private readonly HttpClient _http = GlobalConfig.GetClient();
        private int _selectedId = 0;

        public UcHollandQuestions()
        {
            InitializeComponent();

            // Cấu hình Grid
            dgvQuestions.AutoGenerateColumns = false;

            // Sự kiện
            this.Load += async (s, e) => await LoadData();
            dgvQuestions.CellClick += DgvQuestions_CellClick;

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
                var list = await _http.GetFromJsonAsync<List<HollandQuestionDto>>("api/admin/holland-questions");
                dgvQuestions.DataSource = list;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }
        }

        private void DgvQuestions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            try
            {
                var row = dgvQuestions.Rows[e.RowIndex];
                var item = row.DataBoundItem as HollandQuestionDto;

                if (item != null)
                {
                    _selectedId = item.Id;
                    txtContent.Text = item.Content;
                    cbGroup.SelectedItem = item.Group; // Tự động chọn đúng nhóm trong ComboBox

                    btnAdd.Enabled = false;
                    btnUpdate.Enabled = true;
                    btnDelete.Enabled = true;
                }
            }
            catch { }
        }

        private async void BtnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtContent.Text)) { MessageBox.Show("Chưa nhập nội dung!"); return; }
            if (cbGroup.SelectedIndex < 0) { MessageBox.Show("Chưa chọn nhóm!"); return; }

            var req = GetFormData();
            var res = await _http.PostAsJsonAsync("api/admin/holland-questions", req);

            if (res.IsSuccessStatusCode)
            {
                MessageBox.Show("Thêm thành công!");
                await LoadData();
                ClearForm();
            }
            else MessageBox.Show("Lỗi: " + await res.Content.ReadAsStringAsync());
        }

        private async void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (_selectedId == 0) return;
            var req = GetFormData();
            var res = await _http.PutAsJsonAsync($"api/admin/holland-questions/{_selectedId}", req);

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
            if (MessageBox.Show("Xóa câu hỏi này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var res = await _http.DeleteAsync($"api/admin/holland-questions/{_selectedId}");
                if (res.IsSuccessStatusCode)
                {
                    MessageBox.Show("Đã xóa!");
                    await LoadData();
                    ClearForm();
                }
            }
        }

        private HollandQuestionDto GetFormData()
        {
            return new HollandQuestionDto
            {
                Content = txtContent.Text,
                Group = cbGroup.SelectedItem.ToString() // Lấy giá trị từ ComboBox (R, I, A...)
            };
        }

        private void ClearForm()
        {
            _selectedId = 0;
            txtContent.Clear();
            cbGroup.SelectedIndex = 0; // Mặc định về R

            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }
    }
}