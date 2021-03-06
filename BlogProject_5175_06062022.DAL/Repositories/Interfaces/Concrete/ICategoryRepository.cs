using BlogProject_5175_06062022.DAL.Repositories.Interfaces.Abstract;
using BlogProject_5175_06062022.Models.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogProject_5175_06062022.DAL.Repositories.Interfaces.Concrete
{
    public interface ICategoryRepository : IBaseRepository<Category>
    {
        List<Category> GetCategoryWithUser(int id);
        List<Category> GetAllCategory();
        List<Category> GetAllCategoryForAdmin();
    }
}
