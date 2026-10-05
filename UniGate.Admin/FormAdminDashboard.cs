using System;
using System.Drawing;
using System.Windows.Forms;
using UniGate.Admin.UserControls; // Namespace chứa các UserControl

namespace UniGate.Admin
{
    public partial class FormAdminDashboard : Form
    {
        // Màu sắc chủ đạo (Theme Sky Blue)
        private Color PrimaryColor = Color.FromArgb(56, 182, 255); // Xanh Sky
        private Color SecondaryColor = Color.FromArgb(235, 245, 255); // Nền nút khi chọn
        private Color TextDark = Color.FromArgb(64, 64, 64);

        private Button currentBtn; // Nút đang được chọn

        public FormAdminDashboard()
        {
            InitializeComponent();

            // Đăng ký sự kiện Click cho các nút menu
            // Cú pháp lambda: (s, e) => ActivateButton(s, new UserControl());

            btnDashboard.Click += (s, e) => ActivateButton(s, new UcDashboard());
            btnUserParams.Click += (s, e) => ActivateButton(s, new UcUsers());
            btnUniParams.Click += (s, e) => ActivateButton(s, new UcUniversities());
            btnMajorParams.Click += (s, e) => ActivateButton(s, new UcMajors());
            btnGroupParams.Click += (s, e) => ActivateButton(s, new UcSubjectGroups());

            // UserControl bạn cần gấp: Quản lý Phổ điểm
            btnScoreParams.Click += (s, e) => ActivateButton(s, new UcScoreDistribution());

            // Bộ câu hỏi trắc nghiệm
            btnHolland.Click += (s, e) => ActivateButton(s, new UcHollandQuestions());

            // Nút Đăng xuất
            btnLogout.Click += BtnLogout_Click;

            // Load mặc định Dashboard khi mở form
            // Dùng Load event để đảm bảo UI vẽ xong
            this.Load += (s, e) => ActivateButton(btnDashboard, new UcDashboard());
        }

        // --- HÀM XỬ LÝ GIAO DIỆN NÚT (HIGHLIGHT) ---
        private void ActivateButton(object senderBtn, UserControl userControl)
        {
            if (senderBtn != null)
            {
                DisableButton(); // Reset màu nút cũ

                // 1. Highlight nút mới
                currentBtn = (Button)senderBtn;
                currentBtn.BackColor = SecondaryColor; // Nền xanh nhạt
                currentBtn.ForeColor = PrimaryColor;   // Chữ xanh đậm
                currentBtn.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);

                // 2. Đổi tiêu đề Header (Lấy text từ nút)
                lblTitleChildForm.Text = currentBtn.Text;

                // 3. Hiển thị UserControl vào PanelDesktop
                ShowUserControl(userControl);
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.White;
                currentBtn.ForeColor = TextDark;
                currentBtn.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            }
        }

        // --- HÀM LOAD USER CONTROL ---
        private void ShowUserControl(UserControl uc)
        {
            // SuspendLayout giúp giảm giật lag khi render
            panelDesktop.SuspendLayout();

            // Xóa control cũ
            panelDesktop.Controls.Clear();

            // Setup control mới
            uc.Dock = DockStyle.Fill;
            uc.BringToFront();

            // Thêm vào panel
            panelDesktop.Controls.Add(uc);

            panelDesktop.ResumeLayout();
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                // Logic mở lại Form Login nên đặt ở Program.cs hoặc Form cha gọi form này
                new FormLogin().Show();
            }
        }
    }
}