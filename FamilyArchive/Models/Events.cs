using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FamilyArchive.Models
{
    public class Events
    {
        public int Id { get; set; }


        [Required]
        public DateTime Date { get; set; }
        public string Location { get; set; }
        public string Type { get; set; }
        public string SupplyRequest { get; set; }
        public string FoodRequest { get; set; }
        [Required]
        public int FamilyId { get; set; }
        public bool Pending { get; set; }
        public Family Family { get; set; }
    }
}
