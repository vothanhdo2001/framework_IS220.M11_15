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
        [Key]
        private int UsId { get => UsId; set => UsId = value; }
        [ForeignKey("UsId")]

        [Key]
        private int CoId { get => CoId; set => CoId = value; }
        [ForeignKey("CoId")]

        public UsersModel User { get; set; }
        public CommentsModel Comment { get; set; }
    }
}
