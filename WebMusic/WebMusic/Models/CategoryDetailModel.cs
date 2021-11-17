using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebMusic.Models
{
    public class CategoryDetailModel
    {
        private int caId;
        private int mId;
<<<<<<< HEAD
        [Display(Name = "ID Thể Loại")]
        public int CaId { get => this.caId; set => this.caId = value; }
        [Display(Name = "ID Bài Hát")]
        public int MId { get => this.mId; set => this.mId = value; }

        [ForeignKey("CaId")]
        [Display(Name = "ID Thể Loại")]
        public CategoryModel Category { get; set; }

        [ForeignKey("MId")]
        [Display(Name = "ID Bài Hát")]
=======
        
        public int CaId { get => this.caId; set => this.caId = value; }
        public int MId { get => this.mId; set => this.mId = value; }

        [ForeignKey("CaId")]
        public CategoryModel Category { get; set; }

        [ForeignKey("MId")]
>>>>>>> master
        public SongModel Song { get; set; }
    }
}