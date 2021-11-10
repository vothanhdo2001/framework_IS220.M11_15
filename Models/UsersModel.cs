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
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        private int UsId { get => UsId; set => value=UsId; }
        private string UserName { get => UserName; set => UserName = value; }
        private string Pass { get => Pass; set => Pass = value; }
        private string NickName { get => NickName; set => NickName = value; }
        private string Sex { get => Sex; set => Sex = value; }
        private string Mail { get => Mail; set => Mail = value; }

        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        private DateTime RDate { get => RDate; set => RDate = value; }
        private string UsRank { get => UsRank; set => UsRank = value; }
        private string UsStatus { get => UsStatus; set => UsStatus = value; }
        private string Photo { get => Photo; set => Photo = value; }
        private string Pass2 { get => Pass2; set => Pass2 = value; }
        private string Question { get => Question; set => Question = value; }

        public ICollection<CommentsModel> CommentsModels { get; set; }
        public ICollection<LoveDetailCommentModel> LoveDetailCommentModels { get; set; }
        public ICollection<PlaylistDetailModel> PlaylistDetailModels { get; set; }
        public ICollection<LoveDetailModel> LoveDetailModels { get; set; }
        public ICollection<AlbumDetailModel> AlbumDetailModels { get; set; }

    }
}
