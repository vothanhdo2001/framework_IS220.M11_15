using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMusic_Auth.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace WebMusic_Auth.Data
{
    public class MusicContext:IdentityDbContext
    {
        public MusicContext(DbContextOptions<MusicContext> options) : base(options)
        {

        }
        public DbSet<UsersManagerModel> UsersModel { get; set; }
        public DbSet<AlbumModel> AlbumModel { get; set; }
        public DbSet<SongDetailModel> SongDetailModel { get; set; }
        public DbSet<SingerModel> SingerModel { get; set; }
        public DbSet<AlbumDetailModel> AlbumDetailModel { get; set; }
        public DbSet<LoveDetailModel> LoveDetailModel { get; set; }
        public DbSet<SongModel> SongModel { get; set; }
        public DbSet<PlaylistModel> PlaylistModel { get; set; }
        public DbSet<PlaylistDetailModel> PlaylistDetailModel { get; set; }
        public DbSet<CategoryModel> CategoryModel { get; set; }
        public DbSet<CategoryDetailModel> CategoryDetailModel { get; set; }
        public DbSet<CommentsModel> CommentsModel { get; set; }
        public DbSet<HistoryModel> HistoryModel { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                var tableName = entityType.GetTableName();
                if (tableName.StartsWith("AspNet"))
                {
                    entityType.SetTableName(tableName.Substring(6));
                }
            }
            modelBuilder.Entity<UsersManagerModel>().ToTable("usersManager").HasKey(c => c.UsId); 
            modelBuilder.Entity<AlbumModel>().ToTable("album").HasKey(c => c.AId);
            modelBuilder.Entity<SongDetailModel>().ToTable("songDetail").HasKey(c => new { c.SiId, c.MId }); 
            modelBuilder.Entity<SingerModel>().ToTable("singer").HasKey(c => c.SiId);
            modelBuilder.Entity<AlbumDetailModel>().ToTable("albumDetail").HasKey(c => new { c.AId, c.MId, c.UsId, c.SiId });
            modelBuilder.Entity<LoveDetailModel>().ToTable("loveDetail").HasKey(c => new { c.UsId, c.MId }); ;
            modelBuilder.Entity<SongModel>().ToTable("song").HasKey(c => c.MId);
            modelBuilder.Entity<PlaylistModel>().ToTable("playlist").HasKey(c => c.PId);
            modelBuilder.Entity<PlaylistDetailModel>().ToTable("playlistDetail").HasKey(c => new { c.MId, c.PId, c.UsId });
            modelBuilder.Entity<CategoryModel>().ToTable("category").HasKey(c => c.CaId);
            modelBuilder.Entity<CategoryDetailModel>().ToTable("categoryDetail").HasKey(c => new { c.MId, c.CaId });
            modelBuilder.Entity<CommentsModel>().ToTable("comments").HasKey(c => c.CoId);
            modelBuilder.Entity<HistoryModel>().ToTable("history").HasKey(c => new { c.UsId, c.MId }); ;
        }

    }
}
