using Microsoft.EntityFrameworkCore;
using ProjectCV.ENTITY.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCV.DAL.Context
{
    public class DataContext : DbContext

    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-2PQ9B8P;Database=ProjectCV-DB;Integrated Security=true;TrustServerCertificate=true;");
        }
        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<Experiance> Experiances { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Education> Educations { get; set; }

    }
}
