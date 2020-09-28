using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FamilyArchive.Models
{
    public class Members
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool isMaidenName { get; set; }
        public bool isNickName { get; set; }
        public string NickName { get; set; }
        public string Address { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
        public bool isDied { get; set; }

        [DataType(DataType.Date)]
        public DateTime DeathDate { get; set; }
        public bool isAnniversary { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime Anniversary { get; set; }
        [Required]
        public int FamilyId { get; set; }
        public bool Pending { get; set; }
        public Family Family { get; set; }
    }
}
