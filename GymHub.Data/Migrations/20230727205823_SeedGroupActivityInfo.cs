using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GymHub.Data.Migrations
{
    public partial class SeedGroupActivityInfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ActivitiesCategories",
                columns: new[] { "Id", "Intensity", "TraineeLevel" },
                values: new object[,]
                {
                    { 1, "Low", "Beginner" },
                    { 2, "Moderate", "Beginner" },
                    { 3, "Moderate", "Intermediate" },
                    { 4, "Moderate", "Advanced" },
                    { 5, "High", "Intermediate" },
                    { 6, "High", "Advanced" }
                });

            migrationBuilder.InsertData(
                table: "GroupActivities",
                columns: new[] { "Id", "CategoryId", "CountOfMaxSpots", "Name" },
                values: new object[] { new Guid("0bb32c51-d799-4004-915f-91ccea62ce11"), 6, 20, "Cross Training" });

            migrationBuilder.InsertData(
                table: "GroupActivities",
                columns: new[] { "Id", "CategoryId", "CountOfMaxSpots", "Name" },
                values: new object[] { new Guid("6ad5a4d2-11fa-4fee-89e6-a341a47bf527"), 3, 20, "Kickboxing" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ActivitiesCategories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ActivitiesCategories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ActivitiesCategories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ActivitiesCategories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "GroupActivities",
                keyColumn: "Id",
                keyValue: new Guid("0bb32c51-d799-4004-915f-91ccea62ce11"));

            migrationBuilder.DeleteData(
                table: "GroupActivities",
                keyColumn: "Id",
                keyValue: new Guid("6ad5a4d2-11fa-4fee-89e6-a341a47bf527"));

            migrationBuilder.DeleteData(
                table: "ActivitiesCategories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ActivitiesCategories",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
