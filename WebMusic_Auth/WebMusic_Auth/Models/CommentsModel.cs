using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebMusic_Auth.Models
{
    public class CommentsModel
    {
        private int coId;
        private string usId;
        private int mId;
        private string content;
        private string coStatus;

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        [Display(Name = "ID Comment")]
        public int CoId { get => this.coId; set => this.coId = value; }
        [Display(Name = "ID User")]
        public string UsId { get => usId; set => usId = value; }
        [Display(Name = "ID Bài Hát")]
        public int MId { get => mId; set => mId = value; }

        [StringLength(400, ErrorMessage = "Too long!")]
        [Display(Name = "Nội dung")]
        public string Content { get => content; set => content = value; }
        [Display(Name = "Trạng Thái")]
        [StringLength(10, ErrorMessage = "Too long!")]
        public string CoStatus { get => coStatus; set => coStatus = value; }

        [ForeignKey("UsId")]
        [Display(Name = "ID User")]
        public AppUser User { get; set; }


        [ForeignKey("MId")]
        [Display(Name = "ID Bài Hát")]

        public SongModel Song { get; set; }
        
    }
}