using BlogProject_5175_06062022.Models.Concrete;
using BlogProject_5175_06062022.Models.EntityTypeConfigurations.Abstract;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogProject_5175_06062022.Models.EntityTypeConfigurations.Concrete
{
    public class AppUserMap : BaseMap<AppUser>
    {
        public override void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.Property(a => a.FirstName).HasMaxLength(30).IsRequired(true);
            builder.Property(a => a.LastName).HasMaxLength(30).IsRequired(true);
            builder.Property(a => a.UserName).IsRequired(true);
            builder.Property(a => a.Password).IsRequired(true);
            builder.Property(a => a.Image).HasMaxLength(200).IsRequired(true);


            base.Configure(builder);
        }
    }
}
