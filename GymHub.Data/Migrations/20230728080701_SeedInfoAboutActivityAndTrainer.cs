using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GymHub.Data.Migrations
{
    public partial class SeedInfoAboutActivityAndTrainer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "GroupActivityTrainers",
                columns: new[] { "ActivityId", "TrainerId" },
                values: new object[] { new Guid("6ad5a4d2-11fa-4fee-89e6-a341a47bf527"), new Guid("5b86293b-856f-47b8-8b93-63a3c7a965e1") });

            migrationBuilder.InsertData(
                table: "GroupActivityTrainers",
                columns: new[] { "ActivityId", "TrainerId" },
                values: new object[] { new Guid("0bb32c51-d799-4004-915f-91ccea62ce11"), new Guid("ad716331-39a9-4ef2-88f2-0e69f7654ec1") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GroupActivityTrainers",
                keyColumns: new[] { "ActivityId", "TrainerId" },
                keyValues: new object[] { new Guid("6ad5a4d2-11fa-4fee-89e6-a341a47bf527"), new Guid("5b86293b-856f-47b8-8b93-63a3c7a965e1") });

            migrationBuilder.DeleteData(
                table: "GroupActivityTrainers",
                keyColumns: new[] { "ActivityId", "TrainerId" },
                keyValues: new object[] { new Guid("0bb32c51-d799-4004-915f-91ccea62ce11"), new Guid("ad716331-39a9-4ef2-88f2-0e69f7654ec1") });
        }
    }
}
