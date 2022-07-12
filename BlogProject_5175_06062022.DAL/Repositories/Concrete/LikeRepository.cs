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
    public class LikeRepository : ILikeRepository
    {
        private readonly ProjectContext _projectContext;
        private readonly DbSet<Like> _table;

        public LikeRepository(ProjectContext projectContext)
        {
            _projectContext = projectContext;
            _table = projectContext.Set<Like>();
        }
        public void Create(Like entity)
        {
            _table.Add(entity);
            _projectContext.SaveChanges();
        }

        public void Delete(Like entity)
        {
            _table.Remove(entity);
            _projectContext.SaveChanges();
        }

        public Like GetLike(Expression<Func<Like, bool>> expression)
        {
            return _table.Where(expression).FirstOrDefault();
        }

        public bool GetResult(Expression<Func<Like, bool>> expression)
        {
            return _table.Any(expression);
        }
    }
}
