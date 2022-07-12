using BlogProject_5175_06062022.DAL.Context;
using BlogProject_5175_06062022.DAL.Repositories.Interfaces.Concrete;
using BlogProject_5175_06062022.Models.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace BlogProject_5175_06062022.DAL.Repositories.Concrete
{
    public class UserFollowedCategoryRepository : IUserFollowedCategory
    {
        private readonly ProjectContext _projectContext;
        private readonly DbSet<UserFollowedCategory> _table;

        public UserFollowedCategoryRepository(ProjectContext projectContext)
        {
            _projectContext = projectContext;
            _table = projectContext.Set<UserFollowedCategory>();
        }
        public void Create(UserFollowedCategory entity)
        {
            _table.Add(entity);
            _projectContext.SaveChanges();
        }

        public void Delete(UserFollowedCategory entity)
        {
            _table.Remove(entity);
            _projectContext.SaveChanges();
        }
        public List<UserFollowedCategory> GetDefaults(Expression<Func<UserFollowedCategory, bool>> expression)
        {
            return _table.Where(expression).ToList();
        }

    }
}
