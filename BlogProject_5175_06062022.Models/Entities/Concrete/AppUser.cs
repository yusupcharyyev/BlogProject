using BlogProject_5175_06062022.Models.Abstract;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BlogProject_5175_06062022.Models.Concrete
{
    public class AppUser : BaseEntity
    {
        public AppUser()
        {
            Articles = new List<Article>();
            Comments = new List<Comment>();
            Likes = new List<Like>();
            UserFollowedCategories = new List<UserFollowedCategory>();
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }


        // identity tarafıyla kullanıcıyı eşleştirmek için APPUSER içinde bir identityId property'si tanımlayacağız
        public string IdentityId { get; set; }
        public string FullName => $"{FirstName} {LastName}";


        // User Image(Profile)
        public string Image { get; set; } // fotograf için  - localdeki dosya yolu

        [NotMapped] // bu sınıf konfigure edilirken NOTMAPPED derise bu propty sql de kolon olarak ayağa kalkmaz
        public IFormFile ImagePath { get; set; }



        // navigation Property  --> Defaultta EAGER loading yapıyor ki bizde bu projede öye yapacağız
        // 1 User'in çokça makalesi olabilir.
        public virtual List<Article> Articles { get; set; }

        //1 user'in çokça yorumu olabilir
        public virtual List<Comment> Comments { get; set; }

        // 1 User'in çokça Beğenisi olabilir
        public virtual List<Like> Likes { get; set; }

        //1 User çokça kategoriyi takip etmek isteyebilir
        public virtual List<UserFollowedCategory> UserFollowedCategories { get; set; }
    }
}
