using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GymHub.Data.Migrations
{
    public partial class UpdateAdminSeedInfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ba3a5230-8e32-4d72-bc27-def1a8ab665a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4e32f838-9722-4a95-91b9-f4d2882609e6", "AQAAAAEAACcQAAAAEBxuatXta1Y6/rcl4rvkbqNiP/sWIMxoMf9OgF0Yosvw2xsbfxfbF8poImiRS2nbUA==", "2a1a3367-022d-4969-a374-63b39b19ad3f" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ba3a5230-8e32-4d72-bc27-def1a8ab665a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c907aada-10eb-4ea1-ae9a-647831e0134a", "AQAAAAEAACcQAAAAEA1nkgDRZfS9WNnR9U/s+IK1x3hH4oBryG35noAeWe7liWsN+fdAtqqpRRx2m3bzng==", null });
        }
    }
}
