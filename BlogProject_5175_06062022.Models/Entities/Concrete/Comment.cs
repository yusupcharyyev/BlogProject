using BlogProject_5175_06062022.Models.Abstract;

namespace BlogProject_5175_06062022.Models.Concrete
{
    public class Comment : BaseEntity
    {
        public string Text { get; set; }

        // Navigation Property
        // 1 Yorum 1 User'e aittir
        public int AppUserID { get; set; }
        public virtual AppUser AppUser { get; set; }

        // 1 Yorum 1 Article'e aittir.
        public int ArticleID { get; set; }
        public virtual Article Article { get; set; }
    }
}