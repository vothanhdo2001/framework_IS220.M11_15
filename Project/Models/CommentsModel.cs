using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Models
{
    public class CommentsModel
    {
        private int coId;
        private int usId;
        private int mId;
        private string content;
        private string coStatus;
        private DateTime coDate;

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CoId { get => this.coId; set => this.coId = value; }
        public int UsId { get => usId; set => usId = value; }
        public int MId { get => mId; set => mId = value; }

        [StringLength(400, ErrorMessage = "Too long!")]
        public string Content { get => content; set => content = value; }

        [StringLength(10, ErrorMessage = "Too long!")]
        public string CoStatus { get => coStatus; set => coStatus = value; }
        public DateTime CoDate { get => coDate; set => coDate = value; }

        [ForeignKey("usId")]
        public UsersModel User { get; set; }

        [ForeignKey("mId")]
        public SongModel Song { get; set; }
        
    }
}