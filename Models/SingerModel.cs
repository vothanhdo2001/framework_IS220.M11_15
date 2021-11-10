using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebMusic.Models
{
    public class SingerModel
    {
        [Key]
        private int SiId { get => SiId; set => SiId = value; }
        private string SiName { get => SiName; set => SiName = value; }
        private string Photo { get => Photo; set => Photo = value; }
        private string Story { get => Story; set => Story = value; }
        
        public ICollection<SongDetailModel> SongDetailModels { get; set; }
        public ICollection<AlbumDetailModel> AlbumDetailModels { get; set; }
    }
}
