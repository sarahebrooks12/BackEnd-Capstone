using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace FamilyArchive.Models
{
    //applicationuser identity 
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser () { }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        public string Address { get; set; }
        [Required]
        public int FamilyId { get; set; }
        public bool IsAdmin { get; set; }
    }
}
