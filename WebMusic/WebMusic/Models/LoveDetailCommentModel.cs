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
        public int UsId { get => this.usId; set => this.usId = value; }
        [ForeignKey("UsId")]

        public int CoId { get => this.coId; set => this.coId = value; }
        [ForeignKey("CoId")]

        public UsersModel User { get; set; }
        public CommentsModel Comment { get; set; }
    }
}
