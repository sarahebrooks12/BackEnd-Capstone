using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FamilyArchive.Models
{
    public class Photos
    {
        public int Id { get; set; }
        public string Title { get; set; }

        [Display(Name = "Image Name")]
        public string ImagePath { get; set; }

        [NotMapped]
        [DisplayName("Upload File")]
        public IFormFile ImageFile { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime DateCreated { get; set; }
        [Required]
        public int MemberId { get; set; }
        [Required]
        public int FamilyId { get; set; }
        [Required]
        public int AlbumId { get; set; }
        public bool Pending { get; set; }
        public Family Family { get; set; }
        public Members Member { get; set; }
        public Albums Album { get; set; }
        public List<Stories> Stories { get; set; }
    }
}
