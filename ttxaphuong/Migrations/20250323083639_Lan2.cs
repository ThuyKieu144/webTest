using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ttxaphuong.Migrations
{
    /// <inheritdoc />
    public partial class Lan2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Permissions_Accounts_AccountsId_account",
                table: "Permissions");

            migrationBuilder.RenameColumn(
                name: "AccountsId_account",
                table: "Permissions",
                newName: "AccountsModel");

            migrationBuilder.RenameIndex(
                name: "IX_Permissions_AccountsId_account",
                table: "Permissions",
                newName: "IX_Permissions_AccountsModel");

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id_account",
                keyValue: 1,
                column: "Create_at",
                value: new DateTime(2025, 3, 23, 8, 36, 38, 416, DateTimeKind.Utc).AddTicks(7203));

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id_account",
                keyValue: 2,
                column: "Create_at",
                value: new DateTime(2025, 3, 23, 8, 36, 38, 416, DateTimeKind.Utc).AddTicks(7210));

            migrationBuilder.AddForeignKey(
                name: "FK_Permissions_Accounts_AccountsModel",
                table: "Permissions",
                column: "AccountsModel",
                principalTable: "Accounts",
                principalColumn: "Id_account");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Permissions_Accounts_AccountsModel",
                table: "Permissions");

            migrationBuilder.RenameColumn(
                name: "AccountsModel",
                table: "Permissions",
                newName: "AccountsId_account");

            migrationBuilder.RenameIndex(
                name: "IX_Permissions_AccountsModel",
                table: "Permissions",
                newName: "IX_Permissions_AccountsId_account");

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id_account",
                keyValue: 1,
                column: "Create_at",
                value: new DateTime(2025, 3, 23, 8, 34, 31, 324, DateTimeKind.Utc).AddTicks(1451));

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id_account",
                keyValue: 2,
                column: "Create_at",
                value: new DateTime(2025, 3, 23, 8, 34, 31, 324, DateTimeKind.Utc).AddTicks(1455));

            migrationBuilder.AddForeignKey(
                name: "FK_Permissions_Accounts_AccountsId_account",
                table: "Permissions",
                column: "AccountsId_account",
                principalTable: "Accounts",
                principalColumn: "Id_account");
        }
    }
}
