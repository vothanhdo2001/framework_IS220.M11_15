using Microsoft.EntityFrameworkCore.Migrations;

namespace WebMusic_Auth.Data.Migrations
{
    public partial class UpdateSong : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "long",
                table: "song");

            migrationBuilder.DropColumn(
                name: "Nviews",
                table: "song");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "long",
                table: "song",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Nviews",
                table: "song",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
