using BlogProject_5175_06062022.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject_5175_06062022.WEB.Areas.Admin.Models.VMs
{
    public class AdminLastArticlesVM
    {
        public int ID { get; set; }
        public string UserImage { get; set; }
        public string UserFullName { get; set; }
        public DateTime CreateDate { get; set; }
        public Statu Statu { get; set; }
        public string Image { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int CommentCount { get; set; }
        public int LikeCount { get; set; }
        public int TotalCategory { get; set; }
        public int TotalComment { get; set; }
        public int TotalArticle { get; set; }
        public int TotalUser { get; set; }
    }
}
