using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebMusic.Models
{
    public class LoveDetailCommentModel
    {
        private int usId;
        private int coId;
        [Display(Name = "ID User")]
        public int UsId { get => this.usId; set => this.usId = value; }
        [Display(Name = "ID Comment")]
        public int CoId { get => this.coId; set => this.coId = value; }
        
        [ForeignKey("UsId")]
        [Display(Name = "ID User")]
        public UsersModel User { get; set; }
        [ForeignKey("CoId")]
        [Display(Name = "ID Comment")]
        public CommentsModel Comment { get; set; }
    }
}
