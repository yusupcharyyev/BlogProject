using BlogProject_5175_06062022.Models.Concrete;
using BlogProject_5175_06062022.Models.EntityTypeConfigurations.Abstract;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogProject_5175_06062022.Models.EntityTypeConfigurations.Concrete
{
    public class CategoryMap : BaseMap<Category>
    {
        public override void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.Property(a => a.Name).HasMaxLength(50).IsRequired(true);
            builder.Property(a => a.Description).HasMaxLength(100).IsRequired(true);

            base.Configure(builder);
        }
    }
}
