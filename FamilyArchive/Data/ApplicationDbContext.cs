using System;
using System.Collections.Generic;
using System.Text;
using FamilyArchive.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FamilyArchive.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
        
        }
        public DbSet<ApplicationUser> User { get; set; }
        public DbSet<Albums> Album { get; set; }
        public DbSet<Events> Event { get; set; }
        public DbSet<Family> Family { get; set; }
        public DbSet<Members> Member { get; set; }
        public DbSet<Photos> Photo { get; set; }
        public DbSet<Stories> Story { get; set; }
        public DbSet<Updates> Updates { get; set; }
        //public DbSet<ApplicationUser> User { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
           
            // Create a new user for Identity Framework
            ApplicationUser user = new ApplicationUser
            {
                FirstName = "Rhonda",
                LastName = "Scragg",
                Address = "123 Lioness Way",
                UserName = "lioness",
                FamilyId = 1,
                Email = "rhonda@rhonda.com",
                EmailConfirmed = true,
                LockoutEnabled = false,
                Id = "00000000-ffff-ffff-ffff-ffffffffffff"
            };
            var passwordHash = new PasswordHasher<ApplicationUser>();
            user.PasswordHash = passwordHash.HashPassword(user, "Rhonda1!");
            modelBuilder.Entity<ApplicationUser>().HasData(user);

            // Create two families
            modelBuilder.Entity<Family>().HasData(
                new Family()
                {
                    Id = 1,
                    Name = "Tredway"
                },
                new Family()
                {
                    Id = 2,
                    Name = "Brooks"
                }
            );
        }
    }

}

