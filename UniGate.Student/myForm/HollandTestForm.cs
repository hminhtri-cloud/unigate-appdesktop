using System.Net.Http.Headers;
using System.Net.Http.Json;
using UniGate.Shared;
using UniGate.Student.Services;

namespace UniGate.Student.myForm;

public partial class HollandTestForm : Form
{
    private readonly HttpClient _http = new() { BaseAddress = new Uri("https://localhost:7030/") };
    private List<UniGate.Shared.DTOs.HollandQuestionDto> _questions = new();
    private int _currentIndex = 0;

    // Lưu trữ điểm theo 6 nhóm RIASEC
    private Dictionary<string, int> _groupScores = new() {
        { "R", 0 }, { "I", 0 }, { "A", 0 }, { "S", 0 }, { "E", 0 }, { "C", 0 }
    };

    // Lưu câu trả lời của từng câu để có thể quay lại (Back)
    private Dictionary<int, int> _userAnswers = new();

    public HollandTestForm()
    {
        InitializeComponent();
        this.Load += HollandTestForm_Load;
    }

    private async void HollandTestForm_Load(object sender, EventArgs e)
    {
        try
        {
            // Mục 4: Xử lý bất đồng bộ để không treo UI
            _questions = await _http.GetFromJsonAsync<List<UniGate.Shared.DTOs.HollandQuestionDto>>("api/Holland/questions")
                         ?? new List<UniGate.Shared.DTOs.HollandQuestionDto>();

            if (_questions.Count > 0)
            {
                ShowQuestion();
            }
        }
        catch (Exception)
        {
            MessageBox.Show("Không thể tải bộ câu hỏi. Vui lòng kiểm tra Load Balancer!");
        }
    }

    private void ShowQuestion()
    {
        var q = _questions[_currentIndex];
        lblQuestionNumber.Text = $"Câu hỏi: {_currentIndex + 1} / {_questions.Count}";
        lblContent.Text = q.Content;
        pbProgress.Value = _currentIndex + 1;

        // Chỉ cho phép "Quay lại" nếu không phải câu đầu tiên
        btnPrev.Enabled = _currentIndex > 0;
    }

    // Hàm dùng chung cho các nút bấm 1, 2, 3, 4, 5
    private void OnAnswerClick(int score)
    {
        string currentGroup = _questions[_currentIndex].Group;

        // Nếu đã trả lời rồi mà quay lại sửa, thì trừ điểm cũ đi trước
        if (_userAnswers.ContainsKey(_currentIndex))
        {
            _groupScores[currentGroup] -= _userAnswers[_currentIndex];
        }

        // Lưu câu trả lời mới
        _userAnswers[_currentIndex] = score;
        _groupScores[currentGroup] += score;

        // Chuyển câu hoặc nộp bài
        if (_currentIndex < _questions.Count - 1)
        {
            _currentIndex++;
            ShowQuestion();
        }
        else
        {
            ConfirmSubmit();
        }
    }

    private async void ConfirmSubmit()
    {
        var confirm = MessageBox.Show("Bạn đã hoàn thành 60 câu. Nộp bài để xem kết quả?", "Xác nhận", MessageBoxButtons.YesNo);
        if (confirm == DialogResult.Yes)
        {
            await SubmitResultAsync();
        }
    }

    private async Task SubmitResultAsync()
    {
        // Mục 8: Gửi Token bảo mật
        if (!string.IsNullOrEmpty(UserSession.Token))
        {
            _http.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", UserSession.Token);
        }

        var req = new UniGate.Shared.DTOs.HollandAnswerRequest { GroupScores = _groupScores };
        var res = await _http.PostAsJsonAsync("api/Holland/submit", req);

        if (res.IsSuccessStatusCode)
        {
            var result = await res.Content.ReadFromJsonAsync<UniGate.Shared.DTOs.HollandResultDto>();

            // Thay vì MessageBox, mình hiện Form kết quả lung linh luôn
            FormHollandResult frm = new FormHollandResult(result!);
            frm.ShowDialog();

            this.Close(); // Đóng form làm bài
        }
    }

    // Sự kiện nút bấm (Anh gán các nút btn1->btn5 vào đây)
    private void btn1_Click(object sender, EventArgs e) => OnAnswerClick(1);
    private void btn2_Click(object sender, EventArgs e) => OnAnswerClick(2);
    private void btn3_Click(object sender, EventArgs e) => OnAnswerClick(3);
    private void btn4_Click(object sender, EventArgs e) => OnAnswerClick(4);
    private void btn5_Click(object sender, EventArgs e) => OnAnswerClick(5);

    private void btnPrev_Click(object sender, EventArgs e)
    {
        if (_currentIndex > 0)
        {
            _currentIndex--;
            ShowQuestion();
        }
    }
}