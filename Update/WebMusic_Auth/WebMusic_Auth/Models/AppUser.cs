using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebMusic_Auth.Models
{
    public class AppUser: IdentityUser
    {
        private string nickName;
        private string sex;
        private string usRank;
        private string usStatus;
        private string photo;


        [Display(Name = "Nick Name")]
        public string NickName { get => this.nickName; set => this.nickName = value; }
        [Display(Name = "Giới Tính")]
        public string Sex { get => this.sex; set => this.sex = value; }
        [Display(Name = "Hạng")]
        public string UsRank { get => this.usRank; set => this.usRank = value; }
        [Display(Name = "Trạng Thái")]
        public string UsStatus { get => this.usStatus; set => this.usStatus = value; }
        [Display(Name = "Ảnh")]
        public string Photo { get => this.photo; set => this.photo = value; }


        public ICollection<CommentsModel> CommentsModels { get; set; }
        public ICollection<LoveDetailModel> LoveDetailModels { get; set; }
        public ICollection<PlaylistModel> PlaylistModels { get; set; }


    }
}
