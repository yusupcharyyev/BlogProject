using BlogProject_5175_06062022.DAL.Repositories.Interfaces.Concrete;
using BlogProject_5175_06062022.WEB.Models.VMs;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogProject_5175_06062022.Models.Enums;
using Microsoft.EntityFrameworkCore;
using BlogProject_5175_06062022.Models.Concrete;

namespace BlogProject_5175_06062022.WEB.Views.Shared.Components.Articles
{
    [ViewComponent(Name = "Articles")]
    public class ArticlesViewComponent : ViewComponent
    {
        // oluşma tarihine göre güncel 10 makaleyi göstereceğiz
        private readonly IArticleRepository _articleRepository;
        public ArticlesViewComponent(IArticleRepository articleRepository)
        {
            _articleRepository = articleRepository;
        }
        public IViewComponentResult Invoke()
        {
            List<GetArticleWithUserVM> articles = _articleRepository.GetByDefaults
                (
                    selector: a => new GetArticleWithUserVM()
                    {
                        Title = a.Title,
                        Content = a.Content,
                        CreatedDate = a.CreateDate,
                        ArticleId = a.ID,
                        //Image = a.Image,
                        UserId=a.AppUser.ID,
                        UserFullName=a.AppUser.FullName,
                        Categories = a.Categorys,
                        UserArticleImage =a.AppUser.Image
                    },
                    expression : a=>a.Statu!=Statu.Passive,
                    include: a => a.Include(a => a.AppUser).Include(a => a.Categorys),
                    orderby: a => a.OrderByDescending(a => a.CreateDate)
                );

            return View(articles.Take(6).ToList());
        }
    }
}
