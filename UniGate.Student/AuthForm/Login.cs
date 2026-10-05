using UniGate.Student.Services;
using UniGate.Shared.DTOs;
using Guna.UI2.WinForms;

namespace UniGate.Student.myForm
{
    public partial class Login : Form
    {
        private readonly AuthService _authService = new();

        public Login()
        {
            InitializeComponent();

            // Đăng ký sự kiện
            this.btnLogin.Click += btnLogin_Click;
            this.lblRegisterLink.Click += lblRegisterLink_Click;
            this.lblForgotPassword.Click += lblForgotPassword_Click; // 👈 QUAN TRỌNG: Thêm dòng này

            // Hiệu ứng Hover
            this.lblRegisterLink.MouseEnter += (s, e) => lblRegisterLink.ForeColor = Color.FromArgb(14, 165, 233);
            this.lblRegisterLink.MouseLeave += (s, e) => lblRegisterLink.ForeColor = Color.DimGray;
        }

        private async void btnLogin_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                lblMessage.Text = "Vui lòng nhập Email và Mật khẩu!";
                return;
            }

            btnLogin.Enabled = false;
            btnLogin.Text = "ĐANG XÁC THỰC...";

            try
            {
                var (success, message) = await _authService.LoginAsync(txtEmail.Text, txtPassword.Text);

                if (success)
                {
                    if (string.IsNullOrEmpty(UserSession.UserName))
                        UserSession.UserName = txtEmail.Text;

                    this.Hide();
                    new FormMain().Show();
                }
                else
                {
                    lblMessage.Text = message;
                    btnLogin.Enabled = true;
                    btnLogin.Text = "ĐĂNG NHẬP";
                }
            }
            catch (Exception ex)
            {
                lblMessage.Text = "Lỗi: " + ex.Message;
                btnLogin.Enabled = true;
                btnLogin.Text = "ĐĂNG NHẬP";
            }
        }

        private void lblRegisterLink_Click(object? sender, EventArgs e)
        {
            this.Hide();
            new RegisterForm().ShowDialog();
            this.Show();
        }

        // --- HÀM MỞ FORM QUÊN MẬT KHẨU ---
        private void lblForgotPassword_Click(object? sender, EventArgs e)
        {
            this.Hide();
            // Mở form quên mật khẩu dạng Dialog
            new FormForgotPassword().ShowDialog();
            this.Show();
        }
    }
}