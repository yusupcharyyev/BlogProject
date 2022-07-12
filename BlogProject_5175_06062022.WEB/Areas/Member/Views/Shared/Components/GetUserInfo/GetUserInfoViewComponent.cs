using BlogProject_5175_06062022.DAL.Repositories.Interfaces.Concrete;
using BlogProject_5175_06062022.Models.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject_5175_06062022.WEB.Areas.Member.Views.Shared.Components.GetUserInfo
{
    [ViewComponent(Name = "GetUserInfo")]
    public class GetUserInfoViewComponent : ViewComponent
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IAppUserRepository _appUserRepository;
        private readonly SignInManager<IdentityUser> _signInManager;

        public GetUserInfoViewComponent(UserManager<IdentityUser> userManager, IAppUserRepository appUserRepository, SignInManager<IdentityUser> signInManager)
        {
            _userManager = userManager;
            _appUserRepository = appUserRepository;
            _signInManager = signInManager;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            string CookieValue = Request.Cookies["KullaniciCokie"];
            if (CookieValue != null)
            {
                IdentityUser identityUser = await _userManager.GetUserAsync((System.Security.Claims.ClaimsPrincipal)User);
                AppUser user = _appUserRepository.GetDefault(a => a.IdentityId == identityUser.Id);
                if (user != null)
                {
                    return View(user);
                }
            }
            return View();
        }
    }
}
