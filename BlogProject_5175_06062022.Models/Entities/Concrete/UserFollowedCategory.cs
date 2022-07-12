namespace BlogProject_5175_06062022.Models.Concrete
{
    public class UserFollowedCategory
    {
        public int AppUserID { get; set; }
        public virtual AppUser AppUser { get; set; }


        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}