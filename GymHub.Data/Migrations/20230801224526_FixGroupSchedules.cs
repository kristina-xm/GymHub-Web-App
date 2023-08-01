using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GymHub.Data.Migrations
{
    public partial class FixGroupSchedules : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "GroupSchedules",
                columns: new[] { "Id", "ActivityId", "CountOfTrainees", "EndTime", "StartTime" },
                values: new object[,]
                {
                    { new Guid("3526d1c6-f63a-42c6-ae60-1dd97e3434a0"), new Guid("25b00a8d-13b9-4c33-a145-96b89264d699"), 0, new DateTime(2023, 8, 25, 17, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 25, 16, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("44312107-bbbd-422b-b54b-25a0db36f3b5"), new Guid("25b00a8d-13b9-4c33-a145-96b89264d699"), 0, new DateTime(2023, 8, 11, 17, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 11, 16, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("47d1b94a-1e4b-4ae4-986d-60298849b1c7"), new Guid("25b00a8d-13b9-4c33-a145-96b89264d699"), 0, new DateTime(2023, 8, 8, 17, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 8, 16, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6d88f805-232d-4ce4-a05f-a62da3a02474"), new Guid("6d6ee926-6fa3-43a7-8bac-dc86632094a5"), 0, new DateTime(2023, 8, 7, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 7, 10, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7c8030e8-e724-4470-adbf-e343a80566a2"), new Guid("6d6ee926-6fa3-43a7-8bac-dc86632094a5"), 0, new DateTime(2023, 8, 28, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 28, 10, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("abd78db4-0a0d-466c-a14d-4f1c6da8bfb0"), new Guid("6d6ee926-6fa3-43a7-8bac-dc86632094a5"), 0, new DateTime(2023, 8, 10, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 10, 10, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ae048160-36c5-4dbb-ba0d-83854fa3f338"), new Guid("25b00a8d-13b9-4c33-a145-96b89264d699"), 0, new DateTime(2023, 8, 22, 17, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 22, 16, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e499d6b0-a852-4b37-9334-fc5f8c4aa69c"), new Guid("6d6ee926-6fa3-43a7-8bac-dc86632094a5"), 0, new DateTime(2023, 8, 21, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 21, 10, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GroupSchedules",
                keyColumn: "Id",
                keyValue: new Guid("3526d1c6-f63a-42c6-ae60-1dd97e3434a0"));

            migrationBuilder.DeleteData(
                table: "GroupSchedules",
                keyColumn: "Id",
                keyValue: new Guid("44312107-bbbd-422b-b54b-25a0db36f3b5"));

            migrationBuilder.DeleteData(
                table: "GroupSchedules",
                keyColumn: "Id",
                keyValue: new Guid("47d1b94a-1e4b-4ae4-986d-60298849b1c7"));

            migrationBuilder.DeleteData(
                table: "GroupSchedules",
                keyColumn: "Id",
                keyValue: new Guid("6d88f805-232d-4ce4-a05f-a62da3a02474"));

            migrationBuilder.DeleteData(
                table: "GroupSchedules",
                keyColumn: "Id",
                keyValue: new Guid("7c8030e8-e724-4470-adbf-e343a80566a2"));

            migrationBuilder.DeleteData(
                table: "GroupSchedules",
                keyColumn: "Id",
                keyValue: new Guid("abd78db4-0a0d-466c-a14d-4f1c6da8bfb0"));

            migrationBuilder.DeleteData(
                table: "GroupSchedules",
                keyColumn: "Id",
                keyValue: new Guid("ae048160-36c5-4dbb-ba0d-83854fa3f338"));

            migrationBuilder.DeleteData(
                table: "GroupSchedules",
                keyColumn: "Id",
                keyValue: new Guid("e499d6b0-a852-4b37-9334-fc5f8c4aa69c"));

            migrationBuilder.InsertData(
                table: "GroupSchedules",
                columns: new[] { "Id", "ActivityId", "CountOfTrainees", "EndTime", "StartTime" },
                values: new object[,]
                {
                    { new Guid("539d5620-f636-439c-a7d5-94f3b3654f70"), new Guid("6d6ee926-6fa3-43a7-8bac-dc86632094a5"), 0, new DateTime(2023, 8, 21, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 21, 10, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5ea2a2d0-10f6-4fff-a4a5-28ce33c5a5ec"), new Guid("25b00a8d-13b9-4c33-a145-96b89264d699"), 0, new DateTime(2023, 8, 8, 17, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 8, 16, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6104ae44-7737-4bfe-9146-969c78f8664b"), new Guid("6d6ee926-6fa3-43a7-8bac-dc86632094a5"), 0, new DateTime(2023, 8, 10, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 10, 10, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8d827ef7-962b-4a01-a391-88663ecac213"), new Guid("25b00a8d-13b9-4c33-a145-96b89264d699"), 0, new DateTime(2023, 8, 11, 17, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 11, 16, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a9a81c48-7e25-469e-8f61-75b4669c1b4a"), new Guid("25b00a8d-13b9-4c33-a145-96b89264d699"), 0, new DateTime(2023, 8, 22, 17, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 22, 16, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b3a5cc92-fd09-4fe0-89a9-f6bd98bf90e1"), new Guid("25b00a8d-13b9-4c33-a145-96b89264d699"), 0, new DateTime(2023, 8, 25, 17, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 25, 16, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("da220d33-5a34-46a2-9e95-415aaafbe7cd"), new Guid("6d6ee926-6fa3-43a7-8bac-dc86632094a5"), 0, new DateTime(2023, 8, 28, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 28, 10, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f1f607d8-e1e2-4ca8-9bda-caa1cfd0c31f"), new Guid("6d6ee926-6fa3-43a7-8bac-dc86632094a5"), 0, new DateTime(2023, 8, 7, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 7, 10, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }
    }
}
