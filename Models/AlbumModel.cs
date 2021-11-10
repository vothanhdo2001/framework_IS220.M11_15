using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebMusic.Models
{
    public class AlbumModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        private int AId { get => AId; set => AId = value; }
        private string AName { get => AName; set => AName = value; }
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        private DateTime ADate { get => ADate; set => ADate = value; }
        private string SName { get => SName; set => SName = value; }
        private string Intro { get => Intro; set => Intro = value; }
        private string Photo { get => Photo; set => Photo = value; }
        private string AStatus { get => AStatus; set => AStatus = value; }
        ICollection<AlbumDetailModel> AlbumDetailModels { get; set; }
    }
}
