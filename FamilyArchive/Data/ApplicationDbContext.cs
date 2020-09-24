using System;
using System.Collections.Generic;
using System.Text;
using FamilyArchive.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FamilyArchive.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Albums> Album { get; set; }
        public DbSet<Events> Event { get; set; }
        public DbSet<Family> Family { get; set; }
        public DbSet<Members> Member { get; set; }
        public DbSet<Photos> Photo { get; set; }
        public DbSet<Stories> Story { get; set; }
        public DbSet<Updates> Updates { get; set; }
        public DbSet<ApplicationUser> User { get; set; }

    }
}
