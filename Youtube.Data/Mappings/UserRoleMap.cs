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
    public class UserRoleMap : IEntityTypeConfiguration<AppUserRole>
    {
        public void Configure(EntityTypeBuilder<AppUserRole> builder)
        {
            // Primary key
            builder.HasKey(r => new { r.UserId, r.RoleId });

            // Maps to the AspNetUserRoles table
            builder.ToTable("AspNetUserRoles");

            builder.HasData(new AppUserRole
            {
                RoleId = Guid.Parse("65B4D1A1-9221-433D-BFF7-24295959BAC0"),
                UserId = Guid.Parse("2BAFF7A7-3BF5-4CF6-9597-22456A581A0B")
            },
            new AppUserRole
            {
                UserId = Guid.Parse("495B2FCD-5083-4633-B12D-2DDDDF460438"),
                RoleId = Guid.Parse("737FAC16-B522-4E00-AFC4-5D0CF12804E2")
            });
        }
    }
}
