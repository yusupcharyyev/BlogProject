using BlogProject_5175_06062022.DAL.Repositories.Interfaces.Concrete;
using BlogProject_5175_06062022.Models.Concrete;
using BlogProject_5175_06062022.WEB.Areas.Admin.Models.DTOs;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject_5175_06062022.WEB.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public IActionResult AllCategory()
        {
            List<GetAllCategoryDTO> getAllCategoryDTOs = _categoryRepository.GetByDefaults
                (
                    selector: a => new GetAllCategoryDTO
                    {
                        ID = a.ID,
                        Name = a.Name,
                        Description = a.Description,
                        Statu = a.Statu
                    },
                    expression: v => v.ID != 0,
                    orderby: b=>b.OrderByDescending(v=>v.CreateDate)
                );
            return View(getAllCategoryDTOs);
        }
        public IActionResult CategoryStatuP(int id)
        {
            Category category = _categoryRepository.GetDefault(a => a.ID == id);
            _categoryRepository.Delete(category);
            return RedirectToAction("AllCategory" , "Category");
        }
        public IActionResult CategoryStatuMA(int id)
        {
            Category category = _categoryRepository.GetDefault(a => a.ID == id);
            _categoryRepository.Update(category);
            return RedirectToAction("AllCategory", "Category");
        }

        public IActionResult CategoryPending()
        {
            List<GetCategoryPendingDTO> getCategoryPendingDTOs = _categoryRepository.GetByDefaults
                (
                    selector: a=> new GetCategoryPendingDTO
                    {
                        ID=a.ID,
                        Name=a.Name,
                        Description=a.Description,
                        Statu=a.Statu,
                        CreateDate=a.CreateDate
                    },
                    expression: v=>v.Statu==BlogProject_5175_06062022.Models.Enums.Statu.Passive
                );
            return View(getCategoryPendingDTOs);
        }
    }
}
