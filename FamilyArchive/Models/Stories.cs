using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FamilyArchive.Models
{
    public class Stories
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int MemberId { get; set; }
        public int FamilyId { get; set; }
        public bool Pending { get; set; }
        public Family Family { get; set; }
        public Members FamilyMember { get; set; }
    }
}
