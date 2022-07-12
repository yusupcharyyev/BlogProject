﻿using BlogProject_5175_06062022.DAL.Repositories.Interfaces.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject_5175_06062022.WEB.Areas.Member.Views.Shared.Components.UserFollowCategory
{
    [ViewComponent(Name = "UserFollowCategory")]
    public class UserFollowCategoryViewComponent : ViewComponent
    {
        private readonly ICategoryRepository _categoryRepository;

        public UserFollowCategoryViewComponent(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public IViewComponentResult Invoke(int id)
        {
            return View(_categoryRepository.GetCategoryWithUser(id));
        }
    }
}
