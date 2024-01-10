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
    public class MessagesMap : IEntityTypeConfiguration<Messages>
    {
        public void Configure(EntityTypeBuilder<Messages> builder)
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
            builder.Property(x => x.LastName).HasMaxLength(20);
            builder.Property(x => x.EMail).IsRequired();
            builder.Property(x => x.EMail).HasMaxLength(100);
            builder.Property(x => x.Subject).IsRequired();
            builder.Property(x => x.Subject).HasMaxLength(20);
            builder.Property(x => x.Text).IsRequired();
            builder.Property(x => x.Text).HasMaxLength(512);
            builder.ToTable("Messages");
            builder.HasData(new Messages
            {

                Id = 1,
                CreatedByName = "InitailCreated",
                ModifiedByName = "InitialCreated",
                CreatedTime = DateTime.Now,
                ModifiedTime = DateTime.Now,
                IsActive = false,
                IsDelete = false,
                FirstName = "Hasan",
                LastName = "Erdal",
                EMail = "deneme@gmail.com",
                Subject = "deneme",
                Text = "Dün Gece Yar Hanesinde\r\n                 Yastığım Bir Taş İdi\r\n                 Altım Çamur Üstüm Yağmur\r\n                 Gine Gönlüm Hoş İdi\r\n                 Ben Yandım Seni Bilmem\r\n                 Dağ Ne Kadar Yüce Olsa\r\n                 Bir Kenarı Yol Olur\r\n                 Buna Bayram Günü Derler\r\n                 Dostla Düşman Bir Olur\r\n                 Ben Yandım Seni Bilmem\r\n                 Sen Bugün Nadan İle Gezdin\r\n                 Merak Oldu Bana Sen Bugün Nadan İle Gezdin\r\n                 Merak Oldu Bana Çeşmi Mestimden Bile Süzdüm\r\n                 Merak Oldu Bana\r\n                 Ben Yandım Seni Bilmem"
            });
        }
    }
}
