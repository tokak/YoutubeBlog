using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using YoutubeBlog.Entity.Entities;

namespace YoutubeBlog.Data.Mappings
{
    public class ArticleMap : IEntityTypeConfiguration<Artice>
    {
        public void Configure(EntityTypeBuilder<Artice> builder)
        {
            //builder.Property(x => x.Title).IsRequired();
            //builder.Property(x => x.Title).HasMaxLength(150);

            //Test dataları ekleme
            builder.HasData(
                new Artice
                {
                    Id = Guid.NewGuid(),
                    Title = "Asp.net Core Deneme Makalesi",
                    Content = "Test açıklamasıdır",
                    ViewCount = 15,
                    CategoryId= Guid.Parse("FFA95FC9-78F4-4416-BD29-7BE73E398962"),
                    ImageId = Guid.Parse("74B00590-B51B-4AA5-B8EC-D0CA2F719312"),
                    CreatedBy = "Admin test",
                    CreatedDate = DateTime.Now,
                    IsDeleted = false
                },

                new Artice
                {
                    Id = Guid.NewGuid(),
                    Title = "Asp.net Core Deneme Makalesi 2",
                    Content = "Test2  açıklamasıdır",
                    ViewCount = 15,
                    CategoryId = Guid.Parse("4C26487E-82BE-4650-BF33-F50EDD724829"),
                    ImageId = Guid.Parse("6D559AF3-1246-4DB4-9E14-FEA3909C18F8"),
                    CreatedBy = "Admin test2",
                    CreatedDate = DateTime.Now,
                    IsDeleted = false
                }
            );
        }
    }
}
