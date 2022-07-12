using BlogProject_5175_06062022.DAL.Repositories.Interfaces.Concrete;
using BlogProject_5175_06062022.Models.Enums;
using BlogProject_5175_06062022.WEB.Areas.Member.Models.VMs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject_5175_06062022.WEB.Areas.Member.Controllers
{
    [Area("Member")]
    public class UserController : Controller
    {
        private readonly IAppUserRepository _appUserRepository;
        public UserController(IAppUserRepository appUserRepository)
        {
            _appUserRepository = appUserRepository;
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

        public IActionResult About()
        {
            return View();
        }
    }
}
