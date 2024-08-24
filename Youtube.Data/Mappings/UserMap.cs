using Microsoft.AspNetCore.Identity;
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
    public class UserMap : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            // Primary key
            builder.HasKey(u => u.Id);

            // Indexes for "normalized" username and email, to allow efficient lookups
            builder.HasIndex(u => u.NormalizedUserName).HasName("UserNameIndex").IsUnique();
            builder.HasIndex(u => u.NormalizedEmail).HasName("EmailIndex");

            // Maps to the AspNetUsers table
            builder.ToTable("AspNetUsers");

            // A concurrency token for use with the optimistic concurrency checking
            builder.Property(u => u.ConcurrencyStamp).IsConcurrencyToken();

            // Limit the size of columns to use efficient database types
            builder.Property(u => u.UserName).HasMaxLength(100);
            builder.Property(u => u.NormalizedUserName).HasMaxLength(256);
            builder.Property(u => u.Email).HasMaxLength(100);
            builder.Property(u => u.NormalizedEmail).HasMaxLength(256);

            // The relationships between User and other entity types
            // Note that these relationships are configured with no navigation properties

            // Each User can have many UserClaims
            builder.HasMany<AppUserClaim>().WithOne().HasForeignKey(uc => uc.UserId).IsRequired();

            // Each User canApphave many UserLogins
            builder.HasMany<AppUserLogin>().WithOne().HasForeignKey(ul => ul.UserId).IsRequired();

            // Each User canApphave many UserTokens
            builder.HasMany<AppUserToken>().WithOne().HasForeignKey(ut => ut.UserId).IsRequired();

            // Each User canApphave many entries in the UserRole join table
            builder.HasMany<AppUserRole>().WithOne().HasForeignKey(ur => ur.UserId).IsRequired();


            var superadmin = new AppUser
            {
                Id = Guid.Parse("2BAFF7A7-3BF5-4CF6-9597-22456A581A0B"),
                UserName = "superadmin@gmail.com",
                NormalizedEmail = "SUPERADMIN@GMAIL.COM",
                Email = "superadmin@gmail.com",
                PhoneNumber = "+9005354212424",
                FirstName = "Murat",
                LastName = "Tokak",
                PhoneNumberConfirmed = true,
                EmailConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString(),
                ImageId = Guid.Parse("74B00590-B51B-4AA5-B8EC-D0CA2F719312")

            };
            superadmin.PasswordHash = CreatePasswordHash(superadmin, "123456");

            var admin = new AppUser
            {
                Id = Guid.Parse("495B2FCD-5083-4633-B12D-2DDDDF460438"),
                UserName = "admin@gmail.com",
                NormalizedEmail = "ADMIN@GMAIL.COM",
                Email = "admin@gmail.com",
                PhoneNumber = "+9005354212425",
                FirstName = "Admin",
                LastName = "User",
                PhoneNumberConfirmed = false,
                EmailConfirmed = false,
                SecurityStamp = Guid.NewGuid().ToString(),
                ImageId = Guid.Parse("6D559AF3-1246-4DB4-9E14-FEA3909C18F8")
            };
            admin.PasswordHash = CreatePasswordHash(admin, "123456");

            builder.HasData(superadmin, admin);

        }
        private string CreatePasswordHash(AppUser user, string password)
        {
            var passwordHash = new PasswordHasher<AppUser>();
            return passwordHash.HashPassword(user, password);
        }
    }
}
