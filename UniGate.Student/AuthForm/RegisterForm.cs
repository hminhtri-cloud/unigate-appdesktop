using UniGate.Student.Services;
using UniGate.Shared.DTOs;
using Guna.UI2.WinForms;

namespace UniGate.Student.myForm
{
    public partial class RegisterForm : Form
    {
        private readonly AuthService _authService = new();

        public RegisterForm()
        {
            InitializeComponent();

            // Đăng ký sự kiện
            this.btnRegister.Click += btnRegister_Click;
            this.lblLoginLink.Click += lblLoginLink_Click;

            // Hiệu ứng Hover cho link đăng nhập
            this.lblLoginLink.MouseEnter += (s, e) => lblLoginLink.ForeColor = Color.FromArgb(14, 165, 233);
            this.lblLoginLink.MouseLeave += (s, e) => lblLoginLink.ForeColor = Color.DimGray;
        }

        private async void btnRegister_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text) ||
                string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtPassword.Text != txtConfirmPass.Text)
            {
                MessageBox.Show("Mật khẩu xác nhận không khớp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            btnRegister.Enabled = false;
            btnRegister.Text = "ĐANG XỬ LÝ...";

            var req = new RegisterRequest
            {
                Email = txtEmail.Text.Trim(),
                Password = txtPassword.Text,
                FullName = txtFullName.Text.Trim(),
               
            };

            try
            {
                var (success, message) = await _authService.RegisterAsync(req);

                if (success)
                {
                    MessageBox.Show("Đăng ký thành công! Vui lòng đăng nhập.", "Chúc mừng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    Login loginForm = new Login();
                    loginForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Đăng ký thất bại: " + message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống: " + ex.Message);
            }
            finally
            {
                btnRegister.Enabled = true;
                btnRegister.Text = "ĐĂNG KÝ NGAY";
            }
        }

        private void lblLoginLink_Click(object? sender, EventArgs e)
        {
            this.Hide();
            new Login().ShowDialog();
            this.Show();
        }
    }
}