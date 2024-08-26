using Microsoft.AspNetCore.Http;
using YoutubeBlog.Entity.DTOs.Categories;

namespace YoutubeBlog.Entity.DTOs.Articles
{
    public class ArticleAddDto
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public Guid CategoryId { get; set; }

        public IFormFile Photo { get; set; }
        
        //Kategori listeleme    
        public IList<CategoryDto> Categories { get; set; }
    }
}
