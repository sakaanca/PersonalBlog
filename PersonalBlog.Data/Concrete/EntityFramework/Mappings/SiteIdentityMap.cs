using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PersonalBlog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBlog.Data.Concrete.EntityFramework.Mappings
{
    public class SiteIdentityMap : IEntityTypeConfiguration<SiteIdentity>
    {
        public void Configure(EntityTypeBuilder<SiteIdentity> builder)
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
            builder.Property(x=>x.Keywords).IsRequired();
            builder.Property(x => x.Keywords).HasMaxLength(150);
            builder.Property(x=>x.Desciption).IsRequired();
            builder.Property(x=>x.Desciption).HasMaxLength(150);
            builder.Property(x=>x.LogoFA).IsRequired();
            builder.Property(x => x.LogoFA).HasMaxLength(150);
            builder.Property(x=>x.LogoText).IsRequired();
            builder.Property(x => x.LogoText).HasMaxLength(20);
            builder.ToTable("SiteIdentity");
            builder.HasData(new SiteIdentity
            {
                Id = 1,
                CreatedByName = "InitailCreated",
                ModifiedByName = "InitialCreated",
                CreatedTime = DateTime.Now,
                ModifiedTime = DateTime.Now,
                IsActive = false,
                IsDelete = false,
                Title ="Hasan Erdal",
                Keywords="C#, .NET , WEB ,SOFTWARE",
                Desciption="M. Kaan SARICA Web Developer",
                LogoText="M. Kaan SARICA",
                LogoFA="<i class=\"fas fa - h - square\"></i>"


            });

        }
    }
}
