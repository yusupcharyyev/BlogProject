using BlogProject_5175_06062022.Models.Abstract;
using BlogProject_5175_06062022.Models.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlogProject_5175_06062022.Models.Concrete
{
    public class Article : BaseEntity
    {
        public Article()
        {
            Likes = new List<Like>();
            Comments = new List<Comment>();
            Categorys = new List<ArticleCategory>();
        }
        public string Title { get; set; }
        public string Content { get; set; }
        public int? ReadCount { get; set; }
        public string Image { get; set; }

        [NotMapped]
        public IFormFile ImagePath { get; set; }

        // Navigation Property

        // 1 makalenin çokça kategorisi olabilir
        public virtual List<ArticleCategory> Categorys { get; set; }

        // 1 makalenin 1 oluşturucusu/kullanıcısı
        public int AppUserID { get; set; }
        public virtual AppUser AppUser { get; set; }

        // 1 makalenin çokça beğenisi
        public virtual List<Like> Likes { get; set; }

        // 1 makalenin çokça yorumu
        public virtual List<Comment> Comments { get; set; }
    }
}