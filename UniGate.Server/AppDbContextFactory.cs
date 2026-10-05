using Microsoft.EntityFrameworkCore;
using UniGate.Server.Entities;

namespace UniGate.Server.Data // Nhớ check namespace cho đúng với project của m
{
	public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

		// --- CÁC BẢNG TRONG DATABASE (Đủ 10 bảng) ---
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

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			// 1. --- CẤU HÌNH QUAN HỆ 1-1 (User - UserScore) ---
			// Một User chỉ có Một Bảng Điểm và ngược lại
			modelBuilder.Entity<User>()
				.HasOne(u => u.UserScore)
				.WithOne(us => us.User)
				.HasForeignKey<UserScore>(us => us.UserId)
				.OnDelete(DeleteBehavior.Cascade); // Xóa User là xóa luôn điểm -> Sạch sẽ

			// 2. --- CẤU HÌNH KIỂU DECIMAL TOÀN CỤC ---
			// Mẹo này giúp m không cần chỉnh từng dòng decimal trong Entity
			foreach (var property in modelBuilder.Model.GetEntityTypes()
				.SelectMany(t => t.GetProperties())
				.Where(p => p.ClrType == typeof(decimal) || p.ClrType == typeof(decimal?)))
			{
				// Mặc định tất cả số tiền/điểm sẽ có dạng (18, 2) nếu chưa được set trong Entity
				property.SetColumnType("decimal(18,2)");
			}

			// 3. --- SEED DATA (Tạo sẵn Admin) ---
			// T đã sửa ID thành 1 cho chuẩn. Nếu m thích số 2 thì sửa lại nhé.
			// Lưu ý: M phải cài gói "BCrypt.Net-Next" mới dùng được hàm này
			string adminPassHash = BCrypt.Net.BCrypt.HashPassword("admin123");

			modelBuilder.Entity<User>().HasData(
				new User
				{
					UserID = 1, // Admin trùm cuối thường là số 1
					Email = "admin@unigate.com",
					FullName = "Administrator",
					PasswordHash = adminPassHash,
					Role = "Admin",
					CreatedAt = new DateTime(2025, 01, 01)
				}
			);
		}
	}
}