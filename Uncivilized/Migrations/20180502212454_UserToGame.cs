using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Uncivilized.Migrations
{
    public partial class UserToGame : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Nations",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.CreateIndex(
                name: "IX_Nations_UserId",
                table: "Nations",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Nations_AspNetUsers_UserId",
                table: "Nations",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Nations_AspNetUsers_UserId",
                table: "Nations");

            migrationBuilder.DropIndex(
                name: "IX_Nations_UserId",
                table: "Nations");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Nations",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
