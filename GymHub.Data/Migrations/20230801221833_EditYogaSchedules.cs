using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GymHub.Data.Migrations
{
    public partial class EditYogaSchedules : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "GroupSchedules",
                keyColumn: "Id",
                keyValue: new Guid("296e3b96-8ad1-4ceb-847c-331444d36016"),
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 8, 22, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 22, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "GroupSchedules",
                keyColumn: "Id",
                keyValue: new Guid("a8ba6cc6-2e6d-4709-ab9b-bc4c4024e29b"),
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 8, 30, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 30, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "GroupSchedules",
                keyColumn: "Id",
                keyValue: new Guid("c4d374b1-c657-4f03-a46c-2c725f630375"),
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 8, 29, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 29, 14, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "GroupSchedules",
                keyColumn: "Id",
                keyValue: new Guid("296e3b96-8ad1-4ceb-847c-331444d36016"),
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 8, 28, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 28, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "GroupSchedules",
                keyColumn: "Id",
                keyValue: new Guid("a8ba6cc6-2e6d-4709-ab9b-bc4c4024e29b"),
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 8, 28, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 28, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "GroupSchedules",
                keyColumn: "Id",
                keyValue: new Guid("c4d374b1-c657-4f03-a46c-2c725f630375"),
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 8, 28, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 28, 10, 0, 0, 0, DateTimeKind.Unspecified) });
        }
    }
}
