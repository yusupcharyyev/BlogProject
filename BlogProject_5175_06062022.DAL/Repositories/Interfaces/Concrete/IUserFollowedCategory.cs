using BlogProject_5175_06062022.Models.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogProject_5175_06062022.DAL.Repositories.Interfaces.Concrete
{
    public interface IUserFollowedCategory
    {
        void Create(UserFollowedCategory entity);
        void Delete(UserFollowedCategory entity);
        List<UserFollowedCategory> GetDefaults(System.Linq.Expressions.Expression<Func<UserFollowedCategory, bool>> expression);
    }
}
