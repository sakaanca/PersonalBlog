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
    public class ContactInfoMap : IEntityTypeConfiguration<ContactInfo>
    {
        public void Configure(EntityTypeBuilder<ContactInfo> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.CreatedByName).HasMaxLength(50);
            builder.Property(x => x.CreatedByName).IsRequired();
            builder.Property(x => x.ModifiedByName).IsRequired();
            builder.Property(x => x.ModifiedByName).HasMaxLength(50);
            builder.Property(x => x.IsActive).IsRequired();
            builder.Property(x => x.IsDelete).IsRequired();
            builder.Property(x => x.PhoneNumber).IsRequired();
            builder.Property(x => x.PhoneNumber).HasMaxLength(15);
            builder.Property(x => x.EMail).IsRequired();
            builder.Property(x => x.EMail).HasMaxLength(100);
            builder.Property(x => x.ShortAdress).IsRequired();
            builder.Property(x => x.ShortAdress).HasMaxLength(35);
            builder.Property(x => x.Adress).IsRequired();
            builder.Property(x => x.Adress).HasMaxLength(100);
            builder.ToTable("ContactInfo");
            builder.HasData(new ContactInfo
            {
                Id = 1,
                CreatedByName = "InitailCreated",
                ModifiedByName = "InitialCreated",
                CreatedTime = DateTime.Now,
                ModifiedTime = DateTime.Now,
                IsActive = false,
                IsDelete = false,
                PhoneNumber="+90 541 918 5633",
                EMail="kaansarıca@hotmail.com",
                ShortAdress=" Şişli / İstanbul",
                Adress="Gülbağ Mah. Şişli / İstanbul"
                
            });
        }
    }
}
