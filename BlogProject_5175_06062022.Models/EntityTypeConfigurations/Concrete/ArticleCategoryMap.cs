using BlogProject_5175_06062022.Models.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogProject_5175_06062022.Models.EntityTypeConfigurations.Concrete
{
   public class ArticleCategoryMap : IEntityTypeConfiguration<ArticleCategory>
    {
        public void Configure(EntityTypeBuilder<ArticleCategory> builder)
        {
            builder.HasKey(a => new { a.ArticleID, a.CategoryID });
        }
    }
}
