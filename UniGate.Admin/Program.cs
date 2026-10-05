namespace UniGate.Admin
{
    internal static class Program
    {

        public static class GlobalConfig
        {
            // Dán link ngrok của m vào đây
            public static string BaseUrl = "https://verbless-leona-unwrought.ngrok-free.dev/";

            public static HttpClient GetClient()
            {
                var client = new HttpClient { BaseAddress = new Uri(BaseUrl) };

                // Nếu admin đã đăng nhập và có Token thì đính kèm vào luôn
                if (!string.IsNullOrEmpty(AdminSession.Token))
                {
                    client.DefaultRequestHeaders.Authorization =
                        new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", AdminSession.Token);
                }
                return client;
            }
        }
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            FormLogin login = new FormLogin();

            if (login.ShowDialog() == DialogResult.OK)
            {
                // BƯỚC 2: Mới bắt đầu chạy Dashboard
                // Lúc này Form Login đã được giải phóng bộ nhớ hoàn toàn (Dispose)
                Application.Run(new FormAdminDashboard());
            }
            else
            {
                // Nếu bấm nút X tắt form login thì thoát app
                Application.Exit();
            }
        }
    }
}