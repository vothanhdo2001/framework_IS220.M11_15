using Microsoft.EntityFrameworkCore.Migrations;

namespace WebMusic_Auth.Data.Migrations
{
    public partial class UpdateAlbum : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_album_Users_UserId",
                table: "album");

            migrationBuilder.DropIndex(
                name: "IX_album_UserId",
                table: "album");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "album");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "album",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_album_UserId",
                table: "album",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_album_Users_UserId",
                table: "album",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
