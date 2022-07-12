using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogProject_5175_06062022.Models.EntityTypeConfigurations.Concrete
{
    public class IdentityRoleMap : IEntityTypeConfiguration<IdentityRole>
    {
        // seed Data
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(new IdentityRole { Id = Guid.NewGuid().ToString(), Name = "Member", NormalizedName = "MEMBER" }, new IdentityRole { Id = Guid.NewGuid().ToString(), Name = "Admin", NormalizedName = "ADMIN" });
        }
    }
}
