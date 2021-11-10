using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebMusic.Models
{
    public class UsersModel
    {
        private int usId;
        private string userName;
        private string pass;
        private string nickName;
        private string sex;
        private string mail;
        private DateTime rDate;
        private string usRank;
        private string usStatus;
        private string photo;
        private string pass2;
        private string question;

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UsId { get => this.usId; set => value = this.usId; }
        public string UserName { get => this.userName; set => this.userName = value; }
        public string Pass { get => this.pass; set => this.pass = value; }
        public string NickName { get => this.nickName; set => this.nickName = value; }
        public string Sex { get => this.sex; set => this.sex = value; }
        public string Mail { get => this.mail; set => this.mail = value; }

        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime RDate { get => this.rDate; set => this.rDate = value; }
        public string UsRank { get => this.usRank; set => this.usRank = value; }
        public string UsStatus { get => this.usStatus; set => this.usStatus = value; }
        public string Photo { get => this.photo; set => this.photo = value; }
        public string Pass2 { get => this.pass2; set => this.pass2 = value; }
        public string Question { get => this.question; set => this.question = value; }

        public ICollection<CommentsModel> CommentsModels { get; set; }
        public ICollection<LoveDetailCommentModel> LoveDetailCommentModels { get; set; }
        public ICollection<PlaylistDetailModel> PlaylistDetailModels { get; set; }
        public ICollection<LoveDetailModel> LoveDetailModels { get; set; }
        public ICollection<AlbumDetailModel> AlbumDetailModels { get; set; }

    }
}
