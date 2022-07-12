using BlogProject_5175_06062022.Models.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject_5175_06062022.WEB.Areas.Admin.Models.VMs
{
    public class GetArticlePendingVM
    {
        public int UserId { get; set; }
        public string UserImage { get; set; }
        public string UserFullName { get; set; }
        public string UserName { get; set; }
        public List<Article> getAllArticleChild { get; set; }
    }
}
