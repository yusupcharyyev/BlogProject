using BlogProject_5175_06062022.Models.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject_5175_06062022.WEB.Areas.Member.Models.VMs
{
    public class GetCategoryVM
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int UserID { get; set; }
     
        public List<UserFollowedCategory> userFollowedCategories { get; set; }
    }
}
