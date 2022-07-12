using BlogProject_5175_06062022.Models.Concrete;
using BlogProject_5175_06062022.Models.EntityTypeConfigurations.Abstract;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogProject_5175_06062022.Models.EntityTypeConfigurations.Concrete
{
    public class LikeMap : IEntityTypeConfiguration<Like>
    {
        public void Configure(EntityTypeBuilder<Like> builder)
        {
            builder.HasKey(a => new { a.AppUserID, a.ArticleID });
        }
    }
}
