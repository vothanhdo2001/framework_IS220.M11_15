using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebMusic.Models
{
    public class SingerModel
    {
        private int siId;
        private string siName;
        private string photo;
        private string story;

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID Ca Sĩ")]
        public int SiId { get => this.siId; set => this.siId = value; }
        [Display(Name = "Tên Ca Sĩ")]
        public string SiName { get => this.siName; set => this.siName = value; }
        [Display(Name = "Ảnh")]
        public string Photo { get => this.photo; set => this.photo = value; }
        public string Story { get => this.story; set => this.story = value; }
        
        public ICollection<SongDetailModel> SongDetailModels { get; set; }
        public ICollection<AlbumDetailModel> AlbumDetailModels { get; set; }
    }
}
