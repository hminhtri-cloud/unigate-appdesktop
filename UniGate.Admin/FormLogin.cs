using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Windows.Forms;
using UniGate.Shared.DTOs;
using static UniGate.Admin.Program;

namespace UniGate.Admin
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            // 1. Disable nút ngay để tránh bấm liên tục gây treo
            btnLogin.Enabled = false;
            btnLogin.Text = "Đang kết nối...";

            var loginReq = new LoginRequest
            {
                Email = txtEmail.Text,
                Password = txtPassword.Text
            };

            try
            {
                var client = GlobalConfig.GetClient();
                // --- QUAN TRỌNG: Set Timeout ngắn lại (5 giây) ---
                // Để lỡ mạng lag nó báo lỗi liền chứ không im ru
                client.Timeout = TimeSpan.FromSeconds(5);

                // Gọi API
                var response = await client.PostAsJsonAsync("api/Auth/login", loginReq);

                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadFromJsonAsync<AuthResponse>();

                    if (result.Role != "Admin")
                    {
                        MessageBox.Show("Mày là sinh viên mà, định hack vào trang Admin hả?",
                                        "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Lưu Session
                    AdminSession.Token = result.Token;
                    AdminSession.FullName = result.FullName;
                    AdminSession.Role = result.Role;
                    AdminSession.UserID = result.UserId; // Nhớ lưu cái này nữa

                    MessageBox.Show($"Chào sếp {result.FullName}!", "Thành công");

                    // --- SỬA CÁCH CHUYỂN FORM ---
                    // Trả về OK để Program.cs biết là đăng nhập thành công
                    // Trong FormLogin
                    this.DialogResult = DialogResult.OK;

                    this.Close(); // Đóng Form Login lại để Program.cs mở Dashboard lên
                }
                else
                {
                    string error = await response.Content.ReadAsStringAsync();
                    MessageBox.Show("Lỗi đăng nhập: " + error, "Thất bại");
                }
            }
            catch (TaskCanceledException) // Bắt lỗi Timeout
            {
                MessageBox.Show("Kết nối quá hạn! Server có đang chạy không? Hay Ngrok đổi link rồi?", "Lỗi Mạng");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi nghiêm trọng: " + ex.Message);
            }
            finally
            {
                // Mở lại nút dù thành công hay thất bại
                btnLogin.Enabled = true;
                btnLogin.Text = "Đăng Nhập";
            }
        }
    }
}