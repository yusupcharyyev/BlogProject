using BlogProject_5175_06062022.Models.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogProject_5175_06062022.DAL.Repositories.Interfaces.Concrete
{
    public interface ILikeRepository
    {
        // Not => like sınıfı baseEntity'den gelmediğinden baseMap/BaseRepodan kalıtım alamaz bu yüzden kendi konfigurasyonunu ve reposunu kendi yazmalıdır
        void Create(Like entity);
        void Delete(Like entity);
        bool GetResult(System.Linq.Expressions.Expression<Func<Like, bool>> expression);
        Like GetLike(System.Linq.Expressions.Expression<Func<Like, bool>> expression);
    }
}
