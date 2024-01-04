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
    public class SocialMediaAccountsMap : IEntityTypeConfiguration<SocialMediaAccounts>
    {
        public void Configure(EntityTypeBuilder<SocialMediaAccounts> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.CreatedByName).HasMaxLength(50);
            builder.Property(x => x.CreatedByName).IsRequired();
            builder.Property(x => x.ModifiedByName).IsRequired();
            builder.Property(x => x.ModifiedByName).HasMaxLength(50);
            builder.Property(x => x.IsActive).IsRequired();
            builder.Property(x => x.IsDelete).IsRequired();
            builder.Property(x => x.Account).IsRequired();
            builder.Property(x=>x.Account).HasMaxLength(30);
            builder.Property(x => x.AccountFA).IsRequired();
            builder.Property(x => x.AccountFA).HasMaxLength(150);
            builder.Property(x => x.AccountUrl).IsRequired();
            builder.Property(x => x.AccountUrl).HasMaxLength(150);
            builder.ToTable("SocialMediaAccounts");
            builder.HasData(new SocialMediaAccounts
            {
                Id = 1,
                CreatedByName = "InitailCreated",
                ModifiedByName = "InitialCreated",
                CreatedTime = DateTime.Now,
                ModifiedTime = DateTime.Now,
                IsActive = false,
                IsDelete = false,
                Account = "Facebook",
                AccountFA= "<i class=\"fa-brands fa-facebook-f\"></i>",
                AccountUrl= "https://www.facebook.com/profile.php?id=100086037936445&locale=tr_TR"

            });
        }//FA= Font Awesome
    }
}
