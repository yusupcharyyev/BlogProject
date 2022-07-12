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
    public class CommentRepository : BaseRepository<Comment>, ICommentRepository
    {
        public CommentRepository(ProjectContext context) : base(context)
        {
        }

        public int GetAllComment()
        {
            return _context.Comments.Count();
        }
    }
}
