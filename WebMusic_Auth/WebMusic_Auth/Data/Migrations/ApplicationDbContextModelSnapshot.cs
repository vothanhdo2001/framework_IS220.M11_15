﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebMusic_Auth.Data;

namespace WebMusic_Auth.Data.Migrations
{
    [DbContext(typeof(MusicContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.21")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("RoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("UserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("UserTokens");
                });

            modelBuilder.Entity("WebMusic_Auth.Models.AlbumDetailModel", b =>
                {
                    b.Property<int>("AId")
                        .HasColumnType("int");

                    b.Property<int>("MId")
                        .HasColumnType("int");

                    b.Property<int>("UsId")
                        .HasColumnType("int");

                    b.Property<int>("SiId")
                        .HasColumnType("int");

                    b.HasKey("AId", "MId", "UsId", "SiId");

                    b.HasIndex("MId");

                    b.HasIndex("SiId");

                    b.HasIndex("UsId");

                    b.ToTable("albumDetail");
                });

            modelBuilder.Entity("WebMusic_Auth.Models.AlbumModel", b =>
                {
                    b.Property<int>("AId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("ADate")
                        .HasColumnType("datetime2");

                    b.Property<string>("AName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Intro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Photo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AId");

                    b.ToTable("album");
                });

            modelBuilder.Entity("WebMusic_Auth.Models.CategoryDetailModel", b =>
                {
                    b.Property<int>("MId")
                        .HasColumnType("int");

                    b.Property<int>("CaId")
                        .HasColumnType("int");

                    b.HasKey("MId", "CaId");

                    b.HasIndex("CaId");

                    b.ToTable("categoryDetail");
                });

            modelBuilder.Entity("WebMusic_Auth.Models.CategoryModel", b =>
                {
                    b.Property<int>("CaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CaName")
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.HasKey("CaId");

                    b.ToTable("category");
                });

            modelBuilder.Entity("WebMusic_Auth.Models.CommentsModel", b =>
                {
                    b.Property<int>("CoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CoDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CoStatus")
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(400)")
                        .HasMaxLength(400);

                    b.Property<int>("MId")
                        .HasColumnType("int");

                    b.Property<int>("UsId")
                        .HasColumnType("int");

                    b.HasKey("CoId");

                    b.HasIndex("MId");

                    b.HasIndex("UsId");

                    b.ToTable("comments");
                });

            modelBuilder.Entity("WebMusic_Auth.Models.HistoryModel", b =>
                {
                    b.Property<int>("UsId")
                        .HasColumnType("int");

                    b.Property<int>("MId")
                        .HasColumnType("int");

                    b.HasKey("UsId", "MId");

                    b.HasIndex("MId");

                    b.ToTable("history");
                });

            modelBuilder.Entity("WebMusic_Auth.Models.LoveDetailModel", b =>
                {
                    b.Property<int>("UsId")
                        .HasColumnType("int");

                    b.Property<int>("MId")
                        .HasColumnType("int");

                    b.HasKey("UsId", "MId");

                    b.HasIndex("MId");

                    b.ToTable("loveDetail");
                });

            modelBuilder.Entity("WebMusic_Auth.Models.PlaylistDetailModel", b =>
                {
                    b.Property<int>("MId")
                        .HasColumnType("int");

                    b.Property<int>("PId")
                        .HasColumnType("int");

                    b.Property<int>("UsId")
                        .HasColumnType("int");

                    b.HasKey("MId", "PId", "UsId");

                    b.HasIndex("PId");

                    b.HasIndex("UsId");

                    b.ToTable("playlistDetail");
                });

            modelBuilder.Entity("WebMusic_Auth.Models.PlaylistModel", b =>
                {
                    b.Property<int>("PId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("PDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PName")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("PStatus")
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.HasKey("PId");

                    b.ToTable("playlist");
                });

            modelBuilder.Entity("WebMusic_Auth.Models.SingerModel", b =>
                {
                    b.Property<int>("SiId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Photo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SiName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Story")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SiId");

                    b.ToTable("singer");
                });

            modelBuilder.Entity("WebMusic_Auth.Models.SongDetailModel", b =>
                {
                    b.Property<int>("SiId")
                        .HasColumnType("int");

                    b.Property<int>("MId")
                        .HasColumnType("int");

                    b.HasKey("SiId", "MId");

                    b.HasIndex("MId");

                    b.ToTable("songDetail");
                });

            modelBuilder.Entity("WebMusic_Auth.Models.SongModel", b =>
                {
                    b.Property<int>("MId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Author")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Duration")
                        .HasColumnName("long")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("Files")
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<string>("Lyrics")
                        .HasColumnType("nvarchar(4000)")
                        .HasMaxLength(4000);

                    b.Property<int>("Nviews")
                        .HasColumnType("int");

                    b.Property<string>("Photo")
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<string>("Song")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("MId");

                    b.ToTable("song");
                });

            modelBuilder.Entity("WebMusic_Auth.Models.UsersManagerModel", b =>
                {
                    b.Property<int>("UsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("IdLogin")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NickName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Photo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sex")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UsRank")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UsStatus")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UsId");

                    b.ToTable("usersManager");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebMusic_Auth.Models.AlbumDetailModel", b =>
                {
                    b.HasOne("WebMusic_Auth.Models.AlbumModel", "Album")
                        .WithMany()
                        .HasForeignKey("AId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebMusic_Auth.Models.SongModel", "Song")
                        .WithMany("AlbumDetails")
                        .HasForeignKey("MId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebMusic_Auth.Models.SingerModel", "Singer")
                        .WithMany("AlbumDetailModels")
                        .HasForeignKey("SiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebMusic_Auth.Models.UsersManagerModel", "User")
                        .WithMany("AlbumDetailModels")
                        .HasForeignKey("UsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebMusic_Auth.Models.CategoryDetailModel", b =>
                {
                    b.HasOne("WebMusic_Auth.Models.CategoryModel", "Category")
                        .WithMany("CategoryDetailModels")
                        .HasForeignKey("CaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebMusic_Auth.Models.SongModel", "Song")
                        .WithMany("CategoryDetails")
                        .HasForeignKey("MId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebMusic_Auth.Models.CommentsModel", b =>
                {
                    b.HasOne("WebMusic_Auth.Models.SongModel", "Song")
                        .WithMany("Comments")
                        .HasForeignKey("MId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebMusic_Auth.Models.UsersManagerModel", "User")
                        .WithMany("CommentsModels")
                        .HasForeignKey("UsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebMusic_Auth.Models.HistoryModel", b =>
                {
                    b.HasOne("WebMusic_Auth.Models.SongModel", "Song")
                        .WithMany()
                        .HasForeignKey("MId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebMusic_Auth.Models.UsersManagerModel", "User")
                        .WithMany()
                        .HasForeignKey("UsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebMusic_Auth.Models.LoveDetailModel", b =>
                {
                    b.HasOne("WebMusic_Auth.Models.SongModel", "Song")
                        .WithMany("LoveDetails")
                        .HasForeignKey("MId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebMusic_Auth.Models.UsersManagerModel", "User")
                        .WithMany("LoveDetailModels")
                        .HasForeignKey("UsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebMusic_Auth.Models.PlaylistDetailModel", b =>
                {
                    b.HasOne("WebMusic_Auth.Models.SongModel", "Song")
                        .WithMany("PlaylistDetails")
                        .HasForeignKey("MId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebMusic_Auth.Models.PlaylistModel", "Playlist")
                        .WithMany("PlaylistDetails")
                        .HasForeignKey("PId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebMusic_Auth.Models.UsersManagerModel", "User")
                        .WithMany("PlaylistDetailModels")
                        .HasForeignKey("UsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebMusic_Auth.Models.SongDetailModel", b =>
                {
                    b.HasOne("WebMusic_Auth.Models.SongModel", "Song")
                        .WithMany("SongDetails")
                        .HasForeignKey("MId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebMusic_Auth.Models.SingerModel", "Singer")
                        .WithMany("SongDetailModels")
                        .HasForeignKey("SiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
