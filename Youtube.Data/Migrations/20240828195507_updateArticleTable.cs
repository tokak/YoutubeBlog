using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace YoutubeBlog.Data.Migrations
{
    /// <inheritdoc />
    public partial class updateArticleTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Artices",
                keyColumn: "Id",
                keyValue: new Guid("1837ad8b-0eda-49d9-a47a-df915fe22053"));

            migrationBuilder.DeleteData(
                table: "Artices",
                keyColumn: "Id",
                keyValue: new Guid("abd12a1d-0b45-457d-ac3e-261a77ad0ece"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "Images",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeletedDate",
                table: "Images",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "Categories",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeletedDate",
                table: "Categories",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "Artices",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeletedDate",
                table: "Artices",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

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
                columns: new[] { "CreatedDate", "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 22, 55, 6, 570, DateTimeKind.Local).AddTicks(8313), null, null });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ffa95fc9-78f4-4416-bd29-7be73e398962"),
                columns: new[] { "CreatedDate", "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 22, 55, 6, 570, DateTimeKind.Local).AddTicks(8311), null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("6d559af3-1246-4db4-9e14-fea3909c18f8"),
                columns: new[] { "CreatedDate", "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 22, 55, 6, 570, DateTimeKind.Local).AddTicks(8818), null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("74b00590-b51b-4aa5-b8ec-d0ca2f719312"),
                columns: new[] { "CreatedDate", "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 22, 55, 6, 570, DateTimeKind.Local).AddTicks(8815), null, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Artices",
                keyColumn: "Id",
                keyValue: new Guid("83146479-b724-4829-9660-44b1e201e44a"));

            migrationBuilder.DeleteData(
                table: "Artices",
                keyColumn: "Id",
                keyValue: new Guid("c4dea3a4-3fe1-4b1f-91cc-0314490d1761"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "Images",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeletedDate",
                table: "Images",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeletedDate",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "Artices",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeletedDate",
                table: "Artices",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Artices",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "UserId", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("1837ad8b-0eda-49d9-a47a-df915fe22053"), new Guid("4c26487e-82be-4650-bf33-f50edd724829"), "Test2  açıklamasıdır", "Admin test2", new DateTime(2024, 8, 24, 19, 18, 17, 625, DateTimeKind.Local).AddTicks(2444), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("6d559af3-1246-4db4-9e14-fea3909c18f8"), false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Asp.net Core Deneme Makalesi 2", new Guid("495b2fcd-5083-4633-b12d-2ddddf460438"), 15 },
                    { new Guid("abd12a1d-0b45-457d-ac3e-261a77ad0ece"), new Guid("ffa95fc9-78f4-4416-bd29-7be73e398962"), "Test açıklamasıdır", "Admin test", new DateTime(2024, 8, 24, 19, 18, 17, 625, DateTimeKind.Local).AddTicks(2439), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("74b00590-b51b-4aa5-b8ec-d0ca2f719312"), false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Asp.net Core Deneme Makalesi", new Guid("2baff7a7-3bf5-4cf6-9597-22456a581a0b"), 15 }
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("4a1a63b8-c65c-4b34-92b0-d9d63592c33b"),
                column: "ConcurrencyStamp",
                value: "49a5c07f-a4bd-443b-90b2-79dce4050b64");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("65b4d1a1-9221-433d-bff7-24295959bac0"),
                column: "ConcurrencyStamp",
                value: "fd5116a9-1d28-471c-ba50-9beb7e7925ee");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("737fac16-b522-4e00-afc4-5d0cf12804e2"),
                column: "ConcurrencyStamp",
                value: "d7d35e62-4a73-45ad-8d16-45a976480eb0");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2baff7a7-3bf5-4cf6-9597-22456a581a0b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dd82ef44-e8c3-490e-815f-b15e40b997da", "AQAAAAIAAYagAAAAEDmX6yNdKeWcn31sNIblkdymsLkf6rHv/NCxn13IBZ7pRiffonu2fBIi9FQlPrMDAQ==", "5f91df37-e2bf-4c50-9f63-6d98644cef83" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("495b2fcd-5083-4633-b12d-2ddddf460438"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "65c7d993-9daa-4ebd-83b2-fbd17c691322", "AQAAAAIAAYagAAAAEGsTiEei4plYfeEChEx3/NrLmTfReh0SB33+nSJuO9sHmlt0nk0kuVTTZJrvTNLuOA==", "85d713d4-1a62-4f42-8e85-f6a42edf8db5" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4c26487e-82be-4650-bf33-f50edd724829"),
                columns: new[] { "CreatedDate", "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 24, 19, 18, 17, 625, DateTimeKind.Local).AddTicks(3303), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ffa95fc9-78f4-4416-bd29-7be73e398962"),
                columns: new[] { "CreatedDate", "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 24, 19, 18, 17, 625, DateTimeKind.Local).AddTicks(3284), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("6d559af3-1246-4db4-9e14-fea3909c18f8"),
                columns: new[] { "CreatedDate", "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 24, 19, 18, 17, 625, DateTimeKind.Local).AddTicks(3790), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("74b00590-b51b-4aa5-b8ec-d0ca2f719312"),
                columns: new[] { "CreatedDate", "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 24, 19, 18, 17, 625, DateTimeKind.Local).AddTicks(3787), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }
    }
}
