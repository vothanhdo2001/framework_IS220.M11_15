﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebMusic.Models
{
    public class AlbumModel
    {
        private int aId;
        private string aName;
        private DateTime aDate;
        private string sName;
        private string intro;
        private string photo;
        private string aStatus;

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
<<<<<<< HEAD
        [Display(Name = "ID Album")]
        public int AId { get => this.aId; set => this.aId = value; }
        [Display(Name = "Tên Album")]
        public string AName { get => this.aName; set => this.aName = value; }
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Ngày Tạo")]
        public DateTime ADate { get => this.aDate; set => this.aDate = value; }
        [Display(Name = "Tên Ca Sĩ")]
        public string SName { get => this.sName; set => this.sName = value; }
        [Display(Name = "Giới thiệu")]
        public string Intro { get => this.intro; set => this.intro = value; }
        [Display(Name = "Ảnh")]
        public string Photo { get => this.photo; set => this.photo = value; }
        [Display(Name = "Trạng Thái")]
=======
        public int AId { get => this.aId; set => this.aId = value; }
        public string AName { get => this.aName; set => this.aName = value; }
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime ADate { get => this.aDate; set => this.aDate = value; }
        public string SName { get => this.sName; set => this.sName = value; }
        public string Intro { get => this.intro; set => this.intro = value; }
        public string Photo { get => this.photo; set => this.photo = value; }
>>>>>>> master
        public string AStatus { get => this.aStatus; set => this.aStatus = value; }
        ICollection<AlbumDetailModel> AlbumDetailModels { get; set; }
    }
}
