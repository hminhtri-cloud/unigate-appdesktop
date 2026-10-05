using Guna.UI2.WinForms;            // Để dùng Guna UI
using System.Net.Http.Headers;
using System.Net.Http.Json;
using UniGate.Shared.DTOs;          // Dùng DTO m vừa tạo
using UniGate.Student.myForm;       // Để gọi Form kết quả
using static UniGate.Student.Program;


namespace UniGate.Student.UserControls
{


    public partial class UcHolland : UserControl
    {
        // Kết nối API (Port 7030)
        private readonly HttpClient _http = GlobalConfig.GetClient();


        // Danh sách câu hỏi và biến đếm
        private List<HollandQuestionDto> _questions = new();
        private int _currentIndex = 0;

        // Lưu điểm 6 nhóm: R, I, A, S, E, C
        private Dictionary<string, int> _groupScores = new() {
            { "R", 0 }, { "I", 0 }, { "A", 0 }, { "S", 0 }, { "E", 0 }, { "C", 0 }
        };

        // Lưu lịch sử trả lời để tính toán khi bấm nút "Quay lại"
        // Key: Index câu hỏi, Value: Điểm đã chọn (1-5)
        private Dictionary<int, int> _userAnswers = new();

        public UcHolland()
        {
            InitializeComponent();

            // Gắn sự kiện (Event)
            this.Load += UcHolland_Load;

            // Gắn sự kiện cho 5 nút đánh giá
            this.btn1.Click += (s, e) => OnAnswerClick(1);
            this.btn2.Click += (s, e) => OnAnswerClick(2);
            this.btn3.Click += (s, e) => OnAnswerClick(3);
            this.btn4.Click += (s, e) => OnAnswerClick(4);
            this.btn5.Click += (s, e) => OnAnswerClick(5);

            // Nút quay lại
            this.btnPrev.Click += btnPrev_Click;
        }

        // --- 1. LOAD CÂU HỎI TỪ SERVER ---
        private async void UcHolland_Load(object? sender, EventArgs e)
        {
            try
            {
                // Kiểm tra Token
                if (!string.IsNullOrEmpty(UserSession.Token))
                    _http.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", UserSession.Token);

                // Gọi API lấy câu hỏi (Lưu ý: API này m đã viết bên HollandController)
                var result = await _http.GetFromJsonAsync<List<HollandQuestionDto>>("api/Holland/questions");

                if (result != null && result.Count > 0)
                {
                    _questions = result;
                    ShowQuestion(); // Hiển thị câu đầu tiên
                }
                else
                {
                    lblContent.Text = "Hệ thống chưa có câu hỏi nào. Vui lòng quay lại sau!";
                    DisableButtons();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không tải được câu hỏi: " + ex.Message);
                DisableButtons();
            }
        }

        // --- 2. HIỂN THỊ CÂU HỎI ---
        private void ShowQuestion()
        {
            if (_questions.Count == 0) return;

            var q = _questions[_currentIndex];

            // Cập nhật giao diện
            lblQuestionNumber.Text = $"Câu hỏi: {_currentIndex + 1} / {_questions.Count}";
            lblContent.Text = q.Content;

            // Thanh tiến độ
            pbProgress.Maximum = _questions.Count;
            pbProgress.Value = _currentIndex + 1;

            // Nút Back chỉ hiện khi không phải câu 1
            btnPrev.Enabled = _currentIndex > 0;
        }

        // --- 3. XỬ LÝ TRẢ LỜI (CORE LOGIC) ---
        private void OnAnswerClick(int score)
        {
            // Lấy nhóm của câu hỏi hiện tại (VD: R, I, A...)
            // Lưu ý: DTO của m dùng 'Group', ko phải 'GroupCode' -> Khớp rồi nhé
            string currentGroup = _questions[_currentIndex].Group;

            // Nếu câu này đã trả lời rồi (do quay lại), thì trừ điểm cũ đi trước khi cộng điểm mới
            if (_userAnswers.ContainsKey(_currentIndex))
            {
                int oldScore = _userAnswers[_currentIndex];
                _groupScores[currentGroup] -= oldScore;
            }

            // Lưu câu trả lời mới
            _userAnswers[_currentIndex] = score;
            _groupScores[currentGroup] += score;

            // Chuyển sang câu tiếp theo
            if (_currentIndex < _questions.Count - 1)
            {
                _currentIndex++;
                ShowQuestion();
            }
            else
            {
                // Nếu là câu cuối cùng -> Nộp bài
                ConfirmSubmit();
            }
        }

        // --- 4. XỬ LÝ NÚT QUAY LẠI ---
        private void btnPrev_Click(object? sender, EventArgs e)
        {
            if (_currentIndex > 0)
            {
                _currentIndex--;
                ShowQuestion();
            }
        }

        // --- 5. NỘP BÀI ---
        private async void ConfirmSubmit()
        {
            var confirm = MessageBox.Show("Bạn đã hoàn thành bài test. Xem kết quả ngay?",
                                          "Hoàn thành", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (confirm == DialogResult.Yes)
            {
                await SubmitResultAsync();
            }
        }

        private async Task SubmitResultAsync()
        {
            try
            {
                var req = new HollandAnswerRequest { GroupScores = _groupScores };
                var response = await _http.PostAsJsonAsync("api/Holland/submit", req);

                if (response.IsSuccessStatusCode)
                {
                    var resultDto = await response.Content.ReadFromJsonAsync<HollandResultDto>();

                    if (resultDto != null && this.ParentForm is FormMain mainForm)
                    {
                        // Thay vì hiện MessageBox, m đẩy thẳng sang UcHollandResult kèm dữ liệu luôn
                        // Truyền resultDto vào để UcHollandResult nó có cái mà hiển thị
                        mainForm.ShowView(new UcHollandResult(resultDto), mainForm.GetBtnHollandResult(), "Kết quả của bạn");
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        // --- CÁC HÀM PHỤ TRỢ ---

        private void ResetTest()
        {
            _currentIndex = 0;
            // Reset điểm về 0
            _groupScores = new Dictionary<string, int> { { "R", 0 }, { "I", 0 }, { "A", 0 }, { "S", 0 }, { "E", 0 }, { "C", 0 } };
            _userAnswers.Clear();

            ShowQuestion();
            EnableButtons();
        }

        private void DisableButtons()
        {
            btn1.Enabled = btn2.Enabled = btn3.Enabled = btn4.Enabled = btn5.Enabled = false;
        }

        private void EnableButtons()
        {
            btn1.Enabled = btn2.Enabled = btn3.Enabled = btn4.Enabled = btn5.Enabled = true;
        }
    }
}