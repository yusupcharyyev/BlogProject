using BlogProject_5175_06062022.DAL.Repositories.Interfaces.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject_5175_06062022.WEB.Areas.Admin.Views.Shared.Components.LastAddCategory
{
    [ViewComponent(Name = "LastAddCategory")]
    public class LastAddCategoryViewComponent : ViewComponent
    {
        private readonly ICategoryRepository _categoryRepository;

        public LastAddCategoryViewComponent(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public IViewComponentResult Invoke()
        {
            return View(_categoryRepository.GetAllCategoryForAdmin());
        }
    }
}
