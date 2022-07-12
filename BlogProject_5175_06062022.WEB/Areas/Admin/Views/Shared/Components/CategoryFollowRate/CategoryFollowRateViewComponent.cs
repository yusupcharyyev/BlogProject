using BlogProject_5175_06062022.DAL.Repositories.Interfaces.Concrete;
using BlogProject_5175_06062022.WEB.Areas.Admin.Models.VMs;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject_5175_06062022.WEB.Areas.Admin.Views.Shared.Components.CategoryFollowRate
{
    [ViewComponent(Name = "CategoryFollowRate")]
    public class CategoryFollowRateViewComponent : ViewComponent
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IAppUserRepository _appUserRepository;
        private readonly IUserFollowedCategory _userFollowedCategory;

        public CategoryFollowRateViewComponent(ICategoryRepository categoryRepository,IAppUserRepository appUserRepository,IUserFollowedCategory userFollowedCategory)
        {
            _categoryRepository = categoryRepository;
            _appUserRepository = appUserRepository;
            _userFollowedCategory = userFollowedCategory;
        }
        public IViewComponentResult Invoke()
        {
            List<CategoryFollowRateVM> categoryFollowRateVMs = _categoryRepository.GetByDefaults
                (
                    selector: a => new CategoryFollowRateVM
                    {
                        ID=a.ID,
                        CategoryName = a.Name,
                        TotalUser = _appUserRepository.GetTotalUser(),
                        FollowCategoryCount=a.UserFollowedCategories.Where(b=>b.CategoryID==a.ID).Count()
                    },
                    expression: a=>a.Statu!=BlogProject_5175_06062022.Models.Enums.Statu.Passive
                );
            return View(categoryFollowRateVMs.Take(10).ToList());
        }
    }
}
