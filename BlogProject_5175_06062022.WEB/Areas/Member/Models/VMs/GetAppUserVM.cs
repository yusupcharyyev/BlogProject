using BlogProject_5175_06062022.Models.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject_5175_06062022.WEB.Areas.Member.Models.VMs
{
    public class GetAppUserVM
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string UserName { get; set; }

        [NotMapped]
        public IFormFile ImagePath { get; set; }

        public string Image { get; set; }

        public string Password { get; set; }


        public List<Article> Articles { get; set; }

        public List<Comment> Comments { get; set; }
        public List<UserFollowedCategory> userFollowedCategories { get; set; }
    }
}
