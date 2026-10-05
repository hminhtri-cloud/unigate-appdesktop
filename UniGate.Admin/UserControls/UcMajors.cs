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
    public partial class UcMajors : UserControl
    {
        private readonly HttpClient _http = GlobalConfig.GetClient();
        private int _selectedId = 0;

        public UcMajors()
        {
            InitializeComponent();

            dgvMajors.AutoGenerateColumns = false;

            Load += async (_, __) => await LoadDataAsync();
            dgvMajors.CellClick += DgvMajors_CellClick;
            btnClear.Click += BtnClear_Click;
        }

        // ================= LOAD DATA =================
        private async Task LoadDataAsync()
        {
            try
            {
                // 1. GẮN TOKEN VÀO HEADER (Thêm đoạn này)
                _http.DefaultRequestHeaders.Authorization =
                    new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", AdminSession.Token);

                // 2. Gọi API Majors
                var majors = await _http.GetFromJsonAsync<List<MajorDetailDto>>("api/admin/majors");
                dgvMajors.DataSource = majors;

                // 3. Gọi API Universities (Giờ đã có Controller nên sẽ chạy ngon)
                var unis = await _http.GetFromJsonAsync<List<UniversityDto>>("api/Universities");

                cbUniversity.DataSource = unis;
                cbUniversity.DisplayMember = "Name";
                cbUniversity.ValueMember = "Id";

                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu:\n" + ex.Message);
            }
        }

        // ================= GRID CLICK =================
        private void DgvMajors_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var item = dgvMajors.Rows[e.RowIndex].DataBoundItem as MajorDetailDto;
            if (item == null) return;

            _selectedId = item.Id;

            txtMajorName.Text = item.MajorName;
            txtCode.Text = item.MajorCode;
            txtGroup.Text = item.GroupCode;
            txtHolland.Text = item.HollandCode;
            txtDesc.Text = item.Description;

            numScore.Value = Math.Min(item.CutoffScore, numTuition.Maximum);

            numTuition.Value = Math.Min(item.Tuition, numTuition.Maximum);


            if (item.CutoffScore <= numScore.Maximum && item.CutoffScore >= numScore.Minimum)
            {
                numScore.Value = item.CutoffScore;
            }
            else
            {
                numScore.Value = 0; // Hoặc giá trị mặc định an toàn
            }

            // Tương tự với Tuition
            if (item.Tuition <= numTuition.Maximum && item.Tuition >= numTuition.Minimum)
            {
                numTuition.Value = item.Tuition;
            }

            // Set ComboBox an toàn hơn
            if (cbUniversity.Items.Count > 0)
            {
                cbUniversity.SelectedValue = item.UniversityId;
            }

            btnAdd.Enabled = false;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
        }

        // ================= ADD =================
        private async void BtnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateForm()) return;

            try
            {
                var res = await _http.PostAsJsonAsync("api/admin/majors", GetFormData());
                if (res.IsSuccessStatusCode)
                {
                    MessageBox.Show("Thêm thành công!");
                    await LoadDataAsync();
                }
                else
                    MessageBox.Show(await res.Content.ReadAsStringAsync());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // ================= UPDATE =================
        private async void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (_selectedId == 0 || !ValidateForm()) return;

            try
            {
                var res = await _http.PutAsJsonAsync(
                    $"api/admin/majors/{_selectedId}", GetFormData());

                if (res.IsSuccessStatusCode)
                {
                    MessageBox.Show("Cập nhật thành công!");
                    await LoadDataAsync();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // ================= DELETE =================
        private async void BtnDelete_Click(object sender, EventArgs e)
        {
            if (_selectedId == 0) return;

            if (MessageBox.Show("Chắc chắn xóa?", "Xác nhận",
                MessageBoxButtons.YesNo) != DialogResult.Yes) return;

            try
            {
                var res = await _http.DeleteAsync($"api/admin/majors/{_selectedId}");
                if (res.IsSuccessStatusCode)
                {
                    MessageBox.Show("Đã xóa!");
                    await LoadDataAsync();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // ================= CLEAR =================
        private void BtnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            _selectedId = 0;

            txtMajorName.Clear();
            txtCode.Clear();
            txtGroup.Clear();
            txtHolland.Clear();
            txtDesc.Clear();

            numScore.Value = 0;
            numTuition.Value = 0;

            if (cbUniversity.Items.Count > 0)
                cbUniversity.SelectedIndex = 0;

            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        // ================= HELPERS =================
        private MajorDetailDto GetFormData()
        {
            return new MajorDetailDto
            {
                MajorName = txtMajorName.Text.Trim(),
                MajorCode = txtCode.Text.Trim(),
                GroupCode = txtGroup.Text.Trim(),
                HollandCode = txtHolland.Text.Trim(),
                Description = txtDesc.Text.Trim(),
                CutoffScore =  numScore.Value,
                Tuition = numTuition.Value,
                UniversityId = (int)cbUniversity.SelectedValue
            };
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(txtMajorName.Text))
            {
                MessageBox.Show("Tên ngành không được để trống");
                return false;
            }
            return true;
        }
    }
}
