using Guna.UI2.WinForms;
using System.Drawing.Drawing2D; // Thư viện để vẽ Avatar
using System.Net.Http.Headers;
using System.Net.Http.Json;
using UniGate.Shared.DTOs;
using static UniGate.Student.Program;


namespace UniGate.Student.UserControls
{
    public partial class UcSettings : UserControl
    {
        // Kết nối API
        private readonly HttpClient _http = GlobalConfig.GetClient();

        public UcSettings()
        {
            InitializeComponent();

            // Đăng ký các sự kiện
            this.Load += UcSettings_Load;
            this.btnLogout.Click += BtnLogout_Click;
        }

        private void UcSettings_Load(object? sender, EventArgs e)
        {
            // 1. Hiển thị thông tin cá nhân từ UserSession
            txtFullName.Text = UserSession.FullName;
            txtEmail.Text = UserSession.UserName; // Đã thêm ở bước trước

            // 2. Tự động vẽ Avatar dựa trên tên
            // Nếu tên trống thì vẽ dấu hỏi (?)
            picAvatar.Image = GenerateAvatar(UserSession.FullName);
        }

        // --- TÍNH NĂNG 1: VẼ AVATAR TỰ ĐỘNG ---
        private Bitmap GenerateAvatar(string name)
        {
            // Lấy chữ cái đầu tiên (VD: "Trí" -> "T")
            string letter = string.IsNullOrEmpty(name) ? "?" : name.Trim().Substring(0, 1).ToUpper();

            // Tạo một hình ảnh vuông 200x200 pixel
            var bmp = new Bitmap(200, 200);

            using (var g = Graphics.FromImage(bmp))
            {
                // Bật chế độ làm mượt (Anti-Alias) để hình không bị răng cưa
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;

                // 1. Tô nền hình tròn màu xanh Sky Blue
                var brush = new SolidBrush(Color.FromArgb(14, 165, 233));
                g.FillEllipse(brush, 0, 0, 200, 200); // Vẽ hình tròn full khung

                // 2. Cấu hình Font chữ (Segoe UI, Đậm, Cỡ 80)
                var font = new Font("Segoe UI", 80, FontStyle.Bold);

                // 3. Đo kích thước chữ để căn giữa
                var textSize = g.MeasureString(letter, font);
                float x = (200 - textSize.Width) / 2;
                float y = (200 - textSize.Height) / 2;

                // 4. Vẽ chữ màu trắng lên giữa hình tròn
                g.DrawString(letter, font, Brushes.White, x, y);
            }

            return bmp;
        }

        // --- TÍNH NĂNG 2: ĐỔI MẬT KHẨU ---
        

        // --- TÍNH NĂNG 3: ĐĂNG XUẤT ---
        private void BtnLogout_Click(object? sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất khỏi UniGate?",
                                          "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                PerformLogout();
            }
        }

        private void PerformLogout()
        {
            // 1. Xóa sạch thông tin trong Session
            UserSession.Logout();

            // 2. Khởi động lại ứng dụng (Tự động về màn hình Login)
            Application.Restart();
        }
    }
}