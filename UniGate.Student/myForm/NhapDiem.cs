using System.Net.Http.Headers;
using System.Net.Http.Json;
using UniGate.Shared.DTOs;

namespace UniGate.Student.myForm;

public partial class NhapDiem : Form
{
    // Cổng Load Balancer 7030 kết nối sang máy Mac của anh
    private readonly HttpClient _http = new() { BaseAddress = new Uri("https://localhost:7030/") };

    public NhapDiem()
    {
        InitializeComponent();
        InitComboBoxData();

    }

    private void InitComboBoxData()
    {
        string[] cacMon = { "Vật lý", "Hóa học", "Sinh học", "Lịch sử", "Địa lý", "GD KT&PL", "Tin học", "Công nghệ", "Tiếng Anh" };
        cbMon1.Items.AddRange(cacMon);
        cbMon2.Items.AddRange(cacMon);
        cbKhuVuc.Items.AddRange(new[] { "KV1", "KV2-NT", "KV2", "KV3" });
        cbDoiTuong.Items.AddRange(new[] { "ƯT1", "ƯT2", "BT" });
    }

    // --- PHẦN 1: LẤY DỮ LIỆU CŨ KHI MỞ FORM (MỤC 5: STATE) ---
    private async void FormNhapDiem_Load(object sender, EventArgs e)
    {
        this.Text = "Đang tải dữ liệu...";
        try
        {
            if (!string.IsNullOrEmpty(UserSession.Token))
                _http.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", UserSession.Token);

            var response = await _http.GetAsync("api/UserScores/my-score");
            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadFromJsonAsync<UserScoreRequest>();
                if (result != null) FillDataToUI(result);
            }
        }
        catch { /* Nếu lỗi thì cho nhập mới */ }
        this.Text = "Nhập điểm xét tuyển UniGate 2025";
    }

    private void FillDataToUI(UserScoreRequest res)
    {
        // Điền 10 môn học bạ
        txtHB_Toan.Text = res.HB_Toan?.ToString(); txtHB_Van.Text = res.HB_Van?.ToString();
        txtHB_Anh.Text = res.HB_Anh?.ToString(); txtHB_Ly.Text = res.HB_Ly?.ToString();
        txtHB_Hoa.Text = res.HB_Hoa?.ToString(); txtHB_Sinh.Text = res.HB_Sinh?.ToString();
        txtHB_Su.Text = res.HB_Su?.ToString(); txtHB_Dia.Text = res.HB_Dia?.ToString();
        txtHB_GDKTPL.Text = res.HB_GDKTPL?.ToString(); txtHB_TinHoc.Text = res.HB_TinHoc?.ToString();

        // Điền điểm THPT
        txtThptToan.Text = res.Thpt_Toan?.ToString();
        txtThptVan.Text = res.Thpt_Van?.ToString();
        cbMon1.Text = res.Thpt_TuChon1_Mon; txtDiem1.Text = res.Thpt_TuChon1_Diem?.ToString();
        cbMon2.Text = res.Thpt_TuChon2_Mon; txtDiem2.Text = res.Thpt_TuChon2_Diem?.ToString();

        txtDgnl.Text = res.Dgnl_Score?.ToString();
        cbKhuVuc.Text = res.KhuVuc; cbDoiTuong.Text = res.DoiTuong;
    }

    // --- PHẦN 2: LƯU DỮ LIỆU (MỤC 3: DATABASE & MỤC 4: ASYNC) ---
    private async void btnSave_Click(object sender, EventArgs e)
    {
        btnSave.Enabled = false; // Chống bấm nhiều lần

        var req = new UserScoreRequest
        {
            // Gom 10 môn Học bạ
            HB_Toan = GetVal(txtHB_Toan),
            HB_Van = GetVal(txtHB_Van),
            HB_Anh = GetVal(txtHB_Anh),
            HB_Ly = GetVal(txtHB_Ly),
            HB_Hoa = GetVal(txtHB_Hoa),
            HB_Sinh = GetVal(txtHB_Sinh),
            HB_Su = GetVal(txtHB_Su),
            HB_Dia = GetVal(txtHB_Dia),
            HB_GDKTPL = GetVal(txtHB_GDKTPL),
            HB_TinHoc = GetVal(txtHB_TinHoc),

            // TNTHPT 2+2
            Thpt_Toan = GetVal(txtThptToan),
            Thpt_Van = GetVal(txtThptVan),
            Thpt_TuChon1_Mon = cbMon1.Text,
            Thpt_TuChon1_Diem = GetVal(txtDiem1),
            Thpt_TuChon2_Mon = cbMon2.Text,
            Thpt_TuChon2_Diem = GetVal(txtDiem2),

            Dgnl_Score = GetVal(txtDgnl),
            KhuVuc = cbKhuVuc.Text,
            DoiTuong = cbDoiTuong.Text
        };

        var res = await _http.PostAsJsonAsync("api/UserScores/save", req);
        if (res.IsSuccessStatusCode)
            MessageBox.Show("Anh Trí ơi, điểm đã lưu vào MySQL trên Mac thành công!", "Thông báo");
        else
            MessageBox.Show("Có lỗi khi lưu điểm.");

        btnSave.Enabled = true;
    }

    // Hàm phụ chuyển Text sang Decimal (tránh lỗi nếu để trống)
    private decimal? GetVal(TextBox t) => decimal.TryParse(t.Text, out var d) ? d : null;

    // Chặn chọn trùng môn tự chọn
    private void cbMon_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (cbMon1.Text == cbMon2.Text && !string.IsNullOrEmpty(cbMon1.Text))
        {
            MessageBox.Show("Hai môn tự chọn không được giống nhau!");
            ((ComboBox)sender).SelectedIndex = -1;
        }
    }
}