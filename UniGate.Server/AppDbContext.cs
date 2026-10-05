using Microsoft.EntityFrameworkCore;
using UniGate.Server.Entities;

namespace UniGate.Server;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    // --- CÁC BẢNG TRONG DATABASE ---
    public DbSet<HollandQuestion> HollandQuestions { get; set; }    
    public DbSet<HollandResult> HollandResults { get; set; }
    public DbSet<UserScore> UserScores { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<University> Universities { get; set; }
    public DbSet<Major> Majors { get; set; }
    public DbSet<ScoreDistribution> ScoreDistributions { get; set; }
    public DbSet<UserFavorite> UserFavorites { get; set; }
    public DbSet<UserTarget> UserTargets { get; set; }
    public DbSet<SubjectGroup> SubjectGroups { get; set; }


    // --- HÀM NÀY M PHẢI TỰ VIẾT THÊM VÀO NÈ ---
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Seed (Cấy) tài khoản Admin với ID = 2
        string adminPassHash = BCrypt.Net.BCrypt.HashPassword("admin123");

        modelBuilder.Entity<User>().HasData(
            new User
            {
                UserID = 1, // Đổi thành 2 nhé
                Email = "admin@unigate.com",
                FullName = "Administrator",
                PasswordHash = adminPassHash,
                Role = "Admin",
                CreatedAt = new DateTime(2025, 01, 01)
            }
        );
    }
}