using AutoMapper;
using BlogProject_5175_06062022.DAL.Repositories.Interfaces.Concrete;
using BlogProject_5175_06062022.Models.Concrete;
using BlogProject_5175_06062022.WEB.Areas.Member.Models.DTOs;
using BlogProject_5175_06062022.WEB.Areas.Member.Models.VMs;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogProject_5175_06062022.Models.Enums;
using Microsoft.EntityFrameworkCore;

namespace BlogProject_5175_06062022.WEB.Areas.Member.Controllers
{
    [Area("Member")]
    public class ProfileController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IAppUserRepository _appUserRepository;
        private readonly IMapper _mapper;
        private readonly ICommentRepository _commentRepository;
        private readonly IUserFollowedCategory _userFollowedCategory;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly IArticleRepository _articleRepository;

        public ProfileController(UserManager<IdentityUser> userManager, IAppUserRepository appUserRepository, IMapper mapper, IArticleRepository articleRepository, ICommentRepository commentRepository, IUserFollowedCategory userFollowedCategory, SignInManager<IdentityUser> signInManager)
        {
            _userManager = userManager;
            _appUserRepository = appUserRepository;
            _mapper = mapper;
            _articleRepository = articleRepository;
            _commentRepository = commentRepository;
            _userFollowedCategory = userFollowedCategory;
            _signInManager = signInManager;
        }


        [HttpGet]
        public async Task<IActionResult> Edit()
        {
            IdentityUser identityUser = await _userManager.GetUserAsync(User);
            AppUser appUser = _appUserRepository.GetDefault(a => a.IdentityId == identityUser.Id);

            var UserMapper = _appUserRepository.GetByDefault
                (
                    selector: a => new GetAppUserVM
                    {
                        ID = a.ID,
                        FirstName = a.FirstName,
                        LastName = a.LastName,
                        UserName = a.UserName,
                        Image = a.Image,
                        Password = a.Password,
                        Articles = a.Articles.Where(n => n.AppUserID == appUser.ID && n.Statu != Statu.Passive).ToList(),
                        Comments = a.Comments.Where(m => m.AppUserID == appUser.ID && m.Statu != Statu.Passive).ToList(),
                        userFollowedCategories = a.UserFollowedCategories.Where(v => v.AppUserID == appUser.ID).ToList()
                    },
                    expression: a => a.Statu != Statu.Passive && a.ID == appUser.ID
                );

            return View(UserMapper);
        }


        [HttpPost]
        public async Task<IActionResult> Edit(GetAppUserVM userDTO)
        {
            IdentityUser identityUser = await _userManager.GetUserAsync(User);
            AppUser appUser = _appUserRepository.GetDefault(a => a.IdentityId == identityUser.Id);
            try
            {

                if (ModelState.IsValid && userDTO.ImagePath != null)
                {
                    //_signInManager.CheckPasswordSignInAsync(identityUser, userDTO.Password, true);
                    using var img = Image.Load(userDTO.ImagePath.OpenReadStream());
                    img.Save($"wwwroot/images/userImg/{userDTO.UserName}.jpg");
                    appUser.Image = ($"/images/userImg/{userDTO.UserName}.jpg");

                    appUser.FirstName = userDTO.FirstName;
                    appUser.LastName = userDTO.LastName;
                    appUser.UserName = userDTO.UserName;
                    appUser.Password = userDTO.Password;

                    _appUserRepository.Update(appUser);
                    TempData["Success"] = "Bilgileriniz Başarıyla Güncellendi";
                    return RedirectToAction("Edit", "Profile");
                }
                else
                {
                    ModelState.AddModelError("Error", "Lütfen bilgileri eksiksiz giriniz");
                    userDTO.Articles = appUser.Articles;
                    userDTO.Comments = appUser.Comments;
                    userDTO.userFollowedCategories = appUser.UserFollowedCategories;
                    userDTO.Image = appUser.Image;
                    return View(userDTO);
                }
            }
            catch (Exception e)
            {
                ModelState.AddModelError("Error", e.ToString());
                userDTO.Articles = appUser.Articles;
                userDTO.Comments = appUser.Comments;
                userDTO.userFollowedCategories = appUser.UserFollowedCategories;
                userDTO.Image = appUser.Image;
                return View(userDTO);
            }
        }

        public async Task<IActionResult> AccountDelete()
        {
            IdentityUser identityUser = await _userManager.GetUserAsync(User);
            AppUser appUser = _appUserRepository.GetDefault(a => a.IdentityId == identityUser.Id);
            _appUserRepository.Delete(appUser);

            await _signInManager.SignOutAsync();
            return Redirect("~/");
        }
    }
}
