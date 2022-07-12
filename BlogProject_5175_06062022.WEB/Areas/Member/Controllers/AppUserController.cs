using BlogProject_5175_06062022.DAL.Repositories.Interfaces.Concrete;
using BlogProject_5175_06062022.Models.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject_5175_06062022.WEB.Areas.Member.Controllers
{
    [Area("Member")]
    public class AppUserController : Controller
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly IAppUserRepository _appUserRepository;
        private readonly UserManager<IdentityUser> _userManager;

        public AppUserController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager, IAppUserRepository appUserRepository)
        {
            _signInManager = signInManager;
            _appUserRepository = appUserRepository;
            _userManager = userManager;
        }
        public async Task<IActionResult> Index()
        {
            string CookieValue = Request.Cookies["KullaniciCokie"];
            if (CookieValue != null)
            {
                IdentityUser identityUser = await _userManager.GetUserAsync(User);
                AppUser user = _appUserRepository.GetDefault(a => a.IdentityId == identityUser.Id);
                if (user != null)
                {
                    return View(user);
                }
                return Redirect("~/"); // areasiz başlangıç sayfasına gider   Home/index
            }
            else
            {
                return Redirect("~/");
            }
        }

        public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();
            return Redirect("~/");
        }
    }
}
