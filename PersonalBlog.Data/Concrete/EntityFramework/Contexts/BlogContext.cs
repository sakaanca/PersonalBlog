using Microsoft.EntityFrameworkCore;
using PersonalBlog.Data.Concrete.EntityFramework.Mappings;
using PersonalBlog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBlog.Data.Concrete.EntityFramework.Contexts
{
    public  class BlogContext : DbContext
    {
        public DbSet<Summary> Summary { get; set; }
        public DbSet<Interesteds> Interesteds { get; set; }
        public DbSet<SocialMediaAccounts> SocialMediaAccounts { get; set; }
        public DbSet<HomePageSliders> HomePagesSliders { get; set; }
        public DbSet<Skills> Skills { get; set; }
        public DbSet<Experiences> Experiences { get; set; }
        public DbSet<Messages> Messages { get; set; }   
        public DbSet<SiteIdentity> SiteIdentity { get; set; }
        public DbSet<AboutMe> AboutMe { get; set; }
        public DbSet<Admin> Admin { get; set; }
        public DbSet<Education> Education { get; set; }
        public DbSet<ContactInfo> ContactInfo { get; set; }
        public DbSet<Articles> Articles { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Comments> Comments { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: @"Server=(localdb)\MSSQLLocalDB;Database=PersonalBlog;Trusted_Connection=true");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new SummaryMap());
        }

    }
}
