using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PersonalBlog.Entities.Concrete;
using PersonalBlog.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBlog.Data.Concrete.EntityFramework.Mappings
{
    public class AdminMap : IEntityTypeConfiguration<Admin>
    {
        public void Configure(EntityTypeBuilder<Admin> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.CreatedByName).HasMaxLength(50);
            builder.Property(x => x.CreatedByName).IsRequired();
            builder.Property(x => x.ModifiedByName).IsRequired();
            builder.Property(x => x.ModifiedByName).HasMaxLength(50);
            builder.Property(x => x.IsActive).IsRequired();
            builder.Property(x => x.IsDelete).IsRequired();
            builder.Property(x => x.EMail).IsRequired();
            builder.Property(x => x.EMail).HasMaxLength(100);
            builder.Property(x => x.Password).IsRequired();
            builder.Property(x => x.Password).HasMaxLength(250);
            builder.Property(x => x.SecurityQuestion).IsRequired();
            builder.Property(x => x.SecurityQuestion).HasMaxLength(200);
            builder.Property(x => x.SQAnswer).IsRequired();
            builder.Property(x => x.SQAnswer).HasMaxLength(250);
            builder.ToTable("Admin");
            builder.HasData(new Admin
            {
                Id = 1,
                CreatedByName = "InitailCreated",
                ModifiedByName = "InitialCreated",
                CreatedTime = DateTime.Now,
                ModifiedTime = DateTime.Now,
                IsActive = false,
                IsDelete = false,
                EMail = "kaansarıca@hotmail.com",
                Password = "202cb962ac59075b964b07152d234b70",//https://www.md5hashgenerator.com/ md5 hash generator sitesi üzerinden oluşturdum string tiipini  .... 123 ün hashlenmiş hali
                SecurityQuestion = " Baba İsmi ?",
                SQAnswer = "d595878cf4d099846b16890e7d9fc490"// yine aynı siteden mesut yazarak hasledik


            });


        }
    }
}
