using BlogProject_5175_06062022.DAL.Repositories.Interfaces.Concrete;
using BlogProject_5175_06062022.Models.Concrete;
using BlogProject_5175_06062022.Models.Enums;
using BlogProject_5175_06062022.WEB.Models.VMs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject_5175_06062022.WEB.Views.Shared.Components.GetRandomArticles
{
    [ViewComponent(Name = "GetRandomArticles")]
    public class GetRandomArticlesViewComponent : ViewComponent
    {
        private readonly IArticleRepository _articleRepository;

        public GetRandomArticlesViewComponent(IArticleRepository articleRepository)
        {
            _articleRepository = articleRepository;
        }
        public IViewComponentResult Invoke()
        {
            List<GetRandomArticlesVM> articles = _articleRepository.GetByDefaults
                (
                    selector: a => new GetRandomArticlesVM()
                    {
                        Title = a.Title,
                        Content = a.Content,
                        CreatedDate = a.CreateDate,
                        ArticleId = a.ID,
                        Image = a.Image,
                        UserId = a.AppUser.ID,
                        UserFullName = a.AppUser.FullName,
                        Categories = a.Categorys,
                        UserArticleImage = a.AppUser.Image
                    },
                    expression: a => a.Statu != Statu.Passive,
                    include: a => a.Include(a => a.AppUser).Include(a => a.Categorys)
                );

            return View(articles.ToList());
        }
    }
}
