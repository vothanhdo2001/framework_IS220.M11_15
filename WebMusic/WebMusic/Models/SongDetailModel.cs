using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebMusic.Models
{
    public class SongDetailModel
    {
        private int siId;
        private int mId;
        [Display(Name = "ID Ca Sĩ")]
        public int SiId { get => this.siId; set => this.siId = value; }
        [Display(Name = "ID Bài Hát")]
        public int MId { get => this.mId; set => this.mId = value; }
        
        [ForeignKey("SiId")]
        [Display(Name = "ID Ca Sĩ")]
        public SingerModel Singer { get; set; }
        [ForeignKey("MId")]
        [Display(Name = "ID Bài Hát")]
        public SongModel Song { get; set; }
    }
}
