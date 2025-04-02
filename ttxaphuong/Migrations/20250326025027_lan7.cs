using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ttxaphuong.Migrations
{
    /// <inheritdoc />
    public partial class lan7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id_account",
                keyValue: 1,
                column: "Create_at",
                value: new DateTime(2025, 3, 26, 2, 50, 25, 634, DateTimeKind.Utc).AddTicks(3313));

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id_account",
                keyValue: 2,
                column: "Create_at",
                value: new DateTime(2025, 3, 26, 2, 50, 25, 634, DateTimeKind.Utc).AddTicks(3322));

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id_account", "CodeExpiry", "Create_at", "Email", "Fullname", "Password", "RefreshToken", "RefreshTokenExpiry", "Role", "Status", "Username", "VerificationCode" },
                values: new object[] { 3, null, new DateTime(2025, 3, 26, 2, 50, 25, 634, DateTimeKind.Utc).AddTicks(3326), "kieu@gmail.com", "Nguyễn Thị Thúy Kiều", "kieu2308", null, null, "Admin", "IsActive", "ThuyKieu", null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id_account",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id_account",
                keyValue: 1,
                column: "Create_at",
                value: new DateTime(2025, 3, 25, 8, 20, 21, 102, DateTimeKind.Utc).AddTicks(3689));

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id_account",
                keyValue: 2,
                column: "Create_at",
                value: new DateTime(2025, 3, 25, 8, 20, 21, 102, DateTimeKind.Utc).AddTicks(3698));
        }
    }
}
