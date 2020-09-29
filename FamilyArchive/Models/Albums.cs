using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FamilyArchive.Models
{
    public class Albums
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [Required]
        public int FamilyId { get; set; }
        public bool Pending { get; set; }
        public Family Family { get; set; }
       public List<Photos> Photos { get; set; }
    }
}
