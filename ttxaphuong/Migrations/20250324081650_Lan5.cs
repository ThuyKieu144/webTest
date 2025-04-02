using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ttxaphuong.Migrations
{
    /// <inheritdoc />
    public partial class Lan5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Id_webiste",
                table: "WebsiteSettings",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Id_webiste",
                table: "WebsiteSettings",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

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
        }
    }
}
