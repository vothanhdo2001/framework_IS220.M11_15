using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebMusic_Auth.Models
{
    public class SongModel
    {
        private int mId;
        private string song;
        private string author;
        private string duration;
        private int nviews;
        private string lyrics;
        private string files;
        private string photo;

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID")]
        public int MId { get => mId; set => mId = value; }
        [Display(Name = "Tên Bài Hát")]

        [StringLength(50, ErrorMessage = "Too long!")]
        public string Song { get => song; set => song = value; }
        [Display(Name = "Tác Giả")]

        [StringLength(100, ErrorMessage = "Too long!")]
        public string Author { get => author; set => author = value; }
        [Display(Name = "Thời Lượng")]
        [StringLength(20, ErrorMessage = "Too long!")]
        [Column("long")]
        public string Duration { get => duration; set => duration = value; }
        [Display(Name = "Số Lượt Nghe")]
        public int Nviews { get => nviews; set => nviews = value; }
        [Display(Name = "Lời")]
        [StringLength(4000, ErrorMessage = "Too long!")]
        public string Lyrics { get => lyrics; set => lyrics = value; }
        [Display(Name = "")]
        [StringLength(500, ErrorMessage = "Too long!")]
        public string Files { get => files; set => files = value; }
        [Display(Name = "Ảnh")]
        [StringLength(500, ErrorMessage = "Too long!")]
        public string Photo { get => photo; set => photo = value; }

        public ICollection<PlaylistDetailModel> PlaylistDetails { get; set; }
        public ICollection<CommentsModel> Comments { get; set; }
        public ICollection<AlbumDetailModel> AlbumDetails { get; set; }
        public ICollection<LoveDetailModel> LoveDetails { get; set; }
        public ICollection<SongDetailModel> SongDetails { get; set; }
        public ICollection<CategoryDetailModel> CategoryDetails { get; set; }
        
    }
}