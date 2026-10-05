using Guna.UI2.WinForms;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using UniGate.Shared.DTOs;
using UniGate.Student.UserControls; // Namespace chứa các UserControl
using System.Net.Http.Json; // 👈 Thủ phạm gây lỗi là thiếu dòng này nè

namespace UniGate.Student
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            // Đăng ký sự kiện Load form
            this.Load += FormMain_Load;

            // --- ĐĂNG KÝ SỰ KIỆN CLICK CHO MENU ---
            // Sử dụng Lambda Expression để code gọn hơn
            btnDashboard.Click += (s, e) => {
                // Luôn luôn tạo "new" để nó chạy lại toàn bộ vòng đời và gọi API mới
                ShowView(new UcDashboard(), btnDashboard, "Bảng điều khiển");
            };
            btnProfile.Click += (s, e) => ShowView(new UcProfile(), btnProfile, "Hồ sơ & Điểm số");
            btnSearch.Click += (s, e) => ShowView(new UcSearch(), btnSearch, "Tra cứu & Gợi ý");
            btnWishlist.Click += (s, e) => ShowView(new UcWishlist(), btnWishlist, "Danh sách Nguyện vọng");
            btnHolland.Click += (s, e) => ShowView(new UcHolland(), btnHolland, "Trắc nghiệm Holland");
            btnHollandResults.Click += async (s, e) => {
                // 1. Gọi API lấy lịch sử (History) hoặc kết quả mới nhất từ Server
                var history = await Program.GlobalConfig.GetClient().GetFromJsonAsync<List<HollandHistoryDto>>("api/Holland/history");

                if (history != null && history.Count > 0)
                {
                    // 2. Lấy cái mới nhất (Index 0)
                    var lastResult = history[0];
                    var dto = new HollandResultDto
                    {
                        HollandCode = lastResult.HollandCode,
                        Description = "Kết quả lần làm gần nhất của bạn." // Hoặc lấy từ description server nếu có
                    };

                    // 3. Hiện lên
                    ShowView(new UcHollandResult(dto), btnHollandResults, "Kết quả Holland");
                }
                else
                {
                    MessageBox.Show("Mày chưa làm bài test mà, lấy gì hiện!");
                }
            };
            btnTools.Click += (s, e) => ShowView(new UcTools(), btnTools, "Phân tích Phổ điểm");
            btnCompare.Click += (s, e) => ShowView(new UcCompare(), btnCompare, "So sánh Ngành/Trường");
            btnSettings.Click += (s, e) => ShowView(new UcSettings(), btnSettings, "Cài đặt Tài khoản");
            btnSubjectGroup.Click += (s, e) => ShowView(new UcSubjectGroups(), btnSubjectGroup, "Nhóm Môn Thi");

            // Nút điều khiển cửa sổ (Nếu cần xử lý riêng ngoài GunaControlBox)
            // controlBoxClose.Click += (s, e) => Application.Exit();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            // 1. Cấu hình hiển thị
            this.WindowState = FormWindowState.Maximized; // Tự động phóng to
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea; // Tránh che thanh Taskbar

            // 2. Load Logo từ Resources (An toàn)
            try
            {
                // Đảm bảo bạn đã thêm ảnh có tên 'logo' vào Resources của Project
                picAppLogo.Image = Properties.Resources.logo;
                picAppLogo.SizeMode = PictureBoxSizeMode.Zoom;
                picAppLogo.Location = new Point(10, 10);
            }
            catch
            {
                // Nếu không tìm thấy ảnh, bỏ qua (tránh lỗi crash app)
            }

            // 3. Hiển thị thông tin User (Giả lập hoặc lấy từ Session)
            //string fullName = "Nguyễn Văn A";
            string fullName = UserSession.FullName; // Uncomment khi có class UserSession thực tế

            lblUserName.Text = fullName;

            // Tự tạo Avatar theo tên
            picAvatar.Image = GenerateAvatar(fullName);

            // 4. Load màn hình mặc định (Dashboard)
            // Dùng BeginInvoke để UI render xong mới load UserControl nặng
            this.BeginInvoke((MethodInvoker)delegate
            {
                // Giả lập click vào nút Dashboard để kích hoạt mọi trạng thái
                btnDashboard.PerformClick();
            });
        }

        // --- HÀM CHUYỂN ĐỔI GIAO DIỆN (CORE) ---
        public void ShowView(UserControl view, Guna2Button activeBtn, string pageTitle)
        {
            // 1. Cập nhật Tiêu đề
            lblCurrentPage.Text = pageTitle;

            // 2. Cập nhật trạng thái Menu (Highlight nút đang chọn)
            ResetButtonStates();
            activeBtn.Checked = true;

            // 3. Load UserControl vào Panel chính
            // SuspendLayout giúp giao diện không bị nhấp nháy khi xóa/thêm control
            pnlContainer.SuspendLayout();

            pnlContainer.Controls.Clear(); // Xóa control cũ

            view.Dock = DockStyle.Fill;    // Lấp đầy panel
            pnlContainer.Controls.Add(view);

            // (Optional) Gọi hàm fix lỗi font/layout nếu control bị vỡ
            // UiAutoFixer.Fix(view); 

            pnlContainer.ResumeLayout();
        }


        public Guna2Button GetBtnHollandResult()
        {
            return btnHollandResults;
        }

        public Guna2Button GetBtnSubjectGroup()
        {
            return btnSubjectGroup;
        }

        // Reset tất cả nút về trạng thái thường
        public void ResetButtonStates()
        {
            btnDashboard.Checked = false;
            btnProfile.Checked = false;
            
            btnWishlist.Checked = false;
            
            btnHollandResults.Checked = false;
            btnSearch.Checked = false;
            
            btnHolland.Checked = false;
            btnTools.Checked = false;
            btnCompare.Checked = false;
            btnSettings.Checked = false;
            btnSubjectGroup.Checked = false;
        }

        // --- HÀM TẠO AVATAR CHỮ CÁI (Giống Gmail) ---
        private Bitmap GenerateAvatar(string name)
        {
            // Lấy chữ cái đầu tiên
            string letter = string.IsNullOrEmpty(name) ? "?" : name.Trim().Substring(0, 1).ToUpper();

            // Tạo Bitmap hình vuông
            var bmp = new Bitmap(200, 200);

            using (var g = Graphics.FromImage(bmp))
            {
                // Cài đặt chất lượng vẽ cao nhất (AntiAlias)
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;

                // 1. Vẽ nền tròn (Màu Sky Blue chủ đạo)
                var brush = new SolidBrush(Color.FromArgb(14, 165, 233));
                g.FillEllipse(brush, 0, 0, 200, 200);

                // 2. Cấu hình Font chữ
                var font = new Font("Segoe UI", 80, FontStyle.Bold);

                // 3. Đo kích thước chữ để căn giữa
                var textSize = g.MeasureString(letter, font);
                float x = (200 - textSize.Width) / 2;
                float y = (200 - textSize.Height) / 2;

                // 4. Vẽ chữ màu trắng
                g.DrawString(letter, font, Brushes.White, x, y);
            }

            return bmp;
        }
    }
}