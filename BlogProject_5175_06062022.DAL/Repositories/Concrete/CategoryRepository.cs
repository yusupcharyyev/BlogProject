using BlogProject_5175_06062022.DAL.Context;
using BlogProject_5175_06062022.DAL.Repositories.Abstract;
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
    public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(ProjectContext context) : base(context)
        {

        }

        // kullanıcının takip ettiği kategorileri alan componentte kullanacağımız metot
        public List<Category> GetCategoryWithUser(int id)
        {
            return _context.UserFollowedCategories.Include(a => a.AppUser).Include(a => a.Category).Where(a => a.AppUserID == id).Select(a => a.Category).ToList();
        }
        public List<Category> GetAllCategory()
        {
            return _context.Categories.Where(a => a.Statu != Models.Enums.Statu.Passive).ToList();
        }

        public List<Category> GetAllCategoryForAdmin()
        {
            return _context.Categories.OrderByDescending(a=>a.CreateDate).Take(10).ToList();
        }
    }
}
