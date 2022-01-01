using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebMusic_Auth.Models
{
    public class AlbumDetailModel
    {
        private int aId;
        private int mId;
        private int siId;

        [Display(Name = "ID Album")]
        public int AId { get => this.aId; set => this.aId = value; }
        [Display(Name = "ID Bài Hát")]
        public int MId { get => this.mId; set => this.mId = value; }

        [Display(Name = "ID Ca Sĩ")]
        public int SiId { get => this.siId; set => this.siId = value; }
        
        [ForeignKey("AId")]
        [Display(Name = "ID Album")]
        public AlbumModel Album { get; set; }
        [ForeignKey("SiId")]
        [Display(Name = "ID Ca Sĩ")]
        public SingerModel Singer { get; set; }
        [ForeignKey("MId")]
        [Display(Name = "ID Bài Hát")]

        public SongModel Song { get; set; }
    }
}
