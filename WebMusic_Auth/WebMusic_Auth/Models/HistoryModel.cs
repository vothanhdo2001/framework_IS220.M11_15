using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
namespace WebMusic_Auth.Models
{
    public class HistoryModel
    {
        private string usId;
        private int mId;
        [Key]
        [Display(Name = "ID User")]
        public string UsId { get => usId; set => usId = value; }
        [Key]
        [Display(Name = "ID Bài Hát")]
        public int MId { get => this.mId; set => this.mId = value; }

        [ForeignKey("UsId")]
        [Display(Name = "ID User")]
        public AppUser User { get; set; }

        [ForeignKey("MId")]
        [Display(Name = "ID Bài Hát")]

        public SongModel Song { get; set; }
    }
}
