using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebMusic_Auth.Data.Migrations
{
    public partial class UpdateAlbum : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_album_Users_UsId",
                table: "album");

            migrationBuilder.DropIndex(
                name: "IX_album_UsId",
                table: "album");

            migrationBuilder.DropColumn(
                name: "long",
                table: "song");

            migrationBuilder.DropColumn(
                name: "ADate",
                table: "album");

            migrationBuilder.DropColumn(
                name: "AStatus",
                table: "album");

            migrationBuilder.DropColumn(
                name: "SName",
                table: "album");

            migrationBuilder.DropColumn(
                name: "UsId",
                table: "album");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "long",
                table: "song",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ADate",
                table: "album",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "AStatus",
                table: "album",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SName",
                table: "album",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UsId",
                table: "album",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_album_UsId",
                table: "album",
                column: "UsId");

            migrationBuilder.AddForeignKey(
                name: "FK_album_Users_UsId",
                table: "album",
                column: "UsId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
