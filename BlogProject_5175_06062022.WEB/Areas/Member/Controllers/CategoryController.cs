using AutoMapper;
using BlogProject_5175_06062022.DAL.Repositories.Interfaces.Concrete;
using BlogProject_5175_06062022.Models.Concrete;
using BlogProject_5175_06062022.Models.Enums;
using BlogProject_5175_06062022.WEB.Areas.Member.Models.DTOs;
using BlogProject_5175_06062022.WEB.Areas.Member.Models.VMs;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject_5175_06062022.WEB.Areas.Member.Controllers
{
    [Area("Member")]
    public class CategoryController : Controller
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IAppUserRepository _appUserRepository;
        private readonly IUserFollowedCategory _userFollowedCategory;

        public CategoryController(ICategoryRepository categoryRepository, IMapper mapper, UserManager<IdentityUser> userManager, IAppUserRepository appUserRepository,IUserFollowedCategory userFollowedCategory)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
            _userManager = userManager;
            _appUserRepository = appUserRepository;
            _userFollowedCategory = userFollowedCategory;
        }

        [HttpGet]
        public IActionResult Create() => View();

        [HttpPost]
        public IActionResult Create(CreateCategoryDTO createCategoryDTO)
        {
            if (ModelState.IsValid)
            {
                var category = _mapper.Map<Category>(createCategoryDTO);
                _categoryRepository.Create(category);
                return RedirectToAction("List", "Category");
            }
            else return View(createCategoryDTO);
        }

        public async Task<IActionResult> List()
        {
            //List<Category> list = _categoryRepository.GetDefaults(a => a.Statu != Statu.Passive);
            //return View(list);
            IdentityUser identityUser = await _userManager.GetUserAsync(User);
            AppUser appUser = _appUserRepository.GetDefault(a => a.IdentityId == identityUser.Id);

            var category = _categoryRepository.GetByDefaults
             (
                selector: a => new GetCategoryVM
                {
                    ID = a.ID,
                    Name = a.Name,
                    Description = a.Description,
                    UserID = appUser.ID,
                    userFollowedCategories = a.UserFollowedCategories.Where(b=>b.AppUserID==appUser.ID).ToList()
                },
                expression: a => a.Statu != Statu.Passive
              );
            return View(category);
        }
        public async Task<IActionResult> Follow(int id)
        {
            Category category = _categoryRepository.GetDefault(a => a.ID == id);
            IdentityUser identityUser = await _userManager.GetUserAsync(User);
            AppUser appUser = _appUserRepository.GetDefault(a => a.IdentityId == identityUser.Id);

            category.UserFollowedCategories.Add(new UserFollowedCategory { Category = category, CategoryID = category.ID, AppUser = appUser, AppUserID = appUser.ID });
            _categoryRepository.Update(category);
            return RedirectToAction("List");
        }

        // ToDo 
        public async Task<IActionResult> UnFollow(int id)
        {
            Category category = _categoryRepository.GetDefault(a => a.ID == id);
            IdentityUser identityUser = await _userManager.GetUserAsync(User);
            AppUser appUser = _appUserRepository.GetDefault(a => a.IdentityId == identityUser.Id);

            List<UserFollowedCategory> categoriesList = category.UserFollowedCategories;

            foreach (var item in categoriesList.ToList())
            {
                if (item.AppUserID == appUser.ID && item.CategoryID == id)
                {
                    category.UserFollowedCategories.Remove(item);
                    _categoryRepository.Update(category);
                }
            }
            return RedirectToAction("List");
        } 
    }
}
