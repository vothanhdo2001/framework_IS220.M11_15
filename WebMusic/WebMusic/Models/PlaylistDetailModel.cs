using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebMusic.Models
{
    public class PlaylistDetailModel
    {
        private int usId;
        private int pId;
        private int mId;
<<<<<<< HEAD
        [Display(Name = "ID User")]
        public int UsId { get => usId; set => usId = value; }
        [Display(Name = "ID PlayList")]
        public int PId { get => pId; set => pId = value; }
        [Display(Name = "ID Bài Hát")]
        public int MId { get => mId; set => mId = value; }

        [ForeignKey("UsId")]
        [Display(Name = "ID User")]
        public UsersModel User { get; set; }

        [ForeignKey("PId")]
        [Display(Name = "ID PlayList")]
        public PlaylistModel Playlist { get; set; }

        [ForeignKey("MId")]
        [Display(Name = "ID Bài Hát")]
=======

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int UsId { get => usId; set => usId = value; }
        public int PId { get => pId; set => pId = value; }
        public int MId { get => mId; set => mId = value; }

        [ForeignKey("UsId")]
        public UsersModel User { get; set; }

        [ForeignKey("PId")]
        public PlaylistModel Playlist { get; set; }

        [ForeignKey("MId")]
>>>>>>> master
        public SongModel Song { get; set; }
    }
}