using UniGate.Student.myForm;

namespace UniGate.Student
{
    internal static class Program
    {

        public static class GlobalConfig
        {
            public static string BaseUrl = "https://verbless-leona-unwrought.ngrok-free.dev/";

            public static HttpClient GetClient()
            {
                // 1. Tạo client trước
                var client = new HttpClient { BaseAddress = new Uri(BaseUrl) };

                // 2. PHẢI NẰM Ở ĐÂY (Trong hàm GetClient và sau khi tạo client)
                // Dòng này giúp vượt qua trang cảnh báo của ngrok
                client.DefaultRequestHeaders.Add("ngrok-skip-browser-warning", "true");

                if (!string.IsNullOrEmpty(UserSession.Token))
                {
                    client.DefaultRequestHeaders.Authorization =
                        new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", UserSession.Token);
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
            Application.Run(new Login() );
        }
    }
}