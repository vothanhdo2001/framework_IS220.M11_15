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
        private int aId;
        private int mId;
        private int usId;
        private int siId;
        public int AId { get => this.aId; set => this.aId = value; }
        [ForeignKey("AId")]

        public int MId { get => this.mId; set => this.mId = value; }
        [ForeignKey("MId")]

        public int UsId { get => this.usId; set => this.usId = value; }
        [ForeignKey("UsId")]

        public int SiId { get => this.siId; set => this.siId = value; }
        [ForeignKey("SiId")]

        public AlbumModel Album { get; set; }
        public SingerModel Singer { get; set; }
        public UsersModel User { get; set; }
        public SongModel Song { get; set; }
    }
}
