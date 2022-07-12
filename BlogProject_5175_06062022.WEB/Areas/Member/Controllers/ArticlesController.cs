using AutoMapper;
using BlogProject_5175_06062022.DAL.Repositories.Interfaces.Concrete;
using BlogProject_5175_06062022.Models.Concrete;
using BlogProject_5175_06062022.WEB.Areas.Member.Models.DTOs;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogProject_5175_06062022.Models.Enums;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;
using BlogProject_5175_06062022.WEB.Areas.Member.Models.VMs;
using Microsoft.EntityFrameworkCore;
using BlogProject_5175_06062022.Models.Entities.Concrete;

namespace BlogProject_5175_06062022.WEB.Areas.Member.Controllers
{
    [Area("Member")]
    public class ArticlesController : Controller
    {
        private readonly IArticleRepository _articleRepository;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IMapper _mapper;
        private readonly IAppUserRepository _appUserRepository;
        private readonly ICategoryRepository _categoryRepository;
        private readonly ILikeRepository _likeRepository;
        private readonly ICommentRepository _commentRepository;
        private readonly IArticleCategoryRepository _articleCategoryRepository;

        public ArticlesController(IArticleRepository articleRepository, UserManager<IdentityUser> userManager, IMapper mapper, IAppUserRepository appUserRepository, ICategoryRepository categoryRepository, ILikeRepository likeRepository, ICommentRepository commentRepository, IArticleCategoryRepository articleCategoryRepository)
        {
            _articleRepository = articleRepository;
            _userManager = userManager;
            _mapper = mapper;
            _appUserRepository = appUserRepository;
            _categoryRepository = categoryRepository;
            _likeRepository = likeRepository;
            _commentRepository = commentRepository;
            _articleCategoryRepository = articleCategoryRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            IdentityUser identityUser = await _userManager.GetUserAsync(User);
            AppUser appUser = _appUserRepository.GetDefault(a => a.IdentityId == identityUser.Id);

            CreateArticleDTO createArticleDTO = new CreateArticleDTO()
            {
                Categories = _categoryRepository.GetByDefaults
                (
                    selector: a => new GetCategoryDTO
                    {
                        ID = a.ID,
                        Name = a.Name
                    },
                    expression: a => a.Statu != Statu.Passive
                ),
                AppUserID = appUser.ID,
            };
            return View(createArticleDTO);
        }

        [HttpPost]
        public IActionResult Create(CreateArticleDTO createArticleDTO)
        {
            if (ModelState.IsValid)
            {
                var article = _mapper.Map<Article>(createArticleDTO);
                if (article.ImagePath != null)
                {
                    using var image = Image.Load(createArticleDTO.ImagePath.OpenReadStream());
                    image.Mutate(a => a.Resize(1000, 900)); // mutate : değiştirmek demek aslıda

                    Guid guid = Guid.NewGuid();
                    image.Save($"wwwroot/images/articleimg/{guid}.jpg");  // root altına foto kaydeder
                    article.Image = ($"/images/articleimg/{guid}.jpg");  // veritabanına yolu kaydeder

                    _articleRepository.Create(article);

                    var NewArticle = _articleRepository.GetDefault(a => a.Title == createArticleDTO.Title);
                    ArticleCategory articleCategory = new ArticleCategory();
                    for (int i = 0; i < createArticleDTO.CategoryID.Count(); i++)
                    {
                        articleCategory.Article = NewArticle;
                        articleCategory.ArticleID = NewArticle.ID;
                        articleCategory.Category = _categoryRepository.GetDefault(b => b.ID == createArticleDTO.CategoryID[i]);
                        articleCategory.CategoryID = createArticleDTO.CategoryID[i];
                        _articleCategoryRepository.Create(articleCategory);
                    }
                    return RedirectToAction("List", "Articles");
                }
            }
            /*ToDo => validasyonu geçemezse categories patlamasın diye listeyi doldurup return view alalım.   NOT: Method*/
            return View(createArticleDTO);
        }

