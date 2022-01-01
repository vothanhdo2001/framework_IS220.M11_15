using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebMusic_Auth.Models
{
    public class AlbumModel
    {
        private int aId;
        private string aName;
        private string intro;
        private string photo;
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID Album")]
        public int AId { get => this.aId; set => this.aId = value; }
        [Display(Name = "Tên Album")]
        public string AName { get => this.aName; set => this.aName = value; }
        [Display(Name = "Giới thiệu")]
        public string Intro { get => this.intro; set => this.intro = value; }
        [Display(Name = "Ảnh")]
        public string Photo { get => this.photo; set => this.photo = value; }
        

        ICollection<AlbumDetailModel> AlbumDetailModels { get; set; }
    }
}
