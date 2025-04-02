using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ttxaphuong.Migrations
{
    /// <inheritdoc />
    public partial class Lan4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WebsiteSettings",
                columns: table => new
                {
                    Id_webiste = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    LogoUrl = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    BannerUrl = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    WebsiteName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ThemeColor = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    BannerText = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    BannerBackgroundColor = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FooterBackgroundColor = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FooterTextColor = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FooterAddress = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FooterPhone = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FooterEmail = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    GoogleMapEmbedLink = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    MenuBackgroundColor = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    MenuTextColor = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SidebarBackgroundColor = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    HeaderBackgroundColor = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SidebarTextColor = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    HeaderTextColor = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SidebarLayout = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    HeaderLayout = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WebsiteSettings", x => x.Id_webiste);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id_account",
                keyValue: 1,
                column: "Create_at",
                value: new DateTime(2025, 3, 24, 3, 29, 14, 874, DateTimeKind.Utc).AddTicks(5084));

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id_account",
                keyValue: 2,
                column: "Create_at",
                value: new DateTime(2025, 3, 24, 3, 29, 14, 874, DateTimeKind.Utc).AddTicks(5104));

            migrationBuilder.InsertData(
                table: "WebsiteSettings",
                columns: new[] { "Id_webiste", "BannerBackgroundColor", "BannerText", "BannerUrl", "FooterAddress", "FooterBackgroundColor", "FooterEmail", "FooterPhone", "FooterTextColor", "GoogleMapEmbedLink", "HeaderBackgroundColor", "HeaderLayout", "HeaderTextColor", "LogoUrl", "MenuBackgroundColor", "MenuTextColor", "SidebarBackgroundColor", "SidebarLayout", "SidebarTextColor", "ThemeColor", "WebsiteName" },
                values: new object[] { 1, "#f4f4f4", "Chào mừng bạn đến với Tin Tức 24h", "banner.jpg", "123 Đường ABC, Quận 1, TP.HCM", "#333333", "contact@tintuc24h.com", "0123-456-789", "#ffffff", "<iframe src='https://www.google.com/maps/embed?...'></iframe>", "#000000", "{\"fixed\": true, \"height\": \"60px\"}", "#ffcc00", "logo.png", "#ffffff", "#000000", "#1a1a1a", "{\"position\": \"left\", \"width\": \"250px\"}", "#ffffff", "#ff5733", "Tin Tức 24h" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WebsiteSettings");

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id_account",
                keyValue: 1,
                column: "Create_at",
                value: new DateTime(2025, 3, 23, 8, 37, 36, 926, DateTimeKind.Utc).AddTicks(5431));

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id_account",
                keyValue: 2,
                column: "Create_at",
                value: new DateTime(2025, 3, 23, 8, 37, 36, 926, DateTimeKind.Utc).AddTicks(5437));
        }
    }
}
