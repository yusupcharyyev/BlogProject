using BlogProject_5175_06062022.Models.Abstract;
using System;
using Microsoft.EntityFrameworkCore.Query;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace BlogProject_5175_06062022.DAL.Repositories.Interfaces.Abstract
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
        bool Any(Expression<Func<T, bool>> expression);
        T GetDefault(Expression<Func<T, bool>> expression); // tek bir nesne doner
        List<T> GetDefaults(Expression<Func<T, bool>> expression); // aynı tipte tüm nesneleri döner


        //EAGER yaptığımız için

        // aşağıdaki metot kullanıldığında seçim(selector) için bir ling sorgusu, genel bir seçim için expression paramemtresi ve ensonda boş da bırakılabilir bir sorgulaabilir ve dahil edilebilir bir experssion daha yazılabilir.
        TResult GetByDefault<TResult>(Expression<Func<T, TResult>> selector,
                                      Expression<Func<T, bool>> expression,
                                      Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null);
        List<TResult> GetByDefaults<TResult>(Expression<Func<T, TResult>> selector,    // seçim
                                      Expression<Func<T, bool>> expression,         // sorgu
                                      Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null,
                                      // içermesini istediğimiz başka tablolar /include ettiğimiz yani dahil ettiğimiz sınıflar varsa(optional)


                                      Func<IQueryable<T>, IOrderedQueryable<T>> orderby = null);
                                       // istenen sıralama (optional)
    }
}