        [HttpGet]
        public async Task<IActionResult> List()
        {
            IdentityUser identityUser = await _userManager.GetUserAsync(User);
            AppUser appUser = _appUserRepository.GetDefault(a => a.IdentityId == identityUser.Id);

            //List<Article> article = _articleRepository.GetDefaults(a => a.AppUserID == appUser.ID);
            var article = _articleRepository.GetByDefaults
                (
                    selector: a => new GetArticleVM
                    {
                        ArticleID = a.ID,
                        Title = a.Title,
                        CreatedDate = a.CreateDate,
                        UserImage = a.AppUser.Image,
                        Content = a.Content,
                        Categories = a.Categorys,
                        Image = a.Image,
                        UserFullName = a.AppUser.FullName
                    },
                    expression: a => a.Statu != Statu.Passive,
                    include: a => a.Include(a => a.AppUser).Include(a => a.Categorys),
                    orderby: a => a.OrderByDescending(b => b.CreateDate)
                );
            return View(article);
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            Article article = _articleRepository.GetDefault(a => a.ID == id);

            var articleMap = _mapper.Map<UpdateArticleDTO>(article);
            articleMap.Categories = _categoryRepository.GetByDefaults
                (
                    selector: a => new GetCategoryDTO
                    {
                        ID = a.ID,
                        Name = a.Name
                    },
                    expression: a => a.Statu != Statu.Passive
                );
            return View(articleMap);
        }

        [HttpPost]
        public IActionResult Update(UpdateArticleDTO dTO)
        {
            if (ModelState.IsValid)
            {
                var article = _mapper.Map<Article>(dTO);
                if (dTO.ImagePath != null)
                {

                    using var image = Image.Load(dTO.ImagePath.OpenReadStream());
                    image.Mutate(a => a.Resize(1000, 900)); // mutate : değiştirmek demek aslıda

                    Guid guid = Guid.NewGuid();
                    image.Save($"wwwroot/images/articleimg/{guid}.jpg");  // root altına foto kaydeder
                    article.Image = ($"/images/articleimg/{guid}.jpg");  // veritabanına yolu kaydeder

                    _articleRepository.Update(article);
                    return RedirectToAction("List");

                    // ToDo: photo güncellendiğinde eski image silinsin
                    // component
                }
            }

            return View(dTO);
        }

        [HttpGet]
        public IActionResult Details(int id)
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
                        Image = a.Image,
                        UserId = a.AppUserID,
                        UserFullName = a.AppUser.UserName,
                        LikeCount = a.Likes.Count(),
                        CommentCount = a.Comments.Where(b=>b.Statu!=Statu.Passive).Count(),
                        UserImage = a.AppUser.Image,
                        UserName = a.AppUser.FirstName,
                        UserSirname = a.AppUser.LastName,
                        comments = (List<Comment>)a.Comments.OrderByDescending(a => a.CreateDate),
                        likes = a.Likes,
                        ReadCount=a.ReadCount.Value
                    },
                    expression: a => a.Statu != Statu.Passive && a.ID == id
                );
            Article article = _articleRepository.GetDefault(a => a.ID == id);
            if (article.ReadCount == null)
                article.ReadCount = 1;
            else
                article.ReadCount += 1;
            _articleRepository.Update(article);
            return View(getArticleDetailsVM);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            Article article = _articleRepository.GetDefault(a => a.ID == id);
            _articleRepository.Delete(article);
            return RedirectToAction("Edit", "Profile");
        }


        public async Task<IActionResult> LikeDisLike(int id)
        {
            IdentityUser identityUser = await _userManager.GetUserAsync(User);
            AppUser appUser = _appUserRepository.GetDefault(a => a.IdentityId == identityUser.Id);
            Article article = _articleRepository.GetDefault(a => a.ID == id);
            var result = _likeRepository.GetResult(a => a.AppUserID == appUser.ID && a.ArticleID == id);
            if (result == true)
            {
                Like like = _likeRepository.GetLike(a => a.AppUserID == appUser.ID && a.ArticleID == id);
                _likeRepository.Delete(like);
            }
            else
            {
                Like like = new Like()
                {
                    AppUser = appUser,
                    AppUserID = appUser.ID,
                    Article = article,
                    ArticleID = id
                };
                _likeRepository.Create(like);
            }
            return RedirectToAction("Details", "Articles", new { id = id });
        }

        [HttpPost]
        public async Task<IActionResult> AddComment(GetArticleDetailsVM getArticleDetailsVM)
        {
            IdentityUser identityUser = await _userManager.GetUserAsync(User);
            AppUser appUser = _appUserRepository.GetDefault(a => a.IdentityId == identityUser.Id);
            Article article = _articleRepository.GetDefault(a => a.ID == getArticleDetailsVM.ID);
            Comment comment = new Comment()
            {
                Text = getArticleDetailsVM.comment,
                AppUser = appUser,
                AppUserID = appUser.ID,
                Article = article,
                ArticleID = getArticleDetailsVM.ID
            };
            _commentRepository.Create(comment);
            return RedirectToAction("Details", "Articles", new { id = getArticleDetailsVM.ID });
        }
    }
}
