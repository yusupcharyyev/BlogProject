using BlogProject_5175_06062022.Models.Concrete;
using BlogProject_5175_06062022.Models.EntityTypeConfigurations.Abstract;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogProject_5175_06062022.Models.EntityTypeConfigurations.Concrete
{
    public class CommentMap : BaseMap<Comment>
    {
        public override void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.Property(a => a.Text).HasMaxLength(200).IsRequired(true);

            builder.HasKey(a => new { a.AppUserID, a.ArticleID });

            //builder.HasOne(a => a.AppUser).WithMany(a => a.Comments).HasForeignKey(a => a.AppUserID);

            base.Configure(builder);
        }
    }
}
