using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FamilyArchive.Models
{
    public class Photos
    {
        public int Id { get; set; }
        //[Required]
        //[DataType(DataType.Date)]
        //[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        //[Display(Name = "Date Created")]
        //public DateTime DateCreated { get; set; }
        public string ImagePath { get; set; }
        [Required]
        public int MemberId { get; set; }
        [Required]
        public int FamilyId { get; set; }
        [Required]
        public int AlbumId { get; set; }
        public bool Pending { get; set; }
        public Family Family { get; set; }
        public Members FamilyMember { get; set; }
        public Albums Album { get; set; }
        public List<Stories> Stories { get; set; }
    }
}
