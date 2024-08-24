using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using YoutubeBlog.Entity.Entities;

namespace YoutubeBlog.Data.Mappings
{
    public class ImageMap : IEntityTypeConfiguration<Image>
    {
        public void Configure(EntityTypeBuilder<Image> builder)
        {
            builder.HasData(
               new Image
               {
                   Id = Guid.Parse("74B00590-B51B-4AA5-B8EC-D0CA2F719312"),
                   FileName = "images/test",
                   FileType = "jpg",
                   CreatedBy = "Admin test",
                   CreatedDate = DateTime.Now,
                   IsDeleted = false

               },
               new Image
               {
                   Id = Guid.Parse("6D559AF3-1246-4DB4-9E14-FEA3909C18F8"),
                   FileName = "images/test2",
                   FileType = "png",
                   CreatedBy = "Admin test2",
                   CreatedDate = DateTime.Now,
                   IsDeleted = false

               }
                );
        }
    }
}
