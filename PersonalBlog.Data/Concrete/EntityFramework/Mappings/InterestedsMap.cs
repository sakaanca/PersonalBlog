using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PersonalBlog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace PersonalBlog.Data.Concrete.EntityFramework.Mappings
{
    public class InterestedsMap : IEntityTypeConfiguration<Interesteds>
    {
        public void Configure(EntityTypeBuilder<Interesteds> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.CreatedByName).HasMaxLength(50);
            builder.Property(x => x.CreatedByName).IsRequired();
            builder.Property(x => x.ModifiedByName).IsRequired();
            builder.Property(x => x.ModifiedByName).HasMaxLength(50);
            builder.Property(x => x.IsActive).IsRequired();
            builder.Property(x => x.IsDelete).IsRequired();
            builder.Property(x => x.Text).IsRequired();
            builder.Property(x => x.Text).HasMaxLength(300);
            builder.ToTable("Interesteds");
            builder.HasData(new Interesteds
            {
                Id = 1,
                CreatedTime = DateTime.Now,
                ModifiedTime = DateTime.Now,
                CreatedByName = "InitialCreated",
                ModifiedByName = "InitialCreated",
                IsActive = false,
                IsDelete = false,
                Text = "Yazılım ve Teknoloji"


            },
            new Interesteds
            {
                Id = 2,
                CreatedTime = DateTime.Now,
                ModifiedTime = DateTime.Now,
                CreatedByName = "InitialCreated",
                ModifiedByName = "InitialCreated",
                IsActive = false,
                IsDelete = false,
                Text = "Haritacılık Faaliyetleri"

            },
            new Interesteds
            {
                Id = 3,
                CreatedTime = DateTime.Now,
                ModifiedTime = DateTime.Now,
                CreatedByName = "InitialCreated",
                ModifiedByName = "InitialCreated",
                IsActive = false,
                IsDelete = false,
                Text = "Tarım ve Hayvancılık faaliyetleri"

            });
        }
    }
}
