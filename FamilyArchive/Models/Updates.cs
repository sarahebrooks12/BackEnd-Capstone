using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FamilyArchive.Models
{
    public class Updates
    {
        public int Id { get; set; }
        public string Content { get; set; }
        [Required]
        public int FamilyId { get; set; }
        public Family Family { get; set; }
    }
}
