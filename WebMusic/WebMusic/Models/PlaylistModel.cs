﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebMusic.Models
{
    public class PlaylistModel
    {
        private int pId;
        private string pName;
        private DateTime pDate;
        private string pStatus;

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PId { get => pId; set => pId = value; }

        [StringLength(50, ErrorMessage = "Too long!")]
        public string PName { get => pName; set => pName = value; }

        [DisplayFormat(DataFormatString = "{0:dd-MM-yyy}", ApplyFormatInEditMode = true)]
        public DateTime PDate { get => pDate; set => pDate = value; }

        [StringLength(10, ErrorMessage = "Too long!")]
        public string PStatus { get => pStatus; set => pStatus = value; }

        public ICollection<PlaylistDetailModel> PlaylistDetails { get; set; }
    }
}
