using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebMusic.Models
{
    public class LoveDetailModel
    {
        private int usId;
        private int mId;
<<<<<<< HEAD
        [Display(Name = "ID User")]
        public int UsId { get => this.usId; set => this.usId = value; }
        [Display(Name = "ID Bài Hát")]
        public int MId { get => this.mId; set => this.mId = value; }
        
        [ForeignKey("UsId")]
        [Display(Name = "ID User")]
        public UsersModel User { get; set; }
        [ForeignKey("MId")]
        [Display(Name = "ID Bài Hát")]
=======
        public int UsId { get => this.usId; set => this.usId = value; }
        [ForeignKey("UsId")]

        public int MId { get => this.mId; set => this.mId = value; }
        [ForeignKey("MId")]

        public UsersModel User { get; set; }
>>>>>>> master
        public SongModel Song { get; set; }
    }
}
