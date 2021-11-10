using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        public int SiId { get => this.siId; set => this.siId = value; }
        public string SiName { get => this.siName; set => this.siName = value; }
        public string Photo { get => this.photo; set => this.photo = value; }
        public string Story { get => this.story; set => this.story = value; }
        
        public ICollection<SongDetailModel> SongDetailModels { get; set; }
        public ICollection<AlbumDetailModel> AlbumDetailModels { get; set; }
    }
}
