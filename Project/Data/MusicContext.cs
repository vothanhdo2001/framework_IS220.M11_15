using Microsoft.EntityFrameworkCore;
using Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Data
{
    public class MusicContext : DbContext
    {
        public MusicContext(DbContextOptions<MusicContext>options) : base(options)
        {
        }

        public DbSet<SongModel> SongModel { get; set; }
        public DbSet<PlaylistModel> PlaylistModel { get; set; }
        public DbSet<PlaylistDetailModel> PlaylistDetailModel { get; set; }
        public DbSet<CategoryModel> CategoryModel { get; set; }
        public DbSet<CategoryDetailModel> CategoryDetailModel { get; set; }
        public DbSet<CommentsModel> CommentsModel { get; set; }

        protected override void OnModelCreating(ModelBuilder model)
        {
            model.Entity<SongModel>().ToTable("song").HasKey(c => c.MId);
            model.Entity<PlaylistModel>().ToTable("playlist").HasKey(c => c.PId);
            model.Entity<PlaylistDetailModel>().ToTable("playlistDetail").HasKey(c => new { c.MId, c.PId, c.UsId });
            model.Entity<CategoryModel>().ToTable("category").HasKey(c => c.CaId);
            model.Entity<CategoryDetailModel>().ToTable("categoryDetail").HasKey(c => new { c.MId, c.CaId });
            model.Entity<CommentsModel>().ToTable("comments").HasKey(c => c.CoId);
        }
    }
}
