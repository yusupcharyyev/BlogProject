using BlogProject_5175_06062022.Models.Concrete;
using BlogProject_5175_06062022.Models.EntityTypeConfigurations.Abstract;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace BlogProject_5175_06062022.Models.EntityTypeConfigurations.Concrete
{
    public class ArticleMap : BaseMap<Article>
    {
        public override void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.Property(a => a.Title).HasMaxLength(50).IsRequired(true);
            builder.Property(a => a.Content).IsRequired(true);
            builder.Property(a => a.Image).IsRequired(true);
            builder.Property(a => a.ReadCount).IsRequired(false);

            builder.HasOne(a => a.AppUser).WithMany(a => a.Articles).HasForeignKey(a => a.AppUserID).OnDelete(DeleteBehavior.Restrict); // DeleteBehavir.Restrict => ebeveyn - çocuk(parent child) ilişkisi gibi düşünebiliriz. Yani makale silindiğinde sıkıntı yok ama makalenin sahibi user'ı silinmeye kalktığında hata verir. Makaleleri silebilirsiniz ama silmeye kaltığınızda userin makaleleri varsa o User'ı silemezsiniz çünkü onun makaleleri user'sı olamaz.
        
         

            base.Configure(builder);
        }
    }
}
