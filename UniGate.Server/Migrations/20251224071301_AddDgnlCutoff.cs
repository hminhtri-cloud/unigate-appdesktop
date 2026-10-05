using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UniGate.Server.Migrations
{
    /// <inheritdoc />
    public partial class AddDgnlCutoff : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "DgnlCutoff",
                table: "Majors",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 1,
                column: "PasswordHash",
                value: "$2a$11$9tr77wzfGKy.HxIwdY.CVOGSmxvYgl6sE1Lg28tJHsg9KDQR16Z3W");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DgnlCutoff",
                table: "Majors");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 1,
                column: "PasswordHash",
                value: "$2a$11$yLKeaIVCR2F8V7MegMg0/OAb4dnTqrkSxcCnV7ulJQn5xdBMyb9IG");
        }
    }
}
