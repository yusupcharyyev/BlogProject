using BlogProject_5175_06062022.Models.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject_5175_06062022.WEB.Models.VMs
{
    public class GetProfileVM
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Image { get; set; }
        //public int ArticleID { get; set; }
        public List<Article> articles { get; set; }
    }
}
