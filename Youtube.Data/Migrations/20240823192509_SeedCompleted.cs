using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace YoutubeBlog.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedCompleted : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Artices",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsDeleted", "ModifiedBy", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("4c26487e-82be-4650-bf33-f50edd724829"), "Admin2 test2", new DateTime(2024, 8, 23, 22, 25, 9, 562, DateTimeKind.Local).AddTicks(988), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), " Asp. Net Core2" },
                    { new Guid("ffa95fc9-78f4-4416-bd29-7be73e398962"), "Admin test", new DateTime(2024, 8, 23, 22, 25, 9, 562, DateTimeKind.Local).AddTicks(985), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), " Asp. Net Core" }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "FileName", "FileType", "IsDeleted", "ModifiedBy", "ModifiedDate" },
                values: new object[,]
                {
                    { new Guid("6d559af3-1246-4db4-9e14-fea3909c18f8"), "Admin test2", new DateTime(2024, 8, 23, 22, 25, 9, 562, DateTimeKind.Local).AddTicks(1565), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "images/test2", "png", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("74b00590-b51b-4aa5-b8ec-d0ca2f719312"), "Admin test", new DateTime(2024, 8, 23, 22, 25, 9, 562, DateTimeKind.Local).AddTicks(1562), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "images/test", "jpg", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Artices",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("1a7634dd-7086-493d-aefa-7071f67537d1"), new Guid("ffa95fc9-78f4-4416-bd29-7be73e398962"), "Test açıklamasıdır", "Admin test", new DateTime(2024, 8, 23, 22, 25, 9, 562, DateTimeKind.Local).AddTicks(114), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("74b00590-b51b-4aa5-b8ec-d0ca2f719312"), false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Asp.net Core Deneme Makalesi", 15 },
                    { new Guid("339991f4-54e6-45c8-a6f1-c5ff3266b278"), new Guid("4c26487e-82be-4650-bf33-f50edd724829"), "Test2  açıklamasıdır", "Admin test2", new DateTime(2024, 8, 23, 22, 25, 9, 562, DateTimeKind.Local).AddTicks(119), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("6d559af3-1246-4db4-9e14-fea3909c18f8"), false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Asp.net Core Deneme Makalesi 2", 15 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Artices",
                keyColumn: "Id",
                keyValue: new Guid("1a7634dd-7086-493d-aefa-7071f67537d1"));

            migrationBuilder.DeleteData(
                table: "Artices",
                keyColumn: "Id",
                keyValue: new Guid("339991f4-54e6-45c8-a6f1-c5ff3266b278"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4c26487e-82be-4650-bf33-f50edd724829"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ffa95fc9-78f4-4416-bd29-7be73e398962"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("6d559af3-1246-4db4-9e14-fea3909c18f8"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("74b00590-b51b-4aa5-b8ec-d0ca2f719312"));

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Artices",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
