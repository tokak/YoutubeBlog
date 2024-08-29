using Microsoft.AspNetCore.Identity;
using YoutubeBlog.Core.Entities;

namespace YoutubeBlog.Entity.Entities
{
    public class AppUser : IdentityUser<Guid>, IEntityBase
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Guid ImageId { get; set; } = Guid.Parse("6d559af3-1246-4db4-9e14-fea3909c18f7");
        public Image Image { get; set; }

        public ICollection<Article> Articles { get; set; }
    }
}
