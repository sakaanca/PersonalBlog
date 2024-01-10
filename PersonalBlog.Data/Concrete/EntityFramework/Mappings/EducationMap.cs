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
    public class EducationMap : IEntityTypeConfiguration<Education>
    {
        public void Configure(EntityTypeBuilder<Education> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.CreatedByName).HasMaxLength(50);
            builder.Property(x => x.CreatedByName).IsRequired();
            builder.Property(x => x.ModifiedByName).IsRequired();
            builder.Property(x => x.ModifiedByName).HasMaxLength(50);
            builder.Property(x => x.IsActive).IsRequired();
            builder.Property(x => x.IsDelete).IsRequired();
            builder.Property(x => x.Title).IsRequired();
            builder.Property(x => x.Title).HasMaxLength(50);
            builder.Property(x => x.School).IsRequired();
            builder.Property(x => x.School).HasMaxLength(100);
            builder.Property(x=>x.Duration).IsRequired();
            builder.Property(x => x.Duration).HasMaxLength(30);
            builder.Property(x=>x.Avarge).IsRequired    ();
            builder.Property(x => x.Avarge).HasMaxLength(15);
            builder.Property(x=>x.Description).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(200);
            builder.ToTable("Education");
            builder.HasData(new Education
            {
                Id = 1,
                CreatedByName = "InitailCreated",
                ModifiedByName = "InitialCreated",
                CreatedTime = DateTime.Now,
                ModifiedTime = DateTime.Now,
                IsActive = false,
                IsDelete = false,
                Title="Lisans Derecesi",
                School="İstanbul Teknik Üniversitesi",
                Duration="2020 yılı Harita Mühendislği bölümünden mezun ",
                Avarge="2.65/4",
                Description="Doktore yapmayı hedefliyorum ."

            });

        }
    }
}
