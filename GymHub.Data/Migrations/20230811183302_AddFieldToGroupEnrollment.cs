using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GymHub.Data.Migrations
{
    public partial class AddFieldToGroupEnrollment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsCanceled",
                table: "GroupEnrollments",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ba3a5230-8e32-4d72-bc27-def1a8ab665a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "77159524-9474-4eda-b454-26ad1e5a17b4", "AQAAAAEAACcQAAAAEMOsWd5Ahmygu6KxHTQdkLGFUCCCJpEcDR5l51twmAHWd0FLcKT+jTpGtVu752xipg==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsCanceled",
                table: "GroupEnrollments");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ba3a5230-8e32-4d72-bc27-def1a8ab665a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "eb9d9bc3-c148-48d7-ac27-55581fe64051", "AQAAAAEAACcQAAAAEM4tN+IjR5mNYwai+t41OPQSNcK6AZUpwoVLxIXlyT+B6ZE1TyMuM9/KhkZ2o2u6YQ==" });
        }
    }
}
