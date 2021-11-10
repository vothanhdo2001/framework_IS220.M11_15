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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UsersModel>().ToTable("users").HasKey(c => c.UsId); 
            modelBuilder.Entity<AlbumModel>().ToTable("album").HasKey(c => c.AId);
            modelBuilder.Entity<SongDetailModel>().ToTable("songDetail").HasKey(c => new { c.SiId, c.MId }); 
            modelBuilder.Entity<SingerModel>().ToTable("singer").HasKey(c => c.SiId);
            modelBuilder.Entity<AlbumDetailModel>().ToTable("albumDetail").HasKey(c => new { c.AId, c.MId, c.UsId, c.SiId }); 
            modelBuilder.Entity<LoveDetailModel>().ToTable("loveDetail").HasKey(c => new { c.UsId, c.MId }); ;
            modelBuilder.Entity<LoveDetailCommentModel>().ToTable("loveDetailComment").HasKey(c => new { c.UsId, c.CoId }); 
        }

    }
}
