using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMusic.Models;

namespace WebMusic.Data
{
    public class MusicContext:DbContext
    {
        public MusicContext(DbContextOptions<MusicContext> options) : base(options)
        {

        }
        public DbSet<UsersModel> UsersModel { get; set; }
        public DbSet<AlbumModel> AlbumModel { get; set; }
        public DbSet<SongDetailModel> SongDetailModel { get; set; }
        public DbSet<SingerModel> SingerModel { get; set; }
        public DbSet<AlbumDetailModel> AlbumDetailModel { get; set; }
        public DbSet<LoveDetailModel> LoveDetailModel { get; set; }
        public DbSet<LoveDetailCommentModel> LoveDetailCommentModel { get; set; }
        public DbSet<SongModel> SongModel { get; set; }
        public DbSet<PlaylistModel> PlaylistModel { get; set; }
        public DbSet<PlaylistDetailModel> PlaylistDetailModel { get; set; }
        public DbSet<CategoryModel> CategoryModel { get; set; }
        public DbSet<CategoryDetailModel> CategoryDetailModel { get; set; }
        public DbSet<CommentsModel> CommentsModel { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<UsersModel>().ToTable("users").HasKey(c => c.UsId); 
            modelBuilder.Entity<AlbumModel>().ToTable("album").HasKey(c => c.AId);
            modelBuilder.Entity<SongDetailModel>().ToTable("songDetail").HasKey(c => new { c.SiId, c.MId }); 
            modelBuilder.Entity<SingerModel>().ToTable("singer").HasKey(c => c.SiId);
            modelBuilder.Entity<AlbumDetailModel>().ToTable("albumDetail").HasKey(c => new { c.AId, c.MId, c.UsId, c.SiId });
            modelBuilder.Entity<LoveDetailModel>().ToTable("loveDetail").HasKey(c => new { c.UsId, c.MId }); ;
            modelBuilder.Entity<LoveDetailCommentModel>().ToTable("loveDetailComment").HasKey(c => new { c.UsId, c.CoId });
            modelBuilder.Entity<SongModel>().ToTable("song").HasKey(c => c.MId);
            modelBuilder.Entity<PlaylistModel>().ToTable("playlist").HasKey(c => c.PId);
            modelBuilder.Entity<PlaylistDetailModel>().ToTable("playlistDetail").HasKey(c => new { c.MId, c.PId, c.UsId });
            modelBuilder.Entity<CategoryModel>().ToTable("category").HasKey(c => c.CaId);
            modelBuilder.Entity<CategoryDetailModel>().ToTable("categoryDetail").HasKey(c => new { c.MId, c.CaId });
            modelBuilder.Entity<CommentsModel>().ToTable("comments").HasKey(c => c.CoId);
        }

    }
}
