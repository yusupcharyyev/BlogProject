using BlogProject_5175_06062022.Models.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogProject_5175_06062022.Models.Entities.Concrete
{
    public class ArticleCategory
    {
        public int ArticleID { get; set; }
        public virtual Article Article { get; set; }

        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}
