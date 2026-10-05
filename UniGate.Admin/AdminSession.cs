namespace UniGate.Admin; // Hoặc UniGate.Admin

public static class AdminSession
{
    // Biến static này sẽ sống mãi cho đến khi tắt app
    public static string Token { get; set; } = "";
    public static string FullName { get; set; } = "";

    public static int UserID { get; set; }
    public static string Role { get; set; } = "";

    // Hàm xóa session khi đăng xuất
    public static void Clear()
    {
        Token = "";
        FullName = "";
        Role = "";
    }
}