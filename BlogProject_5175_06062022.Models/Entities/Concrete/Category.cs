using BlogProject_5175_06062022.Models.Abstract;
using BlogProject_5175_06062022.Models.Entities.Concrete;
using System.Collections.Generic;

namespace BlogProject_5175_06062022.Models.Concrete
{
    public class Category : BaseEntity
    {
        public Category()
        {
            Articles = new List<ArticleCategory>();
            UserFollowedCategories = new List<UserFollowedCategory>();
        }

        public string Name { get; set; }
        public string Description { get; set; }


        // Navigation Property
        // 1 kategorinin çokça makalesi olabilir
        public virtual List<ArticleCategory> Articles { get; set; }

        // 1 kategorinin çokça takip edeni olabilir
        public virtual List<UserFollowedCategory> UserFollowedCategories { get; set; }
    }
}