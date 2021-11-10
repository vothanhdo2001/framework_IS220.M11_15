﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Models
{
    public class CategoryModel
    {
        private int caId;
        private string caName;

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CaId { get => caId; set => caId = value; }

        [StringLength(30, ErrorMessage = "Too long!")]
        public string CaName { get => this.caName; set => this.caName = value; }

        public ICollection<CategoryDetailModel> CategoryDetailModels { get; set; }
    }
}
