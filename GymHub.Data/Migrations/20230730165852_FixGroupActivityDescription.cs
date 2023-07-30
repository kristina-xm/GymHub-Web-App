using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GymHub.Data.Migrations
{
    public partial class FixGroupActivityDescription : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "GroupActivities",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "GroupActivities",
                keyColumn: "Id",
                keyValue: new Guid("0bb32c51-d799-4004-915f-91ccea62ce11"),
                column: "Description",
                value: "Cross training is a diverse workout approach that involves mixing various exercises and activities to enhance overall fitness and prevent workout plateaus. By combining cardio, strength training, and flexibility exercises, it targets multiple muscle groups and reduces the risk of overuse injuries.");

            migrationBuilder.UpdateData(
                table: "GroupActivities",
                keyColumn: "Id",
                keyValue: new Guid("6ad5a4d2-11fa-4fee-89e6-a341a47bf527"),
                column: "Description",
                value: "Kickboxing is a high-intensity martial art and cardio workout that combines punching, kicking, and knee strikes. It improves overall fitness, endurance, and self-defense skills while providing a fun and challenging way to burn calories and relieve stress.");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "GroupActivities");
        }
    }
}
