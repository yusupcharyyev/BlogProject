using BlogProject_5175_06062022.DAL.Repositories.Interfaces.Concrete;
using BlogProject_5175_06062022.WEB.Areas.Admin.Models.VMs;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject_5175_06062022.WEB.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminController : Controller
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly IAppUserRepository _appUserRepository;
        private readonly IArticleRepository _articleRepository;
        private readonly ICategoryRepository _categoryRepository;
        private readonly ICommentRepository _commentRepository;

        public AdminController(SignInManager<IdentityUser> signInManager, IAppUserRepository appUserRepository, IArticleRepository articleRepository, ICategoryRepository categoryRepository, ICommentRepository commentRepository)
        {
            _signInManager = signInManager;
            _appUserRepository = appUserRepository;
            _articleRepository = articleRepository;
            _categoryRepository = categoryRepository;
            _commentRepository = commentRepository;
        }
        public IActionResult Index()
        {
            List<AdminLastArticlesVM> adimLastArticlesVMs = _articleRepository.GetByDefaults
                (
                    selector: a => new AdminLastArticlesVM
                    {
                        ID = a.ID,
                        UserImage = a.AppUser.Image,
                        UserFullName = a.AppUser.FullName,
                        CreateDate = a.CreateDate,
                        Statu = a.Statu,
                        Image = a.Image,
                        Title = a.Title,
                        Content = a.Content,
                        CommentCount = a.Comments.Count(),
                        LikeCount = a.Likes.Count(),
                        TotalCategory = _categoryRepository.GetAllCategory().Count(),
                        TotalComment = _commentRepository.GetAllComment(),
                        TotalArticle = _articleRepository.GetAllArticle(),
                        TotalUser = _appUserRepository.GetTotalUser()
                    },
                    expression: a => a.ID != 0
                );
            return View(adimLastArticlesVMs.OrderByDescending(a => a.CreateDate).Take(10).ToList());
        }

        public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();
            return Redirect("~/");
        }
    }
}
