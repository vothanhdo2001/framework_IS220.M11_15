using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Models
{
    public class CategoryDetailModel
    {
        private int caId;
        private int mId;
        
        public int CaId { get => this.caId; set => this.caId = value; }
        public int MId { get => this.mId; set => this.mId = value; }

        [ForeignKey("CaId")]
        public CategoryModel Category { get; set; }

        [ForeignKey("MId")]
        public SongModel Song { get; set; }
    }
}