using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebMusic_Auth.Models
{
    public class PlaylistModel
    {
        private int pId;
        private string pName;
        private DateTime pDate;
        private string pStatus;

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID Play List")]
        public int PId { get => pId; set => pId = value; }
        [Display(Name = "Tên PlayList")]
        [StringLength(50, ErrorMessage = "Too long!")]
        public string PName { get => pName; set => pName = value; }
        [Display(Name = "Ngày Tạo")]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyy}", ApplyFormatInEditMode = true)]
        public DateTime PDate { get => pDate; set => pDate = value; }
        [Display(Name = "Trạng Thái")]
        [StringLength(10, ErrorMessage = "Too long!")]
        public string PStatus { get => pStatus; set => pStatus = value; }

        public ICollection<PlaylistDetailModel> PlaylistDetails { get; set; }
    }
}
