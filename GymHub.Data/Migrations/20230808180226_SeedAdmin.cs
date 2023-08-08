using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GymHub.Data.Migrations
{
    public partial class SeedAdmin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("ba3a5230-8e32-4d72-bc27-def1a8ab665a"), 0, "c907aada-10eb-4ea1-ae9a-647831e0134a", "admin@gmail.com", false, "Martin", "Stoyanov", false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEA1nkgDRZfS9WNnR9U/s+IK1x3hH4oBryG35noAeWe7liWsN+fdAtqqpRRx2m3bzng==", "359892334456", false, null, false, "admin@gmail.com" });

            migrationBuilder.InsertData(
                table: "Trainers",
                columns: new[] { "Id", "Bio", "CountOfTrainees", "Experience", "UserId" },
                values: new object[] { new Guid("3fcaa2a4-59e1-4af4-9146-6f30716f836c"), "General trainer in this gym", 0, 8, new Guid("ba3a5230-8e32-4d72-bc27-def1a8ab665a") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("3fcaa2a4-59e1-4af4-9146-6f30716f836c"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ba3a5230-8e32-4d72-bc27-def1a8ab665a"));
        }
    }
}
