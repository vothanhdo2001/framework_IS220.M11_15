using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebMusic_Auth.Models
{
    public class PlaylistDetailModel
    {
        
        private int pId;
        private int mId;

        
        [Display(Name = "ID PlayList")]
        public int PId { get => pId; set => pId = value; }
        [Display(Name = "ID Bài Hát")]
        public int MId { get => mId; set => mId = value; }


        [ForeignKey("PId")]
        [Display(Name = "ID PlayList")]
        public PlaylistModel Playlist { get; set; }

        [ForeignKey("MId")]
        [Display(Name = "ID Bài Hát")]

        public SongModel Song { get; set; }
    }
}