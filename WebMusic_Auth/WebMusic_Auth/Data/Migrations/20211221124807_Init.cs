using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebMusic_Auth.Data.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserTokens",
                table: "AspNetUserTokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUsers",
                table: "AspNetUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserRoles",
                table: "AspNetUserRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserLogins",
                table: "AspNetUserLogins");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserClaims",
                table: "AspNetUserClaims");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetRoles",
                table: "AspNetRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetRoleClaims",
                table: "AspNetRoleClaims");

            migrationBuilder.RenameTable(
                name: "AspNetUserTokens",
                newName: "UserTokens");

            migrationBuilder.RenameTable(
                name: "AspNetUsers",
                newName: "Users");

            migrationBuilder.RenameTable(
                name: "AspNetUserRoles",
                newName: "UserRoles");

            migrationBuilder.RenameTable(
                name: "AspNetUserLogins",
                newName: "UserLogins");

            migrationBuilder.RenameTable(
                name: "AspNetUserClaims",
                newName: "UserClaims");

            migrationBuilder.RenameTable(
                name: "AspNetRoles",
                newName: "Roles");

            migrationBuilder.RenameTable(
                name: "AspNetRoleClaims",
                newName: "RoleClaims");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "UserRoles",
                newName: "IX_UserRoles_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "UserLogins",
                newName: "IX_UserLogins_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "UserClaims",
                newName: "IX_UserClaims_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "RoleClaims",
                newName: "IX_RoleClaims_RoleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserTokens",
                table: "UserTokens",
                columns: new[] { "UserId", "LoginProvider", "Name" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserRoles",
                table: "UserRoles",
                columns: new[] { "UserId", "RoleId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserLogins",
                table: "UserLogins",
                columns: new[] { "LoginProvider", "ProviderKey" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserClaims",
                table: "UserClaims",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Roles",
                table: "Roles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RoleClaims",
                table: "RoleClaims",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "album",
                columns: table => new
                {
                    AId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AName = table.Column<string>(nullable: true),
                    ADate = table.Column<DateTime>(nullable: false),
                    SName = table.Column<string>(nullable: true),
                    Intro = table.Column<string>(nullable: true),
                    Photo = table.Column<string>(nullable: true),
                    AStatus = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_album", x => x.AId);
                });

            migrationBuilder.CreateTable(
                name: "category",
                columns: table => new
                {
                    CaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CaName = table.Column<string>(maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_category", x => x.CaId);
                });

            migrationBuilder.CreateTable(
                name: "playlist",
                columns: table => new
                {
                    PId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PName = table.Column<string>(maxLength: 50, nullable: true),
                    PDate = table.Column<DateTime>(nullable: false),
                    PStatus = table.Column<string>(maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_playlist", x => x.PId);
                });

            migrationBuilder.CreateTable(
                name: "singer",
                columns: table => new
                {
                    SiId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SiName = table.Column<string>(nullable: true),
                    Photo = table.Column<string>(nullable: true),
                    Story = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_singer", x => x.SiId);
                });

            migrationBuilder.CreateTable(
                name: "song",
                columns: table => new
                {
                    MId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Song = table.Column<string>(maxLength: 50, nullable: true),
                    Author = table.Column<string>(maxLength: 100, nullable: true),
                    @long = table.Column<string>(name: "long", maxLength: 20, nullable: true),
                    Nviews = table.Column<int>(nullable: false),
                    Lyrics = table.Column<string>(maxLength: 4000, nullable: true),
                    Files = table.Column<string>(maxLength: 500, nullable: true),
                    Photo = table.Column<string>(maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_song", x => x.MId);
                });

            migrationBuilder.CreateTable(
                name: "usersManager",
                columns: table => new
                {
                    UsId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NickName = table.Column<string>(nullable: true),
                    Sex = table.Column<string>(nullable: true),
                    UsRank = table.Column<string>(nullable: true),
                    UsStatus = table.Column<string>(nullable: true),
                    Photo = table.Column<string>(nullable: true),
                    IdLogin = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usersManager", x => x.UsId);
                });

            migrationBuilder.CreateTable(
                name: "categoryDetail",
                columns: table => new
                {
                    CaId = table.Column<int>(nullable: false),
                    MId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categoryDetail", x => new { x.MId, x.CaId });
                    table.ForeignKey(
                        name: "FK_categoryDetail_category_CaId",
                        column: x => x.CaId,
                        principalTable: "category",
                        principalColumn: "CaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_categoryDetail_song_MId",
                        column: x => x.MId,
                        principalTable: "song",
                        principalColumn: "MId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "songDetail",
                columns: table => new
                {
                    SiId = table.Column<int>(nullable: false),
                    MId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_songDetail", x => new { x.SiId, x.MId });
                    table.ForeignKey(
                        name: "FK_songDetail_song_MId",
                        column: x => x.MId,
                        principalTable: "song",
                        principalColumn: "MId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_songDetail_singer_SiId",
                        column: x => x.SiId,
                        principalTable: "singer",
                        principalColumn: "SiId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "albumDetail",
                columns: table => new
                {
                    AId = table.Column<int>(nullable: false),
                    MId = table.Column<int>(nullable: false),
                    UsId = table.Column<int>(nullable: false),
                    SiId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_albumDetail", x => new { x.AId, x.MId, x.UsId, x.SiId });
                    table.ForeignKey(
                        name: "FK_albumDetail_album_AId",
                        column: x => x.AId,
                        principalTable: "album",
                        principalColumn: "AId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_albumDetail_song_MId",
                        column: x => x.MId,
                        principalTable: "song",
                        principalColumn: "MId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_albumDetail_singer_SiId",
                        column: x => x.SiId,
                        principalTable: "singer",
                        principalColumn: "SiId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_albumDetail_usersManager_UsId",
                        column: x => x.UsId,
                        principalTable: "usersManager",
                        principalColumn: "UsId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "comments",
                columns: table => new
                {
                    CoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsId = table.Column<int>(nullable: false),
                    MId = table.Column<int>(nullable: false),
                    Content = table.Column<string>(maxLength: 400, nullable: true),
                    CoStatus = table.Column<string>(maxLength: 10, nullable: true),
                    CoDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_comments", x => x.CoId);
                    table.ForeignKey(
                        name: "FK_comments_song_MId",
                        column: x => x.MId,
                        principalTable: "song",
                        principalColumn: "MId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_comments_usersManager_UsId",
                        column: x => x.UsId,
                        principalTable: "usersManager",
                        principalColumn: "UsId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "history",
                columns: table => new
                {
                    UsId = table.Column<int>(nullable: false),
                    MId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_history", x => new { x.UsId, x.MId });
                    table.ForeignKey(
                        name: "FK_history_song_MId",
                        column: x => x.MId,
                        principalTable: "song",
                        principalColumn: "MId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_history_usersManager_UsId",
                        column: x => x.UsId,
                        principalTable: "usersManager",
                        principalColumn: "UsId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "loveDetail",
                columns: table => new
                {
                    UsId = table.Column<int>(nullable: false),
                    MId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_loveDetail", x => new { x.UsId, x.MId });
                    table.ForeignKey(
                        name: "FK_loveDetail_song_MId",
                        column: x => x.MId,
                        principalTable: "song",
                        principalColumn: "MId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_loveDetail_usersManager_UsId",
                        column: x => x.UsId,
                        principalTable: "usersManager",
                        principalColumn: "UsId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "playlistDetail",
                columns: table => new
                {
                    UsId = table.Column<int>(nullable: false),
                    PId = table.Column<int>(nullable: false),
                    MId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_playlistDetail", x => new { x.MId, x.PId, x.UsId });
                    table.ForeignKey(
                        name: "FK_playlistDetail_song_MId",
                        column: x => x.MId,
                        principalTable: "song",
                        principalColumn: "MId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_playlistDetail_playlist_PId",
                        column: x => x.PId,
                        principalTable: "playlist",
                        principalColumn: "PId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_playlistDetail_usersManager_UsId",
                        column: x => x.UsId,
                        principalTable: "usersManager",
                        principalColumn: "UsId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_albumDetail_MId",
                table: "albumDetail",
                column: "MId");

            migrationBuilder.CreateIndex(
                name: "IX_albumDetail_SiId",
                table: "albumDetail",
                column: "SiId");

            migrationBuilder.CreateIndex(
                name: "IX_albumDetail_UsId",
                table: "albumDetail",
                column: "UsId");

            migrationBuilder.CreateIndex(
                name: "IX_categoryDetail_CaId",
                table: "categoryDetail",
                column: "CaId");

            migrationBuilder.CreateIndex(
                name: "IX_comments_MId",
                table: "comments",
                column: "MId");

            migrationBuilder.CreateIndex(
                name: "IX_comments_UsId",
                table: "comments",
                column: "UsId");

            migrationBuilder.CreateIndex(
                name: "IX_history_MId",
                table: "history",
                column: "MId");

            migrationBuilder.CreateIndex(
                name: "IX_loveDetail_MId",
                table: "loveDetail",
                column: "MId");

            migrationBuilder.CreateIndex(
                name: "IX_playlistDetail_PId",
                table: "playlistDetail",
                column: "PId");

            migrationBuilder.CreateIndex(
                name: "IX_playlistDetail_UsId",
                table: "playlistDetail",
                column: "UsId");

            migrationBuilder.CreateIndex(
                name: "IX_songDetail_MId",
                table: "songDetail",
                column: "MId");

            migrationBuilder.AddForeignKey(
                name: "FK_RoleClaims_Roles_RoleId",
                table: "RoleClaims",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserClaims_Users_UserId",
                table: "UserClaims",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserLogins_Users_UserId",
                table: "UserLogins",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoles_Roles_RoleId",
                table: "UserRoles",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoles_Users_UserId",
                table: "UserRoles",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserTokens_Users_UserId",
                table: "UserTokens",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RoleClaims_Roles_RoleId",
                table: "RoleClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_UserClaims_Users_UserId",
                table: "UserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_UserLogins_Users_UserId",
                table: "UserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRoles_Roles_RoleId",
                table: "UserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRoles_Users_UserId",
                table: "UserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_UserTokens_Users_UserId",
                table: "UserTokens");

            migrationBuilder.DropTable(
                name: "albumDetail");

            migrationBuilder.DropTable(
                name: "categoryDetail");

            migrationBuilder.DropTable(
                name: "comments");

            migrationBuilder.DropTable(
                name: "history");

            migrationBuilder.DropTable(
                name: "loveDetail");

            migrationBuilder.DropTable(
                name: "playlistDetail");

            migrationBuilder.DropTable(
                name: "songDetail");

            migrationBuilder.DropTable(
                name: "album");

            migrationBuilder.DropTable(
                name: "category");

            migrationBuilder.DropTable(
                name: "playlist");

            migrationBuilder.DropTable(
                name: "usersManager");

            migrationBuilder.DropTable(
                name: "song");

            migrationBuilder.DropTable(
                name: "singer");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserTokens",
                table: "UserTokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserRoles",
                table: "UserRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserLogins",
                table: "UserLogins");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserClaims",
                table: "UserClaims");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Roles",
                table: "Roles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RoleClaims",
                table: "RoleClaims");

            migrationBuilder.RenameTable(
                name: "UserTokens",
                newName: "AspNetUserTokens");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "AspNetUsers");

            migrationBuilder.RenameTable(
                name: "UserRoles",
                newName: "AspNetUserRoles");

            migrationBuilder.RenameTable(
                name: "UserLogins",
                newName: "AspNetUserLogins");

            migrationBuilder.RenameTable(
                name: "UserClaims",
                newName: "AspNetUserClaims");

            migrationBuilder.RenameTable(
                name: "Roles",
                newName: "AspNetRoles");

            migrationBuilder.RenameTable(
                name: "RoleClaims",
                newName: "AspNetRoleClaims");

            migrationBuilder.RenameIndex(
                name: "IX_UserRoles_RoleId",
                table: "AspNetUserRoles",
                newName: "IX_AspNetUserRoles_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_UserLogins_UserId",
                table: "AspNetUserLogins",
                newName: "IX_AspNetUserLogins_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserClaims_UserId",
                table: "AspNetUserClaims",
                newName: "IX_AspNetUserClaims_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_RoleClaims_RoleId",
                table: "AspNetRoleClaims",
                newName: "IX_AspNetRoleClaims_RoleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserTokens",
                table: "AspNetUserTokens",
                columns: new[] { "UserId", "LoginProvider", "Name" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUsers",
                table: "AspNetUsers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserRoles",
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserLogins",
                table: "AspNetUserLogins",
                columns: new[] { "LoginProvider", "ProviderKey" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserClaims",
                table: "AspNetUserClaims",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetRoles",
                table: "AspNetRoles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetRoleClaims",
                table: "AspNetRoleClaims",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
