using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ttxaphuong.Migrations
{
    /// <inheritdoc />
    public partial class Lan3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Permissions_Accounts_AccountsModel",
                table: "Permissions");

            migrationBuilder.DropIndex(
                name: "IX_Permissions_AccountsModel",
                table: "Permissions");

            migrationBuilder.DropColumn(
                name: "AccountsModel",
                table: "Permissions");

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

            migrationBuilder.CreateIndex(
                name: "IX_Permissions_ManagerId",
                table: "Permissions",
                column: "ManagerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Permissions_Accounts_ManagerId",
                table: "Permissions",
                column: "ManagerId",
                principalTable: "Accounts",
                principalColumn: "Id_account",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Permissions_Accounts_ManagerId",
                table: "Permissions");

            migrationBuilder.DropIndex(
                name: "IX_Permissions_ManagerId",
                table: "Permissions");

            migrationBuilder.AddColumn<int>(
                name: "AccountsModel",
                table: "Permissions",
                type: "int",
                nullable: true);

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

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "AccountsModel",
                value: null);

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "AccountsModel",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_Permissions_AccountsModel",
                table: "Permissions",
                column: "AccountsModel");

            migrationBuilder.AddForeignKey(
                name: "FK_Permissions_Accounts_AccountsModel",
                table: "Permissions",
                column: "AccountsModel",
                principalTable: "Accounts",
                principalColumn: "Id_account");
        }
    }
}
