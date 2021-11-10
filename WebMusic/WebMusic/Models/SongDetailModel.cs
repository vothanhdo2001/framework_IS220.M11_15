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

        public int SiId { get => this.siId; set => this.siId = value; }
        [ForeignKey("SiId")]

        public int MId { get => this.mId; set => this.mId = value; }
        [ForeignKey("MId")]

        public SingerModel Singer { get; set; }
        public SongModel Song { get; set; }
    }
}
