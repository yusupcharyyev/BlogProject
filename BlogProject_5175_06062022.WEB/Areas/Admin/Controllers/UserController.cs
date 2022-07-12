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
    public class UserController : Controller
    {
        private readonly IAppUserRepository _appUserRepository;

        public UserController(IAppUserRepository appUserRepository)
        {
            _appUserRepository = appUserRepository;
        }
        public IActionResult AllUser()
        {
            List<GetAllUserDTO> getAllUserDto = _appUserRepository.GetByDefaults
                 (
                    selector: a => new GetAllUserDTO
                    {
                        ID = a.ID,
                        FullName = a.FullName,
                        UserName = a.UserName,
                        Statu = a.Statu,
                        Image = a.Image
                    },
                    expression: v => v.Statu != BlogProject_5175_06062022.Models.Enums.Statu.Passive && v.UserName != "yusupcharyyevv",
                    orderby: b => b.OrderByDescending(n => n.CreateDate)
                );
            return View(getAllUserDto);
        }
        public IActionResult UserPassive(int id)
        {
            AppUser appUser = _appUserRepository.GetDefault(a => a.ID == id);
            _appUserRepository.Delete(appUser);
            return RedirectToAction("AllUser", "User");
        }

        public IActionResult UserPending()
        {
            List<GetUserPendingDTO> getUserPendingDto = _appUserRepository.GetByDefaults
                 (
                    selector: a => new GetUserPendingDTO
                    {
                        ID = a.ID,
                        FullName = a.FullName,
                        UserName = a.UserName,
                        Statu = a.Statu,
                        Image = a.Image,
                        CreateDate = a.CreateDate
                    },
                    expression: v => v.Statu == BlogProject_5175_06062022.Models.Enums.Statu.Passive && v.UserName != "yusupcharyyevv",
                    orderby: b => b.OrderByDescending(n => n.CreateDate)
                );
            return View(getUserPendingDto);
        }
        public IActionResult UserActive(int id)
        {
            AppUser appUser = _appUserRepository.GetDefault(a => a.ID == id);
            _appUserRepository.Update(appUser);
            return RedirectToAction("AllUser", "User");
        }
    }
}
