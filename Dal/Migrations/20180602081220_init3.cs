using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Dal.Migrations
{
    public partial class init3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Account_UserId",
                schema: "dbo",
                table: "Account",
                column: "UserId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Account_User_UserId",
                schema: "dbo",
                table: "Account",
                column: "UserId",
                principalSchema: "dbo",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Account_User_UserId",
                schema: "dbo",
                table: "Account");

            migrationBuilder.DropIndex(
                name: "IX_Account_UserId",
                schema: "dbo",
                table: "Account");
        }
    }
}
