using BlogProject_5175_06062022.Models.Concrete;
using BlogProject_5175_06062022.Models.Entities.Concrete;
using BlogProject_5175_06062022.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject_5175_06062022.WEB.Areas.Admin.Models.VMs
{
    public class GetArticleDetailsVM
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreatedDate { get; set; }
        public Statu Statu { get; set; }
        public List<ArticleCategory> Categories { get; set; }
        public int UserId { get; set; }
        public string UserFullName { get; set; }
        public string Image { get; set; }
        public string UserArticleImage { get; set; }

        private int _readTime;

        public int ReadTime
        {
            get
            {
                int totalTime = 0;
                char[] strArray = Content.ToCharArray();
                for (int i = 0; i <= strArray.Length; i += 50)
                {
                    totalTime++;
                }
                return totalTime;
            }
            set { _readTime = value; }
        }

        public int LikeCount { get; set; }
        public int CommentCount { get; set; }
        public string UserImage { get; set; }
        public Statu UserStatu { get; set; }
        public string UserName { get; set; }
        public string UserSirname { get; set; }
        public string comment { get; set; }
        public int ReadCount { get; set; }
        public List<Comment> comments { get; set; }
        public List<Like> likes { get; set; }
        public int UserArticleCount { get; set; }
        public int UserFollowCount { get; set; }
    }
}
