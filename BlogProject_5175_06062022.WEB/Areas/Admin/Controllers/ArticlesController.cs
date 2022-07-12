using BlogProject_5175_06062022.DAL.Repositories.Interfaces.Concrete;
using BlogProject_5175_06062022.Models.Concrete;
using BlogProject_5175_06062022.Models.Enums;
using BlogProject_5175_06062022.WEB.Areas.Admin.Models.VMs;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject_5175_06062022.WEB.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ArticlesController : Controller
    {
        private readonly IArticleRepository _articleRepository;
        private readonly IAppUserRepository _appUserRepository;
        private readonly ICommentRepository _commentRepository;

        public ArticlesController(IArticleRepository articleRepository, IAppUserRepository appUserRepository,ICommentRepository commentRepository)
        {
            _articleRepository = articleRepository;
            _appUserRepository = appUserRepository;
            _commentRepository = commentRepository;
        }
        public IActionResult AllArticles()
        {
            List<GetAllArticleParentVM> getAllArticleParentVMs = _appUserRepository.GetByDefaults
                (
                    selector: a => new GetAllArticleParentVM
                    {
                        UserId = a.ID,
                        UserImage = a.Image,
                        UserFullName = a.FullName,
                        UserName = a.UserName,
                        getAllArticleChild = a.Articles.Where(b => b.AppUserID == a.ID).ToList()
                    },
                    expression: c => c.ID != 0 && c.Articles.Count() != 0,
                    orderby: v => v.OrderByDescending(b => b.CreateDate)
                );
            return View(getAllArticleParentVMs);
        }

        public IActionResult EditArticle(int id)
        {
            GetArticleDetailsVM getArticleDetailsVM = _articleRepository.GetByDefault
                (
                    selector: a => new GetArticleDetailsVM
                    {
                        ID = a.ID,
                        Title = a.Title,
                        Content = a.Content,
                        UserArticleImage = a.AppUser.Image,
                        Categories = a.Categorys,
                        CreatedDate = a.CreateDate,
                        Statu = a.Statu,
                        Image = a.Image,
                        UserId = a.AppUserID,
                        UserFullName = a.AppUser.UserName,
                        LikeCount = a.Likes.Count(),
                        CommentCount = a.Comments.Where(b => b.Statu != Statu.Passive).Count(),
                        UserImage = a.AppUser.Image,
                        UserStatu=a.AppUser.Statu,
                        UserName = a.AppUser.FirstName,
                        UserSirname = a.AppUser.LastName,
                        comments = (List<Comment>)a.Comments.OrderByDescending(a => a.CreateDate),
                        likes = a.Likes,
                        ReadCount = a.ReadCount.Value,
                        UserArticleCount = a.AppUser.Articles.Count(),
                        UserFollowCount = a.AppUser.UserFollowedCategories.Count()
                    },
                    expression: a => a.ID == id
                );
            return View(getArticleDetailsVM);
        }

        public IActionResult PassiveArticle(int id)
        {
            Article article = _articleRepository.GetDefault(a => a.ID == id);
            _articleRepository.Delete(article);
            TempData["Pasive"] = article.Title + " Başlıklı Makale Pasife Çekildi";
            return RedirectToAction("EditArticle", "Articles", new { id = id });
        }
        public IActionResult ActiveArticle(int id)
        {
            Article article = _articleRepository.GetDefault(a => a.ID == id);
            _articleRepository.Update(article);
            TempData["Pasive"] = article.Title + " Başlıklı Makale Active Çekildi";
            return RedirectToAction("EditArticle", "Articles", new { id = id });
        }
        public IActionResult PassiveComment(int id, int articleid)
        {
            Comment comment = _commentRepository.GetDefault(a => a.ID == id);
            _commentRepository.Delete(comment);
            TempData["Pasive"] = "Yorum Pasife Çekildi";
            return RedirectToAction("EditArticle", "Articles", new { id = articleid });
        }
        public IActionResult ActiveComment(int id, int articleid)
        {
            Comment comment = _commentRepository.GetDefault(a => a.ID == id);
            _commentRepository.Update(comment);
            TempData["Pasive"] = "Yorum Active Çekildi";
            return RedirectToAction("EditArticle", "Articles", new { id = articleid });
        }
        public IActionResult ArticlePending()
        {
            List<GetArticlePendingVM> getAllCategoryVMs = _appUserRepository.GetByDefaults
                (
                    selector: a => new GetArticlePendingVM
                    {
                        UserId = a.ID,
                        UserImage = a.Image,
                        UserFullName = a.FullName,
                        UserName = a.UserName,
                        getAllArticleChild = a.Articles.Where(b => b.AppUserID == a.ID && b.Statu==Statu.Passive).ToList()
                    },
                    expression: c => c.ID!=0
                );
            return View(getAllCategoryVMs);
        }
    }
}
