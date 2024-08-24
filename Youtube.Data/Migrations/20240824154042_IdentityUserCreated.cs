using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace YoutubeBlog.Data.Migrations
{
    /// <inheritdoc />
    public partial class IdentityUserCreated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Artices",
                keyColumn: "Id",
                keyValue: new Guid("041e2bb1-7292-4c33-91d1-f06f25a27e6c"));

            migrationBuilder.DeleteData(
                table: "Artices",
                keyColumn: "Id",
                keyValue: new Guid("10bad6ff-ee4b-4914-ad14-2a95a9b7bd94"));

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Artices",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("47f064f5-dcff-428e-a3b9-754899b9bbbc"), new Guid("ffa95fc9-78f4-4416-bd29-7be73e398962"), "Test açıklamasıdır", "Admin test", new DateTime(2024, 8, 24, 18, 40, 42, 278, DateTimeKind.Local).AddTicks(5630), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("74b00590-b51b-4aa5-b8ec-d0ca2f719312"), false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Asp.net Core Deneme Makalesi", 15 },
                    { new Guid("6b90bce8-c990-4109-9fb8-3f90764a7e4c"), new Guid("4c26487e-82be-4650-bf33-f50edd724829"), "Test2  açıklamasıdır", "Admin test2", new DateTime(2024, 8, 24, 18, 40, 42, 278, DateTimeKind.Local).AddTicks(5635), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("6d559af3-1246-4db4-9e14-fea3909c18f8"), false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Asp.net Core Deneme Makalesi 2", 15 }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("4a1a63b8-c65c-4b34-92b0-d9d63592c33b"), "571fb7f5-8d4d-4ac1-b441-a5b6e6931987", "User", "USER" },
                    { new Guid("65b4d1a1-9221-433d-bff7-24295959bac0"), "e5de1ea1-9962-4f6a-a97a-e39680fcffaa", "Superadmin", "SUPERADMIN" },
                    { new Guid("737fac16-b522-4e00-afc4-5d0cf12804e2"), "9b9a1456-daa0-4053-a6a2-04f41ac6c707", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("2baff7a7-3bf5-4cf6-9597-22456a581a0b"), 0, "d3dfe3a5-64e7-49b0-b154-12373ca17fac", "superadmin@gmail.com", true, "Murat", "Tokak", false, null, "SUPERADMIN@GMAIL.COM", null, "AQAAAAIAAYagAAAAEEaRYP3cxHrRK88CYDQaZBxVXYcQ14lliUOf8TuwPnOX4ms/AW5O5tRwadLR6QZmMQ==", "+9005354212424", true, "aa249509-64ff-4ff9-b584-a341aa279395", false, "superadmin@gmail.com" },
                    { new Guid("495b2fcd-5083-4633-b12d-2ddddf460438"), 0, "683b9cc6-1fff-4993-a1d5-3131c3179e85", "admin@gmail.com", false, "Admin", "User", false, null, "ADMIN@GMAIL.COM", null, "AQAAAAIAAYagAAAAEPytd+j5l8jGJkC/oU5TciP4ryu0SKwF+Nw41uJ+M/JBviOrzoKBPYhiwUU3c/JdbA==", "+9005354212425", false, "000fb032-fe67-4a76-8acc-aebd874d61a7", false, "admin@gmail.com" }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4c26487e-82be-4650-bf33-f50edd724829"),
                column: "CreatedDate",
                value: new DateTime(2024, 8, 24, 18, 40, 42, 278, DateTimeKind.Local).AddTicks(6557));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ffa95fc9-78f4-4416-bd29-7be73e398962"),
                column: "CreatedDate",
                value: new DateTime(2024, 8, 24, 18, 40, 42, 278, DateTimeKind.Local).AddTicks(6554));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("6d559af3-1246-4db4-9e14-fea3909c18f8"),
                column: "CreatedDate",
                value: new DateTime(2024, 8, 24, 18, 40, 42, 278, DateTimeKind.Local).AddTicks(7081));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("74b00590-b51b-4aa5-b8ec-d0ca2f719312"),
                column: "CreatedDate",
                value: new DateTime(2024, 8, 24, 18, 40, 42, 278, DateTimeKind.Local).AddTicks(7078));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("65b4d1a1-9221-433d-bff7-24295959bac0"), new Guid("2baff7a7-3bf5-4cf6-9597-22456a581a0b") },
                    { new Guid("737fac16-b522-4e00-afc4-5d0cf12804e2"), new Guid("495b2fcd-5083-4633-b12d-2ddddf460438") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DeleteData(
                table: "Artices",
                keyColumn: "Id",
                keyValue: new Guid("47f064f5-dcff-428e-a3b9-754899b9bbbc"));

            migrationBuilder.DeleteData(
                table: "Artices",
                keyColumn: "Id",
                keyValue: new Guid("6b90bce8-c990-4109-9fb8-3f90764a7e4c"));

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
    }
}
