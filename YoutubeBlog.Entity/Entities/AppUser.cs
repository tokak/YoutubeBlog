using Microsoft.AspNetCore.Identity;

namespace YoutubeBlog.Entity.Entities
{
    public class AppUser : IdentityUser<Guid>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Guid ImageId { get; set; } = Guid.Parse("74B00590-B51B-4AA5-B8EC-D0CA2F719312");
        public Image Image { get; set; }

        public ICollection<Article> Articles { get; set; }
    }
}
