using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeBlog.Entity.Entities;

namespace YoutubeBlog.Data.Mappings
{
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
                new Category
                {
                    Id = Guid.Parse("FFA95FC9-78F4-4416-BD29-7BE73E398962"),
                    Name = " Asp. Net Core",
                    CreatedBy = "Admin test",
                    CreatedDate = DateTime.Now,
                    IsDeleted = false
                },
                new Category
                {
                    Id = Guid.Parse("4C26487E-82BE-4650-BF33-F50EDD724829"),
                    Name = " Asp. Net Core2",
                    CreatedBy = "Admin2 test2",
                    CreatedDate = DateTime.Now,
                    IsDeleted = false
                }

            );
        }
    }
}
