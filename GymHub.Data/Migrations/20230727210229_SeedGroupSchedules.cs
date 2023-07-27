using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GymHub.Data.Migrations
{
    public partial class SeedGroupSchedules : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "GroupSchedules",
                columns: new[] { "Id", "ActivityId", "EndTime", "StartTime" },
                values: new object[,]
                {
                    { new Guid("539d5620-f636-439c-a7d5-94f3b3654f70"), new Guid("6ad5a4d2-11fa-4fee-89e6-a341a47bf527"), new DateTime(2023, 8, 21, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 21, 10, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5ea2a2d0-10f6-4fff-a4a5-28ce33c5a5ec"), new Guid("0bb32c51-d799-4004-915f-91ccea62ce11"), new DateTime(2023, 8, 8, 17, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 8, 16, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6104ae44-7737-4bfe-9146-969c78f8664b"), new Guid("6ad5a4d2-11fa-4fee-89e6-a341a47bf527"), new DateTime(2023, 8, 14, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 14, 10, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8d827ef7-962b-4a01-a391-88663ecac213"), new Guid("0bb32c51-d799-4004-915f-91ccea62ce11"), new DateTime(2023, 8, 11, 17, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 11, 16, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a9a81c48-7e25-469e-8f61-75b4669c1b4a"), new Guid("0bb32c51-d799-4004-915f-91ccea62ce11"), new DateTime(2023, 8, 22, 17, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 22, 16, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b3a5cc92-fd09-4fe0-89a9-f6bd98bf90e1"), new Guid("0bb32c51-d799-4004-915f-91ccea62ce11"), new DateTime(2023, 8, 25, 17, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 25, 16, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("da220d33-5a34-46a2-9e95-415aaafbe7cd"), new Guid("6ad5a4d2-11fa-4fee-89e6-a341a47bf527"), new DateTime(2023, 9, 28, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 28, 10, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f1f607d8-e1e2-4ca8-9bda-caa1cfd0c31f"), new Guid("6ad5a4d2-11fa-4fee-89e6-a341a47bf527"), new DateTime(2023, 8, 7, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 7, 10, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GroupSchedules",
                keyColumn: "Id",
                keyValue: new Guid("539d5620-f636-439c-a7d5-94f3b3654f70"));

            migrationBuilder.DeleteData(
                table: "GroupSchedules",
                keyColumn: "Id",
                keyValue: new Guid("5ea2a2d0-10f6-4fff-a4a5-28ce33c5a5ec"));

            migrationBuilder.DeleteData(
                table: "GroupSchedules",
                keyColumn: "Id",
                keyValue: new Guid("6104ae44-7737-4bfe-9146-969c78f8664b"));

            migrationBuilder.DeleteData(
                table: "GroupSchedules",
                keyColumn: "Id",
                keyValue: new Guid("8d827ef7-962b-4a01-a391-88663ecac213"));

            migrationBuilder.DeleteData(
                table: "GroupSchedules",
                keyColumn: "Id",
                keyValue: new Guid("a9a81c48-7e25-469e-8f61-75b4669c1b4a"));

            migrationBuilder.DeleteData(
                table: "GroupSchedules",
                keyColumn: "Id",
                keyValue: new Guid("b3a5cc92-fd09-4fe0-89a9-f6bd98bf90e1"));

            migrationBuilder.DeleteData(
                table: "GroupSchedules",
                keyColumn: "Id",
                keyValue: new Guid("da220d33-5a34-46a2-9e95-415aaafbe7cd"));

            migrationBuilder.DeleteData(
                table: "GroupSchedules",
                keyColumn: "Id",
                keyValue: new Guid("f1f607d8-e1e2-4ca8-9bda-caa1cfd0c31f"));
        }
    }
}
