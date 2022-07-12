using BlogProject_5175_06062022.DAL.Repositories.Interfaces.Concrete;
using BlogProject_5175_06062022.Models.Concrete;
using BlogProject_5175_06062022.WEB.Models.VMs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject_5175_06062022.WEB.Controllers
{
    public class ArticlesController : Controller
    {
        private readonly IArticleRepository _articleRepository;

        public ArticlesController(IArticleRepository articleRepository)
        {
            _articleRepository = articleRepository;
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            GetArticleDetailsVM getArticleDetailsVM = _articleRepository.GetByDefault
                (
                    selector: a=> new GetArticleDetailsVM
                    {
                        ID=a.ID,
                        Title=a.Title,
                        Content=a.Content,
                        UserArticleImage=a.AppUser.Image,
                        Categories = a.Categorys,
                        CreatedDate=a.CreateDate,
                        Image=a.Image,
                        UserId=a.AppUserID,
                        UserFullName=a.AppUser.UserName,
                        LikeCount=a.Likes.Count(),
                        CommentCount=a.Comments.Count(),
                        UserImage=a.AppUser.Image,
                        UserName=a.AppUser.FirstName,
                        UserSirname=a.AppUser.LastName,
                        ReadCount=a.ReadCount.Value
                    },
                    expression : a=>a.Statu!=BlogProject_5175_06062022.Models.Enums.Statu.Passive && a.ID== id
                );
            Article article = _articleRepository.GetDefault(a => a.ID == id);
            if (article.ReadCount == null)
                article.ReadCount = 1;
            else
                article.ReadCount += 1;
            _articleRepository.Update(article);

            return View(getArticleDetailsVM);
        }
    }
}
