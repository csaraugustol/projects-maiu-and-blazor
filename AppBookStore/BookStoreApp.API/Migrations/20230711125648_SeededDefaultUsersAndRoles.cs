using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookStoreApp.API.Migrations
{
    /// <inheritdoc />
    public partial class SeededDefaultUsersAndRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1fd15ca2-04ba-4700-b908-2dbfc8154d9c", "e7184443-c93e-4669-bf13-6945368453ca", "Administrator", "ADMINISTRATOR" },
                    { "fbb3e82c-e883-4144-a693-7946907dbb5e", "3efc1c75-4e12-44a0-bbb5-c0f9e80387da", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "7ca26e4c-bc26-46f7-84df-6df9037e844c", 0, "1958f902-6831-4c85-8211-630807c2815d", "admin@bookstore.com", false, "System", "Admin", false, null, "ADMIN@BOOKSTORE.COM", "ADMIN@BOOKSTORE.COM", "AQAAAAEAACcQAAAAEDNQ5B1OlDhHxrGUWNzSg/XW2GJSlU4EfIqUoftndMhpfawbEA0Xzf1bEJPG1yQIEw==", null, false, "47a2824e-9b6e-4c67-b445-71ba770d342c", false, "admin@bookstore.com" },
                    { "e0759aad-a6cd-432a-96eb-e3066a2f271a", 0, "851e8ef5-9c6f-472d-8b0e-e607f34b1114", "user@bookstore.com", false, "System", "User", false, null, "USER@BOOKSTORE.COM", "USER@BOOKSTORE.COM", "AQAAAAEAACcQAAAAEOkEs0+dcLakdKKbaCY9/eInL2y9fQKk4e1oUCSB5CgZCDhzlKVIS5nSrTF4CEr8zg==", null, false, "1b0dabf8-3d4f-43d8-a62b-c14948272d13", false, "user@bookstore.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "1fd15ca2-04ba-4700-b908-2dbfc8154d9c", "7ca26e4c-bc26-46f7-84df-6df9037e844c" },
                    { "fbb3e82c-e883-4144-a693-7946907dbb5e", "e0759aad-a6cd-432a-96eb-e3066a2f271a" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1fd15ca2-04ba-4700-b908-2dbfc8154d9c", "7ca26e4c-bc26-46f7-84df-6df9037e844c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "fbb3e82c-e883-4144-a693-7946907dbb5e", "e0759aad-a6cd-432a-96eb-e3066a2f271a" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1fd15ca2-04ba-4700-b908-2dbfc8154d9c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fbb3e82c-e883-4144-a693-7946907dbb5e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7ca26e4c-bc26-46f7-84df-6df9037e844c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e0759aad-a6cd-432a-96eb-e3066a2f271a");
        }
    }
}
