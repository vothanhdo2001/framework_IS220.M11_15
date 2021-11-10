using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebMusic.Models
{
    public class AlbumDetailModel
    {
        [Key]
        private int AId { get => AId; set => AId = value; }
        [ForeignKey("AId")]

        [Key]
        private int MId { get => MId; set => MId = value; }
        [ForeignKey("MId")]

        [Key]
        private int UsId { get => UsId; set => UsId = value; }
        [ForeignKey("UsId")]

        [Key]
        private int SiId { get => SiId; set => SiId = value; }
        [ForeignKey("SiId")]

        public AlbumModel Album { get; set; }
        public SingerModel Singer { get; set; }
        public UsersModel User { get; set; }
        public SongModel Song { get; set; }
    }
}
