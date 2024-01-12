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
    public class HomePageSlidersMap : IEntityTypeConfiguration<HomePageSliders>
    {
        public void Configure(EntityTypeBuilder<HomePageSliders> builder)
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
            builder.Property(x => x.Title).HasMaxLength(40);
            builder.Property(x => x.ShortContent).IsRequired();
            builder.Property(x => x.ShortContent).HasMaxLength(500);
            builder.Property(x => x.Content).IsRequired();
            builder.Property(x => x.Content).HasColumnType("NVARCHAR(MAX)");
            builder.ToTable("HomePageSliders");
            builder.HasData(new HomePageSliders
            {
                Id = 1,
                CreatedByName = "InitailCreated",
                ModifiedByName = "InitialCreated",
                CreatedTime = DateTime.Now,
                ModifiedTime = DateTime.Now,
                IsActive = false,
                IsDelete = false,
                Title="Web Developper",
                ShortContent= "Lorem Ipsum, dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir. Lorem Ipsum, adı bilinmeyen bir matbaacının bir hurufat numune kitabı oluşturmak üzere bir yazı galerisini alarak karıştırdığı 1500'lerden beri endüstri standardı sahte metinler olarak kullanılmıştır. ",
                Content=""
            });
        }
    }
}
