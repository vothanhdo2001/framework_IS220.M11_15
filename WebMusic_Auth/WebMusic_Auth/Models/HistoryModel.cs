﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
namespace WebMusic_Auth.Models
{
    public class HistoryModel
    {
        private int usId;
        private int mId;

        [Display(Name = "ID User")]
        public int UsId { get => this.usId; set => this.usId = value; }
        [Display(Name = "ID Bài Hát")]
        public int MId { get => this.mId; set => this.mId = value; }

        [ForeignKey("UsId")]
        [Display(Name = "ID User")]
        public UsersManagerModel User { get; set; }
        [ForeignKey("MId")]
        [Display(Name = "ID Bài Hát")]

        public SongModel Song { get; set; }
    }
}
