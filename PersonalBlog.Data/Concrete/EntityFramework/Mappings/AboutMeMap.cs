using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PersonalBlog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBlog.Data.Concrete.EntityFramework.Mappings
{
    public class AboutMeMap : IEntityTypeConfiguration<AboutMe>
    {
        public void Configure(EntityTypeBuilder<AboutMe> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.CreatedByName).HasMaxLength(50);
            builder.Property(x => x.CreatedByName).IsRequired();
            builder.Property(x => x.ModifiedByName).IsRequired();
            builder.Property(x => x.ModifiedByName).HasMaxLength(50);
            builder.Property(x => x.IsActive).IsRequired();
            builder.Property(x => x.IsDelete).IsRequired();
            builder.Property(x => x.FirstName).IsRequired();
            builder.Property(x => x.FirstName).HasMaxLength(30);
            builder.Property(x => x.LastName).IsRequired();
            builder.Property(x=>x.ImagePath).IsRequired();
            builder.Property(x => x.ImagePath).HasMaxLength(250);
            builder.Property(x => x.MyJop).IsRequired();
            builder.Property(x => x.MyJop).HasMaxLength(40);
            builder.Property(x=>x.MyJopFA).IsRequired();
            builder.Property(x => x.MyJopFA).HasMaxLength(150);
            builder.Property(x => x.MyCVPath).IsRequired();
            builder.Property(x => x.MyCVPath).HasMaxLength(250);
            builder.Property(x=>x.BirthDate).IsRequired();
            builder.ToTable("AboutMe");
            builder.HasData(new AboutMe
            {
                Id = 1,
                CreatedByName = "InitailCreated",
                ModifiedByName = "InitialCreated",
                CreatedTime = DateTime.Now,
                ModifiedTime = DateTime.Now,
                IsActive = false,
                IsDelete = false,
                FirstName="M. Kaan",
                LastName="SARICA",
                ImagePath="",
                MyJop="WEB DEVELOPER",
                MyJopFA= "<i class=\"fa-regular fa-laptop-code\"></i>",
                MyCVPath="",
                BirthDate= DateTime.Parse("16.06.1998")
               

            });
        }
    }
}
