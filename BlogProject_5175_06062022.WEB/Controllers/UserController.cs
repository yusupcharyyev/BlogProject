using AutoMapper;
using BlogProject_5175_06062022.DAL.Repositories.Interfaces.Concrete;
using BlogProject_5175_06062022.Models.Concrete;
using BlogProject_5175_06062022.Models.Enums;
using BlogProject_5175_06062022.WEB.Models.DTOs;
using BlogProject_5175_06062022.WEB.Models.VMs;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject_5175_06062022.WEB.Controllers
{
    public class UserController : Controller
    {
        private readonly IAppUserRepository _appUserRepository;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IMapper _mapper;
        private readonly IArticleRepository _articleRepository;

        public UserController(IAppUserRepository appUserRepository, UserManager<IdentityUser> userManager, IMapper mapper, IArticleRepository articleRepository)
        {
            _appUserRepository = appUserRepository;
            _userManager = userManager;
            _mapper = mapper;
            _articleRepository = articleRepository;
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateUserDTO createUserDTO)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    IdentityUser ResultMail = await _userManager.FindByEmailAsync(createUserDTO.Mail);
                    IdentityUser ResultUserName = await _userManager.FindByNameAsync(createUserDTO.UserName);
                    if (ResultMail != null || ResultUserName != null)
                    {
                        ModelState.AddModelError("Warning", "Girilen bilgilere daha önce hesap oluşturulmuş.");
                    }
                    else
                    {
                        string newID = Guid.NewGuid().ToString();
                        IdentityUser identityUser = new IdentityUser { Email = createUserDTO.Mail, UserName = createUserDTO.UserName, Id = newID };
                        IdentityResult result = await _userManager.CreateAsync(identityUser, createUserDTO.Password);
                        if (result.Succeeded)
                        {
                            await _userManager.AddToRoleAsync(identityUser, "Member");
                            //AppUser appUser = new AppUser();
                            //appUser.FirstName = createUserDTO.FirstName;

                            var user = _mapper.Map<AppUser>(createUserDTO);
                            user.IdentityId = newID;

                            if (createUserDTO.ImagePath != null)
                            {
                                using var image = Image.Load(createUserDTO.ImagePath.OpenReadStream());
                                image.Mutate(a => a.Resize(100, 100)); // mutate : değiştirmek demek aslıda
                                image.Save($"wwwroot/images/userImg/{user.UserName}.jpg");  // root altına foto kaydeder
                                user.Image = ($"/images/userImg/{user.UserName}.jpg");  // veritabanına yolu kaydeder
                                _appUserRepository.Create(user);
                                return RedirectToAction("Login", "Home");
                            }
                            else return View(createUserDTO);
                        }
                        else
                        {
                            ModelState.AddModelError("Warning", "Lütfen girilen bilgileri kontrol ediniz!");
                        }
                    }
                }
            }
            catch (Exception)
            {
                ModelState.AddModelError("Warning", "Lütfen girilen bilgileri kontrol ediniz!");
            }
            return View(createUserDTO);
        }

        public IActionResult Profile(int id)
        {
            GetProfileVM articles = _appUserRepository.GetByDefault
                 (
                     selector: a => new GetProfileVM()
                     {
                         ID = a.ID,
                         FirstName = a.FirstName,
                         LastName = a.LastName,
                         UserName = a.UserName,
                         Image = a.Image,
                         articles = a.Articles
                     },
                     expression: a => a.Statu != Statu.Passive && a.ID == id,
                    include: a => a.Include(a => a.Articles).Include(a => a.Articles)
                 );
            return View(articles);
        }
    }
}
