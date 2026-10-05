namespace UniGate.Student;

public static class UserSession
{

    public static int UserId { get; set; }
    public static string Token { get; set; } = "";
    public static string FullName { get; set; } = "";
    public static string UserName { get; set; } = "";
    public static string Role { get; set; } = "";

    // 👇 THÊM DÒNG NÀY
    public static string Email { get; set; } = "";

    public static bool IsLoggedIn => !string.IsNullOrEmpty(Token);

    public static void Logout()
    {
        Token = ""; FullName = ""; UserName = ""; Role = "";
        Email = ""; // Xóa luôn email
    }
}