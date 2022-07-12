using BlogProject_5175_06062022.DAL.Repositories.Interfaces.Concrete;
using BlogProject_5175_06062022.Models.Concrete;
using BlogProject_5175_06062022.Models.Enums;
using BlogProject_5175_06062022.WEB.Models.VMs;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject_5175_06062022.WEB.Controllers
{
    public class CategoryFilterController : Controller
    {
        private readonly IArticleRepository _articleRepository;

        public CategoryFilterController(IArticleRepository articleRepository)
        {
            _articleRepository = articleRepository;
        }
        public IActionResult FilterCategory(int id)
        {

            List<GetArticlesFilterCategory> articles = _articleRepository.GetByDefaults
                (
                    selector: a => new GetArticlesFilterCategory()
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
                    expression: a => a.Statu != Statu.Passive && a.Categorys.Where(b=>b.CategoryID==id).Any(),
                    orderby:a=>a.OrderByDescending(a=>a.CreateDate)
                );

            return View(articles.ToList());
        }
    }
}
