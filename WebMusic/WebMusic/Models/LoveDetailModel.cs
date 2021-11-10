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
        public int UsId { get => this.usId; set => this.usId = value; }
        [ForeignKey("UsId")]

        public int MId { get => this.mId; set => this.mId = value; }
        [ForeignKey("MId")]

        public UsersModel User { get; set; }
        public SongModel Song { get; set; }
    }
}
