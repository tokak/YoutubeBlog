using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace YoutubeBlog.Data.Migrations
{
    /// <inheritdoc />
    public partial class CreateTableVisitorandArticleVisitors : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Artices",
                keyColumn: "Id",
                keyValue: new Guid("83146479-b724-4829-9660-44b1e201e44a"));

            migrationBuilder.DeleteData(
                table: "Artices",
                keyColumn: "Id",
                keyValue: new Guid("c4dea3a4-3fe1-4b1f-91cc-0314490d1761"));

            migrationBuilder.CreateTable(
                name: "Visitors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IpAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserAgent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Visitors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ArticleVisitors",
                columns: table => new
                {
                    ArticleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VisitorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticleVisitors", x => new { x.ArticleId, x.VisitorId });
                    table.ForeignKey(
                        name: "FK_ArticleVisitors_Artices_ArticleId",
                        column: x => x.ArticleId,
                        principalTable: "Artices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArticleVisitors_Visitors_VisitorId",
                        column: x => x.VisitorId,
                        principalTable: "Visitors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Artices",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "UserId", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("907aed2f-f520-420c-a828-9620b3576a11"), new Guid("ffa95fc9-78f4-4416-bd29-7be73e398962"), "Test açıklamasıdır", "Admin test", new DateTime(2024, 8, 30, 17, 37, 23, 863, DateTimeKind.Local).AddTicks(2329), null, null, new Guid("74b00590-b51b-4aa5-b8ec-d0ca2f719312"), false, null, null, "Asp.net Core Deneme Makalesi", new Guid("2baff7a7-3bf5-4cf6-9597-22456a581a0b"), 15 },
                    { new Guid("a67bc09d-46c5-4fb0-a95f-815bcdf38349"), new Guid("4c26487e-82be-4650-bf33-f50edd724829"), "Test2  açıklamasıdır", "Admin test2", new DateTime(2024, 8, 30, 17, 37, 23, 863, DateTimeKind.Local).AddTicks(2347), null, null, new Guid("6d559af3-1246-4db4-9e14-fea3909c18f8"), false, null, null, "Asp.net Core Deneme Makalesi 2", new Guid("495b2fcd-5083-4633-b12d-2ddddf460438"), 15 }
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("4a1a63b8-c65c-4b34-92b0-d9d63592c33b"),
                column: "ConcurrencyStamp",
                value: "2724359f-f94b-4084-a3a1-2378a2b86bd8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("65b4d1a1-9221-433d-bff7-24295959bac0"),
                column: "ConcurrencyStamp",
                value: "c5756011-fd2a-47d1-a795-7f639b98a680");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("737fac16-b522-4e00-afc4-5d0cf12804e2"),
                column: "ConcurrencyStamp",
                value: "3b7a73dc-7f4d-4b16-8159-de432ed01b6d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2baff7a7-3bf5-4cf6-9597-22456a581a0b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8177373d-9f72-4cf0-b466-0b2b844f8d50", "AQAAAAIAAYagAAAAEKZShavw+hoigBFchCGRwKMiIHTipDlHgOrQs/+OjobHYxGZoUDifDa6xBz8XiiR1A==", "fd8ddbca-1709-4def-ab70-f3c5b2cb404f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("495b2fcd-5083-4633-b12d-2ddddf460438"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "61b28bbc-11c9-413f-91f5-6138717eee93", "AQAAAAIAAYagAAAAEC5G+L6Eiv/sLoYuBi9ek2uC6KWhwID12P65cR0uoMYYTuksznCSYi1zJZcmF5HQ6w==", "bb25a725-37c6-4f60-931d-4acb3526f247" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4c26487e-82be-4650-bf33-f50edd724829"),
                column: "CreatedDate",
                value: new DateTime(2024, 8, 30, 17, 37, 23, 863, DateTimeKind.Local).AddTicks(5564));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ffa95fc9-78f4-4416-bd29-7be73e398962"),
                column: "CreatedDate",
                value: new DateTime(2024, 8, 30, 17, 37, 23, 863, DateTimeKind.Local).AddTicks(5561));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("6d559af3-1246-4db4-9e14-fea3909c18f8"),
                column: "CreatedDate",
                value: new DateTime(2024, 8, 30, 17, 37, 23, 863, DateTimeKind.Local).AddTicks(6228));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("74b00590-b51b-4aa5-b8ec-d0ca2f719312"),
                column: "CreatedDate",
                value: new DateTime(2024, 8, 30, 17, 37, 23, 863, DateTimeKind.Local).AddTicks(6225));

            migrationBuilder.CreateIndex(
                name: "IX_ArticleVisitors_VisitorId",
                table: "ArticleVisitors",
                column: "VisitorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArticleVisitors");

            migrationBuilder.DropTable(
                name: "Visitors");

            migrationBuilder.DeleteData(
                table: "Artices",
                keyColumn: "Id",
                keyValue: new Guid("907aed2f-f520-420c-a828-9620b3576a11"));

            migrationBuilder.DeleteData(
                table: "Artices",
                keyColumn: "Id",
                keyValue: new Guid("a67bc09d-46c5-4fb0-a95f-815bcdf38349"));

            migrationBuilder.InsertData(
                table: "Artices",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "UserId", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("83146479-b724-4829-9660-44b1e201e44a"), new Guid("4c26487e-82be-4650-bf33-f50edd724829"), "Test2  açıklamasıdır", "Admin test2", new DateTime(2024, 8, 28, 22, 55, 6, 570, DateTimeKind.Local).AddTicks(7414), null, null, new Guid("6d559af3-1246-4db4-9e14-fea3909c18f8"), false, null, null, "Asp.net Core Deneme Makalesi 2", new Guid("495b2fcd-5083-4633-b12d-2ddddf460438"), 15 },
                    { new Guid("c4dea3a4-3fe1-4b1f-91cc-0314490d1761"), new Guid("ffa95fc9-78f4-4416-bd29-7be73e398962"), "Test açıklamasıdır", "Admin test", new DateTime(2024, 8, 28, 22, 55, 6, 570, DateTimeKind.Local).AddTicks(7408), null, null, new Guid("74b00590-b51b-4aa5-b8ec-d0ca2f719312"), false, null, null, "Asp.net Core Deneme Makalesi", new Guid("2baff7a7-3bf5-4cf6-9597-22456a581a0b"), 15 }
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("4a1a63b8-c65c-4b34-92b0-d9d63592c33b"),
                column: "ConcurrencyStamp",
                value: "d7c9e336-7de3-483a-9605-ea34367bbae4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("65b4d1a1-9221-433d-bff7-24295959bac0"),
                column: "ConcurrencyStamp",
                value: "eb6ca5d0-2016-4bda-bb46-e728af8d799f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("737fac16-b522-4e00-afc4-5d0cf12804e2"),
                column: "ConcurrencyStamp",
                value: "73ea9a53-79e8-414a-a3fe-af24cc0e9d71");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2baff7a7-3bf5-4cf6-9597-22456a581a0b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fcdc5390-8c0b-42fc-b23d-bbc3512d6db4", "AQAAAAIAAYagAAAAEOFbhk63ZCRpr8dZs6Gem7fnHQjJDjT/TTimFVMVhxUrWJNiqcVHr+g6rlvmLX+ISw==", "313d80ed-609f-492b-97c5-d1be67acba7e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("495b2fcd-5083-4633-b12d-2ddddf460438"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dfb0e780-85f3-458c-852f-1ef3b127fb34", "AQAAAAIAAYagAAAAELG0oDgZj8MY28stgc0XgT8bsuzYougP4yGU28qJlERPs/xCi5oTsAPhvH1N4NwtGA==", "7648eb14-4ad3-46aa-85ae-31a764a7f033" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4c26487e-82be-4650-bf33-f50edd724829"),
                column: "CreatedDate",
                value: new DateTime(2024, 8, 28, 22, 55, 6, 570, DateTimeKind.Local).AddTicks(8313));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ffa95fc9-78f4-4416-bd29-7be73e398962"),
                column: "CreatedDate",
                value: new DateTime(2024, 8, 28, 22, 55, 6, 570, DateTimeKind.Local).AddTicks(8311));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("6d559af3-1246-4db4-9e14-fea3909c18f8"),
                column: "CreatedDate",
                value: new DateTime(2024, 8, 28, 22, 55, 6, 570, DateTimeKind.Local).AddTicks(8818));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("74b00590-b51b-4aa5-b8ec-d0ca2f719312"),
                column: "CreatedDate",
                value: new DateTime(2024, 8, 28, 22, 55, 6, 570, DateTimeKind.Local).AddTicks(8815));
        }
    }
}
