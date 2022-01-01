using Microsoft.EntityFrameworkCore.Migrations;

namespace WebMusic_Auth.Data.Migrations
{
    public partial class UpdataUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_loveDetail",
                table: "loveDetail");

            migrationBuilder.DropIndex(
                name: "IX_loveDetail_MId",
                table: "loveDetail");

            migrationBuilder.DropPrimaryKey(
                name: "PK_history",
                table: "history");

            migrationBuilder.DropIndex(
                name: "IX_history_MId",
                table: "history");

            migrationBuilder.DropPrimaryKey(
                name: "PK_albumDetail",
                table: "albumDetail");

            migrationBuilder.DropColumn(
                name: "UsId",
                table: "albumDetail");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Users",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NickName",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Photo",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Sex",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UsRank",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UsStatus",
                table: "Users",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UsId",
                table: "playlist",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "UsId",
                table: "loveDetail",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "UsId",
                table: "history",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "UsId",
                table: "comments",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "UsId",
                table: "album",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_loveDetail",
                table: "loveDetail",
                columns: new[] { "MId", "UsId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_history",
                table: "history",
                columns: new[] { "MId", "UsId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_albumDetail",
                table: "albumDetail",
                columns: new[] { "AId", "MId", "SiId" });

            migrationBuilder.CreateIndex(
                name: "IX_playlist_UsId",
                table: "playlist",
                column: "UsId");

            migrationBuilder.CreateIndex(
                name: "IX_loveDetail_UsId",
                table: "loveDetail",
                column: "UsId");

            migrationBuilder.CreateIndex(
                name: "IX_history_UsId",
                table: "history",
                column: "UsId");

            migrationBuilder.CreateIndex(
                name: "IX_comments_UsId",
                table: "comments",
                column: "UsId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_comments_Users_UsId",
                table: "comments",
                column: "UsId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_history_Users_UsId",
                table: "history",
                column: "UsId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_loveDetail_Users_UsId",
                table: "loveDetail",
                column: "UsId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_playlist_Users_UsId",
                table: "playlist",
                column: "UsId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_album_Users_UsId",
                table: "album");

            migrationBuilder.DropForeignKey(
                name: "FK_comments_Users_UsId",
                table: "comments");

            migrationBuilder.DropForeignKey(
                name: "FK_history_Users_UsId",
                table: "history");

            migrationBuilder.DropForeignKey(
                name: "FK_loveDetail_Users_UsId",
                table: "loveDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_playlist_Users_UsId",
                table: "playlist");

            migrationBuilder.DropIndex(
                name: "IX_playlist_UsId",
                table: "playlist");

            migrationBuilder.DropPrimaryKey(
                name: "PK_loveDetail",
                table: "loveDetail");

            migrationBuilder.DropIndex(
                name: "IX_loveDetail_UsId",
                table: "loveDetail");

            migrationBuilder.DropPrimaryKey(
                name: "PK_history",
                table: "history");

            migrationBuilder.DropIndex(
                name: "IX_history_UsId",
                table: "history");

            migrationBuilder.DropIndex(
                name: "IX_comments_UsId",
                table: "comments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_albumDetail",
                table: "albumDetail");

            migrationBuilder.DropIndex(
                name: "IX_album_UsId",
                table: "album");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "NickName",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Photo",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Sex",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "UsRank",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "UsStatus",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "UsId",
                table: "album");

            migrationBuilder.AlterColumn<int>(
                name: "UsId",
                table: "playlist",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UsId",
                table: "loveDetail",
                type: "int",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<int>(
                name: "UsId",
                table: "history",
                type: "int",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<int>(
                name: "UsId",
                table: "comments",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UsId",
                table: "albumDetail",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_loveDetail",
                table: "loveDetail",
                columns: new[] { "UsId", "MId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_history",
                table: "history",
                columns: new[] { "UsId", "MId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_albumDetail",
                table: "albumDetail",
                columns: new[] { "AId", "MId", "UsId", "SiId" });

            migrationBuilder.CreateIndex(
                name: "IX_loveDetail_MId",
                table: "loveDetail",
                column: "MId");

            migrationBuilder.CreateIndex(
                name: "IX_history_MId",
                table: "history",
                column: "MId");
        }
    }
}
