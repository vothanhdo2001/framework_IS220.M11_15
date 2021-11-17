using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebMusic.Models
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
<<<<<<< HEAD
        [Display(Name = "ID Comment")]
        public int CoId { get => this.coId; set => this.coId = value; }
        [Display(Name = "ID User")]
        public int UsId { get => usId; set => usId = value; }
        [Display(Name = "ID Bài Hát")]
        public int MId { get => mId; set => mId = value; }

        [StringLength(400, ErrorMessage = "Too long!")]
        [Display(Name = "Nội dung")]
        public string Content { get => content; set => content = value; }
        [Display(Name = "Trạng Thái")]
=======
        public int CoId { get => this.coId; set => this.coId = value; }
        public int UsId { get => usId; set => usId = value; }
        public int MId { get => mId; set => mId = value; }

        [StringLength(400, ErrorMessage = "Too long!")]
        public string Content { get => content; set => content = value; }

>>>>>>> master
        [StringLength(10, ErrorMessage = "Too long!")]
        public string CoStatus { get => coStatus; set => coStatus = value; }

        [DisplayFormat(DataFormatString = "{0:dd-MM-yyy}", ApplyFormatInEditMode = true)]
<<<<<<< HEAD
        [Display(Name = "Ngày Tạo")]
        public DateTime CoDate { get => coDate; set => coDate = value; }

        [ForeignKey("UsId")]
        [Display(Name = "ID User")]
        public UsersModel User { get; set; }

        [ForeignKey("MId")]
        [Display(Name = "ID Bài Hát")]
=======
        public DateTime CoDate { get => coDate; set => coDate = value; }

        [ForeignKey("UsId")]
        public UsersModel User { get; set; }

        [ForeignKey("MId")]
>>>>>>> master
        public SongModel Song { get; set; }
        
    }
}