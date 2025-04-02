using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ttxaphuong.Migrations
{
    /// <inheritdoc />
    public partial class Lan6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BannnerTextColor",
                table: "WebsiteSettings",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "TextRunning",
                table: "WebsiteSettings",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

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

            migrationBuilder.UpdateData(
                table: "WebsiteSettings",
                keyColumn: "Id_webiste",
                keyValue: 1,
                columns: new[] { "BannnerTextColor", "TextRunning" },
                values: new object[] { "#333333", "#f0f0f0" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BannnerTextColor",
                table: "WebsiteSettings");

            migrationBuilder.DropColumn(
                name: "TextRunning",
                table: "WebsiteSettings");

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id_account",
                keyValue: 1,
                column: "Create_at",
                value: new DateTime(2025, 3, 24, 8, 16, 48, 726, DateTimeKind.Utc).AddTicks(2565));

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id_account",
                keyValue: 2,
                column: "Create_at",
                value: new DateTime(2025, 3, 24, 8, 16, 48, 726, DateTimeKind.Utc).AddTicks(2569));
        }
    }
}
