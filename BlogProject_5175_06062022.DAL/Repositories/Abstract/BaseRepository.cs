using BlogProject_5175_06062022.DAL.Repositories.Interfaces.Abstract;
using BlogProject_5175_06062022.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq;
using System.Text;
using BlogProject_5175_06062022.DAL.Context;
using Microsoft.EntityFrameworkCore;
using BlogProject_5175_06062022.Models.Enums;

namespace BlogProject_5175_06062022.DAL.Repositories.Abstract
{
    public abstract class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        protected readonly ProjectContext _context;
        protected readonly DbSet<T> _table;
        //IOC --> araştır
        public BaseRepository(ProjectContext context)
        {
            _context = context;
            _table = context.Set<T>();
        }
        public bool Any(Expression<Func<T, bool>> expression)
        {
            return _table.Any(expression);
        }

        public void Create(T entity)
        {
            _table.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(T entity)
        {
            entity.Statu = Statu.Passive;
            entity.RemovedDate = DateTime.Now;
            _context.SaveChanges();
        }

        public void Update(T entity)
        {
            entity.Statu = Statu.Modified;
            entity.ModifiedDate = DateTime.Now;
            _table.Update(entity);
            _context.SaveChanges();
        }
        public TResult GetByDefault<TResult>(Expression<Func<T, TResult>> selector, Expression<Func<T, bool>> expression, Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null)
        {
            IQueryable<T> query = _table; // tablomuzu sorgulanabilir T tipini barındıran tablo olarak atadık
            if (include != null) // include içeren sorgu doluysa
            {
                query = include(query); // include ait işlemleri yap
            }
            if (expression != null)     //expression doluysa
            {
                query = query.Where(expression);    // sorgula
            }
            return query.Select(selector).First(); // include ve expression sorgusu dolu/boş gelsede en sonda bu seçim işlemi yapılacaktır
        }

        public List<TResult> GetByDefaults<TResult>(Expression<Func<T, TResult>> selector, 
                                                    Expression<Func<T, bool>> expression,
                                                               Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null,                                Func<IQueryable<T>, IOrderedQueryable<T>> orderby = null)
        {
            // 4 parametreden include(dahil etme(join SQL)) ve filtreleme(expression) null değilse doldurur ve demanın ya seçim yapıp alınır yada orderby doluysa orderlanıp seçim yapıp alınır.
            IQueryable<T> query = _table;
            if (include!=null)
            {
                query = include(query);
            }
            if (expression != null)    
            {
                query = query.Where(expression);   
            }
            if (orderby!=null)
            {
                return orderby(query).Select(selector).ToList();
            }
            return query.Select(selector).ToList();
        }

        public T GetDefault(Expression<Func<T, bool>> expression)
        {
            return _table.Where(expression).FirstOrDefault();
        }

        public List<T> GetDefaults(Expression<Func<T, bool>> expression)
        {
            return _table.Where(expression).ToList();
        }

    }
}
