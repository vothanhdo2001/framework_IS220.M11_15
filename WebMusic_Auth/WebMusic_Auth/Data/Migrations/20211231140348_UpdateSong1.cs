using Microsoft.EntityFrameworkCore.Migrations;

namespace WebMusic_Auth.Data.Migrations
{
    public partial class UpdateSong1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Nviews",
                table: "song",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nviews",
                table: "song");
        }
    }
}
