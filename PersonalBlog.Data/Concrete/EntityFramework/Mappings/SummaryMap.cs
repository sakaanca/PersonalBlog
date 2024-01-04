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
    public class SummaryMap : IEntityTypeConfiguration<Summary>
    {
        public void Configure(EntityTypeBuilder<Summary> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x=>x.CreatedByName).HasMaxLength(50);
            builder.Property(x => x.CreatedByName).IsRequired();
            builder.Property(x => x.ModifiedByName).IsRequired();
            builder.Property(x=>x.ModifiedByName).HasMaxLength(50);
            builder.Property(x=>x.IsActive).IsRequired();
            builder.Property(x=>x.IsDelete).IsRequired();
            builder.Property(x=>x.Content).IsRequired();
            builder.Property(x=>x.Content).HasColumnType("NVARCHAR(MAX)");
            builder.ToTable("Summary");
            builder.HasData(new Summary
            {
                Id=1,
                CreatedByName="InitailCreated",
                ModifiedByName="InitialCreated",
                CreatedTime=DateTime.Now,
                ModifiedTime=DateTime.Now,
                IsActive=false,
                IsDelete=false,
                Content="Selemlarrrr Blog siteme hoş geldiniz :) Ben Kağan  Harita Mühendisiyim . Yazılım sektörüne olan ilgim 2020 yılında başladı . Şu anda C# ile WEB kodluyor ReactNative ile Mobile geliştiriyorum . Asli hedefim Harita Mühendislği ve Yazılımı entegre edip sonrasında teknolojik tarım kavramının en mühim gereksinimi olan Uzaktan Algılama bilim dalı ile projeler üretmek. Aslında pek kararsızım ama hayırlısı diyerek devam etmek istiyorum ... Saygı ve Sevgiyle kalın :)"

            });
        }
    }
}
