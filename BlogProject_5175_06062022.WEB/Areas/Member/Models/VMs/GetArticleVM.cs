using BlogProject_5175_06062022.Models.Concrete;
using BlogProject_5175_06062022.Models.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject_5175_06062022.WEB.Areas.Member.Models.VMs
{
    public class GetArticleVM
    {
        public int ArticleID { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Image { get; set; }
        public string UserImage { get; set; }
        public string UserFullName { get; set; }
        public List<ArticleCategory> Categories { get; set; }
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

    }
}
