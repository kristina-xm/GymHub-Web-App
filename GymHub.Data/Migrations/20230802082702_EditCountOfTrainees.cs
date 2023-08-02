using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GymHub.Data.Migrations
{
    public partial class EditCountOfTrainees : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "GroupSchedules",
                keyColumn: "Id",
                keyValue: new Guid("1452eef9-d47f-48ce-bea6-8bc0ec775f5e"),
                column: "CountOfTrainees",
                value: 2);

            migrationBuilder.UpdateData(
                table: "GroupSchedules",
                keyColumn: "Id",
                keyValue: new Guid("47d1b94a-1e4b-4ae4-986d-60298849b1c7"),
                column: "CountOfTrainees",
                value: 1);

            migrationBuilder.UpdateData(
                table: "GroupSchedules",
                keyColumn: "Id",
                keyValue: new Guid("6d88f805-232d-4ce4-a05f-a62da3a02474"),
                column: "CountOfTrainees",
                value: 1);

            migrationBuilder.UpdateData(
                table: "GroupSchedules",
                keyColumn: "Id",
                keyValue: new Guid("abd78db4-0a0d-466c-a14d-4f1c6da8bfb0"),
                column: "CountOfTrainees",
                value: 1);

            migrationBuilder.UpdateData(
                table: "GroupSchedules",
                keyColumn: "Id",
                keyValue: new Guid("c4d374b1-c657-4f03-a46c-2c725f630375"),
                column: "CountOfTrainees",
                value: 2);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "GroupSchedules",
                keyColumn: "Id",
                keyValue: new Guid("1452eef9-d47f-48ce-bea6-8bc0ec775f5e"),
                column: "CountOfTrainees",
                value: 0);

            migrationBuilder.UpdateData(
                table: "GroupSchedules",
                keyColumn: "Id",
                keyValue: new Guid("47d1b94a-1e4b-4ae4-986d-60298849b1c7"),
                column: "CountOfTrainees",
                value: 0);

            migrationBuilder.UpdateData(
                table: "GroupSchedules",
                keyColumn: "Id",
                keyValue: new Guid("6d88f805-232d-4ce4-a05f-a62da3a02474"),
                column: "CountOfTrainees",
                value: 0);

            migrationBuilder.UpdateData(
                table: "GroupSchedules",
                keyColumn: "Id",
                keyValue: new Guid("abd78db4-0a0d-466c-a14d-4f1c6da8bfb0"),
                column: "CountOfTrainees",
                value: 0);

            migrationBuilder.UpdateData(
                table: "GroupSchedules",
                keyColumn: "Id",
                keyValue: new Guid("c4d374b1-c657-4f03-a46c-2c725f630375"),
                column: "CountOfTrainees",
                value: 0);
        }
    }
}
