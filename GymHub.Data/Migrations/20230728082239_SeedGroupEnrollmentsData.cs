using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GymHub.Data.Migrations
{
    public partial class SeedGroupEnrollmentsData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "GroupEnrollments",
                columns: new[] { "Id", "ScheduleId", "TraineeId" },
                values: new object[,]
                {
                    { new Guid("185f01bb-cb3d-4a44-a718-8da91b77a46a"), new Guid("da220d33-5a34-46a2-9e95-415aaafbe7cd"), new Guid("3ee69130-4ce4-450d-be65-0ab522760278") },
                    { new Guid("21fe6937-bd86-44af-8c25-3740756f3943"), new Guid("6104ae44-7737-4bfe-9146-969c78f8664b"), new Guid("f5c10860-7074-4121-ae6a-f8e6b832340b") },
                    { new Guid("5ec7ebbf-9791-4607-a03c-5a0278a4ba88"), new Guid("b3a5cc92-fd09-4fe0-89a9-f6bd98bf90e1"), new Guid("f5c10860-7074-4121-ae6a-f8e6b832340b") },
                    { new Guid("9a28747c-0dd9-4a0f-b489-78c2ae91d8fb"), new Guid("b3a5cc92-fd09-4fe0-89a9-f6bd98bf90e1"), new Guid("e89fc950-317b-454b-9c66-c082db3cbec2") },
                    { new Guid("b4c5dd72-11d1-4f18-96b3-c03597a0d132"), new Guid("8d827ef7-962b-4a01-a391-88663ecac213"), new Guid("efe69cd0-ff7a-4f5a-b038-18a62654c084") },
                    { new Guid("db91e9ab-e05b-4121-b1dd-137d8ac80db9"), new Guid("8d827ef7-962b-4a01-a391-88663ecac213"), new Guid("c4e34109-23ba-42a1-9a17-3797090de18c") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GroupEnrollments",
                keyColumn: "Id",
                keyValue: new Guid("185f01bb-cb3d-4a44-a718-8da91b77a46a"));

            migrationBuilder.DeleteData(
                table: "GroupEnrollments",
                keyColumn: "Id",
                keyValue: new Guid("21fe6937-bd86-44af-8c25-3740756f3943"));

            migrationBuilder.DeleteData(
                table: "GroupEnrollments",
                keyColumn: "Id",
                keyValue: new Guid("5ec7ebbf-9791-4607-a03c-5a0278a4ba88"));

            migrationBuilder.DeleteData(
                table: "GroupEnrollments",
                keyColumn: "Id",
                keyValue: new Guid("9a28747c-0dd9-4a0f-b489-78c2ae91d8fb"));

            migrationBuilder.DeleteData(
                table: "GroupEnrollments",
                keyColumn: "Id",
                keyValue: new Guid("b4c5dd72-11d1-4f18-96b3-c03597a0d132"));

            migrationBuilder.DeleteData(
                table: "GroupEnrollments",
                keyColumn: "Id",
                keyValue: new Guid("db91e9ab-e05b-4121-b1dd-137d8ac80db9"));
        }
    }
}
