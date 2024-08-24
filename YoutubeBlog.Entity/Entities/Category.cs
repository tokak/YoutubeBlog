using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeBlog.Core.Entities;

namespace YoutubeBlog.Entity.Entities
{
    public class Category : EntityBase
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public ICollection<Article> Artices { get; set; }
    }
}
