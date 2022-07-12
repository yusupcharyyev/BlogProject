using BlogProject_5175_06062022.Models.Concrete;
using BlogProject_5175_06062022.WEB.Models;
using BlogProject_5175_06062022.WEB.Models.DTOs;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using BlogProject_5175_06062022.Models.Enums;
using AutoMapper;
using BlogProject_5175_06062022.DAL.Repositories.Interfaces.Concrete;

namespace BlogProject_5175_06062022.WEB.Controllers
{
    public class HomeController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly IMapper _autoMapper;
        private readonly IAppUserRepository _appUserRepository;

        public HomeController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager, IMapper autoMapper, IAppUserRepository appUserRepository)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _autoMapper = autoMapper;
            _appUserRepository = appUserRepository;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginDTO loginDTO)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    IdentityUser identityUser = await _userManager.FindByEmailAsync(loginDTO.Mail);

                    AppUser appUser = _appUserRepository.GetDefault(a => a.IdentityId == identityUser.Id);

                    if (identityUser != null)
                    {
                        await _signInManager.SignOutAsync(); // içerdeki cookie'de biri varsa silinsin
                        Microsoft.AspNetCore.Identity.SignInResult result = await _signInManager.PasswordSignInAsync(identityUser, loginDTO.Password, true, true);

                        if (result.Succeeded && appUser.Statu != Statu.Passive)
                        {
                            string role = (await _userManager.GetRolesAsync(identityUser)).FirstOrDefault();
                            if (role=="Admin")
                            {
                                return RedirectToAction("Index", "Admin", new { area = role });
                            }
                            else if (role== "Member")
                            {
                                return RedirectToAction("Index", "AppUser", new { area = role });
                            }
                        }
                        else
                        {
                            ModelState.AddModelError("Error", "Hesabınız Aktif Duruma getirilmemiş veya girilen bilgiler hatalı");
                        }
                    }
                }
            }
            catch (Exception)
            {
                ModelState.AddModelError("Error", "Lütfen bilgileri doğru giriniz");
            }

            return View(loginDTO);
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
