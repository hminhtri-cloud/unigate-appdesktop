using System.Net.Http.Headers;
using System.Net.Http.Json;
using UniGate.Shared.DTOs;
using Guna.UI2.WinForms; // Thêm dòng này
using static UniGate.Student.Program;



namespace UniGate.Student.UserControls
{
    public partial class UcProfile : UserControl
    {
        private readonly HttpClient _http = GlobalConfig.GetClient();
        public UcProfile()
        {
            InitializeComponent();
            InitComboBoxData();

            // Gắn sự kiện Load và Click bằng code (vì mình viết Designer tay)
            this.Load += UcProfile_Load;
            this.btnSave.Click += btnSave_Click;
            this.cbMon1.SelectedIndexChanged += cbMon_SelectedIndexChanged;
            this.cbMon2.SelectedIndexChanged += cbMon_SelectedIndexChanged;
        }

        private void InitComboBoxData()
        {
            string[] cacMon = { "Vật lý", "Hóa học", "Sinh học", "Lịch sử", "Địa lý", "GD KT&PL", "Tin học", "Công nghệ", "Tiếng Anh" };
            cbMon1.Items.AddRange(cacMon);
            cbMon2.Items.AddRange(cacMon);
            cbKhuVuc.Items.AddRange(new[] { "KV1", "KV2-NT", "KV2", "KV3" });
            cbDoiTuong.Items.AddRange(new[] { "ƯT1", "ƯT2", "BT" });
        }

        private async void UcProfile_Load(object? sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(UserSession.Token)) return;

            try
            {
                _http.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", UserSession.Token);
                var response = await _http.GetAsync("api/UserScores/my-score");
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadFromJsonAsync<UserScoreRequest>();
                    if (result != null) FillDataToUI(result);
                }
            }
            catch { }
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

            // ComboBox của Guna gán Text trực tiếp được (nếu item có trong list)
            if (!string.IsNullOrEmpty(res.Thpt_TuChon1_Mon)) cbMon1.SelectedItem = res.Thpt_TuChon1_Mon;
            txtDiem1.Text = res.Thpt_TuChon1_Diem?.ToString();

            if (!string.IsNullOrEmpty(res.Thpt_TuChon2_Mon)) cbMon2.SelectedItem = res.Thpt_TuChon2_Mon;
            txtDiem2.Text = res.Thpt_TuChon2_Diem?.ToString();

            txtDgnl.Text = res.Dgnl_Score?.ToString();

            if (!string.IsNullOrEmpty(res.KhuVuc)) cbKhuVuc.SelectedItem = res.KhuVuc;
            if (!string.IsNullOrEmpty(res.DoiTuong)) cbDoiTuong.SelectedItem = res.DoiTuong;
        }

        private async void btnSave_Click(object? sender, EventArgs e)
        {
            btnSave.Enabled = false;
            btnSave.Text = "Đang lưu...";

            var req = new UserScoreRequest
            {
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

            try
            {
                var res = await _http.PostAsJsonAsync("api/UserScores/save", req);
                if (res.IsSuccessStatusCode)
                    MessageBox.Show("Lưu điểm thành công! Hãy quay lại Dashboard để xem kết quả.", "Thành công");
                else
                    MessageBox.Show("Lỗi Server: " + await res.Content.ReadAsStringAsync());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message);
            }

            btnSave.Enabled = true;
            btnSave.Text = "LƯU HỒ SƠ ĐIỂM SỐ";
        }

        // Sửa hàm GetVal nhận vào Guna2TextBox
        private decimal? GetVal(Guna2TextBox t) => decimal.TryParse(t.Text, out var d) ? d : null;

        private void cbMon_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (cbMon1.Text == cbMon2.Text && !string.IsNullOrEmpty(cbMon1.Text))
            {
                MessageBox.Show("Hai môn tự chọn không được giống nhau!");
                ((Guna2ComboBox)sender).SelectedIndex = -1;
            }
        }
    }
}