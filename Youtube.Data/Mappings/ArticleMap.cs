using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using YoutubeBlog.Entity.Entities;

namespace YoutubeBlog.Data.Mappings
{
    public class ArticleMap : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            //builder.Property(x => x.Title).IsRequired();
            //builder.Property(x => x.Title).HasMaxLength(150);

            //Test dataları ekleme
            builder.HasData(
                new Article
                {
                    Id = Guid.NewGuid(),
                    Title = "Asp.net Core Deneme Makalesi",
                    Content = "Test açıklamasıdır",
                    ViewCount = 15,
                    CategoryId = Guid.Parse("FFA95FC9-78F4-4416-BD29-7BE73E398962"),
                    ImageId = Guid.Parse("74B00590-B51B-4AA5-B8EC-D0CA2F719312"),
                    CreatedBy = "Admin test",
                    CreatedDate = DateTime.Now,
                    IsDeleted = false,
                    UserId = Guid.Parse("2BAFF7A7-3BF5-4CF6-9597-22456A581A0B"),

                },

                new Article
                {
                    Id = Guid.NewGuid(),
                    Title = "Asp.net Core Deneme Makalesi 2",
                    Content = "Test2  açıklamasıdır",
                    ViewCount = 15,
                    CategoryId = Guid.Parse("4C26487E-82BE-4650-BF33-F50EDD724829"),
                    ImageId = Guid.Parse("6D559AF3-1246-4DB4-9E14-FEA3909C18F8"),
                    CreatedBy = "Admin test2",
                    CreatedDate = DateTime.Now,
                    IsDeleted = false,
                    UserId = Guid.Parse("495B2FCD-5083-4633-B12D-2DDDDF460438")
                }
            );
        }
    }
}
