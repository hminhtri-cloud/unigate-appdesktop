using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Drawing;
using System.Windows.Forms;
using UniGate.Shared.DTOs;
using Guna.UI2.WinForms;

namespace UniGate.Student.myForm
{
    public partial class FormForgotPassword : Form
    {
        private readonly HttpClient _http = new() { BaseAddress = new Uri("https://localhost:7030/") };

        public FormForgotPassword()
        {
            InitializeComponent();

            // Lúc này pnlReset và btnSendOTP đã tồn tại (hết lỗi Null)
            pnlReset.Visible = false;
            btnSendOTP.Visible = true;

            // Đăng ký sự kiện
            btnSendOTP.Click += BtnSendOTP_Click;
            btnConfirm.Click += BtnConfirm_Click;
        }

        private async void BtnSendOTP_Click(object? sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Vui lòng nhập Email!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            btnSendOTP.Enabled = false;
            btnSendOTP.Text = "ĐANG GỬI MÃ...";

            var dto = new ForgotPasswordDto { Email = email };

            try
            {
                var response = await _http.PostAsJsonAsync("api/Auth/forgot-password", dto);
                if (response.IsSuccessStatusCode)
                {
                    
                    // Thay dòng: var result = await response.Content.ReadFromJsonAsync<dynamic>();
                    // Bằng dòng này:
                    var result = await response.Content.ReadFromJsonAsync<ApiResponse>();
                    string msg = result?.message ?? "Kiểm tra email nhé!";

                    // Chỉ hiện thông báo hướng dẫn check mail
                    MessageBox.Show(msg, "Đã gửi mail", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtEmail.ReadOnly = true;
                    btnSendOTP.Visible = false;
                    pnlReset.Visible = true;
                    pnlReset.BringToFront();
                }
                else
                {
                    MessageBox.Show("Email không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnSendOTP.Enabled = true;
                    btnSendOTP.Text = "LẤY MÃ OTP";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message);
                btnSendOTP.Enabled = true;
            }
        }

        private async void BtnConfirm_Click(object? sender, EventArgs e)
        {
            string otp = txtOTP.Text.Trim();
            string newPass = txtNewPassword.Text;
            string confirmPass = txtConfirmPassword.Text;

            if (string.IsNullOrWhiteSpace(otp) || string.IsNullOrWhiteSpace(newPass))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            if (newPass != confirmPass)
            {
                MessageBox.Show("Mật khẩu xác nhận không khớp!");
                return;
            }

            btnConfirm.Enabled = false;
            btnConfirm.Text = "ĐANG XỬ LÝ...";

            var dto = new ResetPasswordDto
            {
                Email = txtEmail.Text,
                OTP = otp,
                NewPassword = newPass
            };

            try
            {
                var response = await _http.PostAsJsonAsync("api/Auth/reset-password", dto);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Đổi mật khẩu thành công!");
                    this.Close();
                }
                else
                {
                    string error = await response.Content.ReadAsStringAsync();
                    MessageBox.Show("Lỗi: " + error);
                    btnConfirm.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
                btnConfirm.Enabled = true;
            }
        }
    }

    // Class dùng để hứng tin nhắn từ Server trả về
    public class ApiResponse
    {
        public string message { get; set; } = "";
    }
}