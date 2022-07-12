using BlogProject_5175_06062022.DAL.Repositories.Interfaces.Concrete;
using BlogProject_5175_06062022.WEB.Areas.Admin.Models.VMs;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogProject_5175_06062022.Models.Enums;
using BlogProject_5175_06062022.Models.Concrete;

namespace BlogProject_5175_06062022.WEB.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CommentController : Controller
    {
        private readonly IAppUserRepository _appUserRepository;
        private readonly ICommentRepository _commentRepository;

        public CommentController(IAppUserRepository appUserRepository, ICommentRepository commentRepository)
        {
            _appUserRepository = appUserRepository;
            _commentRepository = commentRepository;
        }
        public IActionResult AllComment()
        {
            List<GetAllCommentParentVM> getAllCommentVMs = _appUserRepository.GetByDefaults
                (
                    selector: a => new GetAllCommentParentVM
                    {
                        UserId = a.ID,
                        UserImage = a.Image,
                        UserFullName = a.FullName,
                        UserName = a.UserName,
                        getAllCommentChild = a.Comments.Where(b => b.AppUserID == a.ID && b.Statu!=Statu.Passive).ToList()
                    },
                    expression: c => c.Statu != Statu.Passive && c.Comments.Count() != 0,
                    orderby: v => v.OrderByDescending(b => b.CreateDate)
                );
            return View(getAllCommentVMs);
        }
        public IActionResult CommentPending()
        {
            List<GetAllCommentParentVM> getCommentPendingVMs = _appUserRepository.GetByDefaults
                (
                    selector: a => new GetAllCommentParentVM
                    {
                        UserId = a.ID,
                        UserImage = a.Image,
                        UserFullName = a.FullName,
                        UserName = a.UserName,
                        getAllCommentChild = a.Comments.Where(b => b.AppUserID == a.ID && b.Statu==Statu.Passive).ToList()
                    },
                    expression: c => c.Statu != Statu.Passive && c.Comments.Count() != 0,
                    orderby: v => v.OrderByDescending(b => b.CreateDate)
                );
            return View(getCommentPendingVMs);
        }
        public IActionResult CommentActive(int id)
        {
            Comment comment = _commentRepository.GetDefault(a => a.ID == id);
            _commentRepository.Update(comment);
            return RedirectToAction("AllComment", "Comment");
        }
        public IActionResult CommentPassive(int id)
        {
            Comment comment = _commentRepository.GetDefault(a => a.ID == id);
            _commentRepository.Delete(comment);
            return RedirectToAction("AllComment", "Comment");
        }
    }
}
