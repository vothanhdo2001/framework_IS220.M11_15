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
        [Key]
        private int SiId { get => SiId; set => SiId = value; }
        [ForeignKey("SiId")]

        [Key]
        private int MId { get => MId; set => MId = value; }
        [ForeignKey("MId")]

        public SingerModel Singer { get; set; }
        public SongModel Song { get; set; }
    }
}
