using System.Net.Http.Headers;
using System.Net.Http.Json;
using UniGate.Shared.DTOs;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static UniGate.Admin.Program;

namespace UniGate.Admin.UserControls;

public partial class UcScoreDistribution : UserControl
{
    private readonly HttpClient _http = GlobalConfig.GetClient();
    private int _selectedId = -1;

    public UcScoreDistribution()
    {
        InitializeComponent();
        this.Load += UcScoreDistribution_Load;

        // 👇 THIẾU DÒNG NÀY NÈ TRÍ (Quan trọng nhất để click bảng)
        dgvScores.CellClick += DgvScores_CellClick;

        // Đăng ký nút bấm (cho chắc ăn, lỡ designer chưa gắn)
        btnAdd.Click += btnAdd_Click;
        btnEdit.Click += btnEdit_Click;
        btnDelete.Click += btnDelete_Click;
        btnClear.Click += btnClear_Click;

        // Cấu hình mặc định
        numScore.DecimalPlaces = 2; // Cho phép nhập 20.25
        numScore.Increment = 0.25M; // Mỗi lần bấm lên xuống là nhảy 0.25 điểm
    }

    private async void UcScoreDistribution_Load(object? sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(AdminSession.Token))
            _http.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", AdminSession.Token);
        await LoadData();
    }

    private async Task LoadData()
    {
        try
        {
            var list = await _http.GetFromJsonAsync<List<ScoreDistributionDto>>("api/admin/scores");
            dgvScores.DataSource = list;
            if (dgvScores.Columns["Id"] != null) dgvScores.Columns["Id"].Visible = false;
        }
        catch { }
    }

    private void DgvScores_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) return;
        try
        {
            var row = dgvScores.Rows[e.RowIndex];
            var item = row.DataBoundItem as ScoreDistributionDto; // <-- Dùng cái này

            if (item != null)
            {
                _selectedId = item.Id; // DTO phải có Id nha
                txtGroup.Text = item.GroupCode;
                numScore.Value = item.Score;
                numCount.Value = item.StudentCount;
            }
        }
        catch { }
    }



    // --- BUTTONS ---
    private async void btnAdd_Click(object sender, EventArgs e)
    {
        var dto = GetFormData();
        var res = await _http.PostAsJsonAsync("api/admin/scores", dto);

        if (res.IsSuccessStatusCode) { MessageBox.Show("Thêm xong!"); await LoadData(); }
        else MessageBox.Show("Lỗi: " + await res.Content.ReadAsStringAsync());
    }

    private async void btnEdit_Click(object sender, EventArgs e)
    {
        if (_selectedId == -1) return;
        var dto = GetFormData();
        var res = await _http.PutAsJsonAsync($"api/admin/scores/{_selectedId}", dto);
        if (res.IsSuccessStatusCode) { MessageBox.Show("Sửa xong!"); await LoadData(); }
    }

    private async void btnDelete_Click(object sender, EventArgs e)
    {
        if (_selectedId == -1) return;
        if (MessageBox.Show("Xóa dòng này?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
        {
            var res = await _http.DeleteAsync($"api/admin/scores/{_selectedId}");
            if (res.IsSuccessStatusCode) await LoadData();
        }
    }

    private void btnClear_Click(object sender, EventArgs e)
    {
        _selectedId = -1;
        txtGroup.Text = "";
        numScore.Value = 0;
        numCount.Value = 0;
    }

    private ScoreDistributionDto GetFormData() => new ScoreDistributionDto
    {
        GroupCode = txtGroup.Text.ToUpper(),
        Score = numScore.Value,
        StudentCount = (int)numCount.Value
    };
}