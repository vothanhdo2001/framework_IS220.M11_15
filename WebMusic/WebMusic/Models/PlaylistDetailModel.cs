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
        public SongModel Song { get; set; }
    }
}