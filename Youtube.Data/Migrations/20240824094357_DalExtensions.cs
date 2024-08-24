using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace YoutubeBlog.Data.Migrations
{
    /// <inheritdoc />
    public partial class DalExtensions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Artices",
                keyColumn: "Id",
                keyValue: new Guid("1a7634dd-7086-493d-aefa-7071f67537d1"));

            migrationBuilder.DeleteData(
                table: "Artices",
                keyColumn: "Id",
                keyValue: new Guid("339991f4-54e6-45c8-a6f1-c5ff3266b278"));

            migrationBuilder.InsertData(
                table: "Artices",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("041e2bb1-7292-4c33-91d1-f06f25a27e6c"), new Guid("4c26487e-82be-4650-bf33-f50edd724829"), "Test2  açıklamasıdır", "Admin test2", new DateTime(2024, 8, 24, 12, 43, 57, 283, DateTimeKind.Local).AddTicks(5033), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("6d559af3-1246-4db4-9e14-fea3909c18f8"), false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Asp.net Core Deneme Makalesi 2", 15 },
                    { new Guid("10bad6ff-ee4b-4914-ad14-2a95a9b7bd94"), new Guid("ffa95fc9-78f4-4416-bd29-7be73e398962"), "Test açıklamasıdır", "Admin test", new DateTime(2024, 8, 24, 12, 43, 57, 283, DateTimeKind.Local).AddTicks(5027), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("74b00590-b51b-4aa5-b8ec-d0ca2f719312"), false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Asp.net Core Deneme Makalesi", 15 }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4c26487e-82be-4650-bf33-f50edd724829"),
                column: "CreatedDate",
                value: new DateTime(2024, 8, 24, 12, 43, 57, 283, DateTimeKind.Local).AddTicks(5917));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ffa95fc9-78f4-4416-bd29-7be73e398962"),
                column: "CreatedDate",
                value: new DateTime(2024, 8, 24, 12, 43, 57, 283, DateTimeKind.Local).AddTicks(5914));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("6d559af3-1246-4db4-9e14-fea3909c18f8"),
                column: "CreatedDate",
                value: new DateTime(2024, 8, 24, 12, 43, 57, 283, DateTimeKind.Local).AddTicks(6404));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("74b00590-b51b-4aa5-b8ec-d0ca2f719312"),
                column: "CreatedDate",
                value: new DateTime(2024, 8, 24, 12, 43, 57, 283, DateTimeKind.Local).AddTicks(6401));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Artices",
                keyColumn: "Id",
                keyValue: new Guid("041e2bb1-7292-4c33-91d1-f06f25a27e6c"));

            migrationBuilder.DeleteData(
                table: "Artices",
                keyColumn: "Id",
                keyValue: new Guid("10bad6ff-ee4b-4914-ad14-2a95a9b7bd94"));

            migrationBuilder.InsertData(
                table: "Artices",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("1a7634dd-7086-493d-aefa-7071f67537d1"), new Guid("ffa95fc9-78f4-4416-bd29-7be73e398962"), "Test açıklamasıdır", "Admin test", new DateTime(2024, 8, 23, 22, 25, 9, 562, DateTimeKind.Local).AddTicks(114), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("74b00590-b51b-4aa5-b8ec-d0ca2f719312"), false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Asp.net Core Deneme Makalesi", 15 },
                    { new Guid("339991f4-54e6-45c8-a6f1-c5ff3266b278"), new Guid("4c26487e-82be-4650-bf33-f50edd724829"), "Test2  açıklamasıdır", "Admin test2", new DateTime(2024, 8, 23, 22, 25, 9, 562, DateTimeKind.Local).AddTicks(119), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("6d559af3-1246-4db4-9e14-fea3909c18f8"), false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Asp.net Core Deneme Makalesi 2", 15 }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4c26487e-82be-4650-bf33-f50edd724829"),
                column: "CreatedDate",
                value: new DateTime(2024, 8, 23, 22, 25, 9, 562, DateTimeKind.Local).AddTicks(988));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ffa95fc9-78f4-4416-bd29-7be73e398962"),
                column: "CreatedDate",
                value: new DateTime(2024, 8, 23, 22, 25, 9, 562, DateTimeKind.Local).AddTicks(985));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("6d559af3-1246-4db4-9e14-fea3909c18f8"),
                column: "CreatedDate",
                value: new DateTime(2024, 8, 23, 22, 25, 9, 562, DateTimeKind.Local).AddTicks(1565));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("74b00590-b51b-4aa5-b8ec-d0ca2f719312"),
                column: "CreatedDate",
                value: new DateTime(2024, 8, 23, 22, 25, 9, 562, DateTimeKind.Local).AddTicks(1562));
        }
    }
}
