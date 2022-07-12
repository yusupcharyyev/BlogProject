using BlogProject_5175_06062022.DAL.Context;
using BlogProject_5175_06062022.DAL.Repositories.Abstract;
using BlogProject_5175_06062022.DAL.Repositories.Interfaces.Concrete;
using BlogProject_5175_06062022.Models.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlogProject_5175_06062022.DAL.Repositories.Concrete
{
    public class ArticleRepository : BaseRepository<Article>, IArticleRepository
    {
        public ArticleRepository(ProjectContext context) : base(context)
        {
        }

        public int GetAllArticle()
        {
            return _context.Articles.Count();
        }
    }
}
