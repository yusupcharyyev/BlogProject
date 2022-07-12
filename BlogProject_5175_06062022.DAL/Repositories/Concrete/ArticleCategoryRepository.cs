using BlogProject_5175_06062022.DAL.Context;
using BlogProject_5175_06062022.DAL.Repositories.Interfaces.Concrete;
using BlogProject_5175_06062022.Models.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace BlogProject_5175_06062022.DAL.Repositories.Concrete
{
    public class ArticleCategoryRepository : IArticleCategoryRepository
    {
        private readonly ProjectContext _projectContext;
        private readonly DbSet<ArticleCategory> _table;

        public ArticleCategoryRepository(ProjectContext projectContext)
        {
            _projectContext = projectContext;
            _table = projectContext.Set<ArticleCategory>();

        }
        public void Create(ArticleCategory entity)
        {
            _table.Add(entity);
            _projectContext.SaveChanges();
        }

        public void Delete(ArticleCategory entity)
        {
            _table.Remove(entity);
            _projectContext.SaveChanges();
        }

        public List<ArticleCategory> GetDefaults(Expression<Func<ArticleCategory, bool>> expression)
        {
            return _table.Where(expression).ToList();
        }
    }
}
