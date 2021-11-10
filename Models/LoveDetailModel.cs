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
        [Key]
        private int UsId { get => UsId; set => UsId = value; }
        [ForeignKey("UsId")]

        [Key]
        private int MId { get => MId; set => MId = value; }
        [ForeignKey("MId")]

        public UsersModel User { get; set; }
        public SonglModel Song { get; set; }
    }
}
