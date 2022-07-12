namespace BlogProject_5175_06062022.Models.Concrete
{
    public class Like
    {
        // BaseEntity'den kalıtım almamaktadır çünkü beğeni için CRUD operasyonlarının tümü geçerli değildir.

        //Like kime ait ?
        public int AppUserID { get; set; }
        public virtual AppUser AppUser { get; set; }

        // Like hangi makaleye ait ?
        public int ArticleID { get; set; }
        public virtual Article Article { get; set; }
    }
}