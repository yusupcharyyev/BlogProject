
using BlogProject_5175_06062022.Models.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogProject_5175_06062022.DAL.Repositories.Interfaces.Concrete
{
    public interface IArticleCategoryRepository
    {
        void Create(ArticleCategory entity);
        void Delete(ArticleCategory entity);
        List<ArticleCategory> GetDefaults(System.Linq.Expressions.Expression<Func<ArticleCategory, bool>> expression);
    }
}
