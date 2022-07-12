using AutoMapper;
using BlogProject_5175_06062022.DAL.Repositories.Interfaces.Concrete;
using BlogProject_5175_06062022.Models.Concrete;
using BlogProject_5175_06062022.WEB.Models.DTOs;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject_5175_06062022.WEB.Views.Shared.Components.GetAllCategories
{
    [ViewComponent(Name = "GetAllCategories")]
    public class GetAllCategoriesViewComponent : ViewComponent
    {
        private readonly ICategoryRepository _categoryRepository;

        public GetAllCategoriesViewComponent(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public IViewComponentResult Invoke()
        {
            return View(_categoryRepository.GetAllCategory());
        }
    }
}
