using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GymHub.Data.Migrations
{
    public partial class SeedGroupEnrollments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "GroupEnrollments",
                columns: new[] { "Id", "ScheduleId", "TraineeId" },
                values: new object[,]
                {
                    { new Guid("139c5fce-bf05-47e3-8fd3-9bb4f338aeb6"), new Guid("1452eef9-d47f-48ce-bea6-8bc0ec775f5e"), new Guid("5546a97c-3ed4-48b7-90c7-2c0d70159e28") },
                    { new Guid("1cc5bc09-2e19-49d0-b8cb-066f8b451328"), new Guid("6d88f805-232d-4ce4-a05f-a62da3a02474"), new Guid("b6830fbd-a3e8-4465-a596-04565c4568bc") },
                    { new Guid("3bb3b4d4-3e88-4ddc-b972-9a02c005f637"), new Guid("1452eef9-d47f-48ce-bea6-8bc0ec775f5e"), new Guid("44ea1e99-19e1-4d88-80f7-3d13cad88c5c") },
                    { new Guid("576dea69-a564-4f60-99b4-b2643eeff00c"), new Guid("c4d374b1-c657-4f03-a46c-2c725f630375"), new Guid("10d01292-4c4a-46b3-a1d7-e87212c0a87b") },
                    { new Guid("68cbab08-c836-4166-85cb-81caff531bc5"), new Guid("47d1b94a-1e4b-4ae4-986d-60298849b1c7"), new Guid("7cb387f1-d0c1-4be2-9cc8-31cba24fdd7c") },
                    { new Guid("9b9ea386-97d6-4ef1-b1f9-01d525ad9b74"), new Guid("abd78db4-0a0d-466c-a14d-4f1c6da8bfb0"), new Guid("02f24448-29e7-48d1-ae7e-54282df6cc53") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GroupEnrollments",
                keyColumn: "Id",
                keyValue: new Guid("139c5fce-bf05-47e3-8fd3-9bb4f338aeb6"));

            migrationBuilder.DeleteData(
                table: "GroupEnrollments",
                keyColumn: "Id",
                keyValue: new Guid("1cc5bc09-2e19-49d0-b8cb-066f8b451328"));

            migrationBuilder.DeleteData(
                table: "GroupEnrollments",
                keyColumn: "Id",
                keyValue: new Guid("3bb3b4d4-3e88-4ddc-b972-9a02c005f637"));

            migrationBuilder.DeleteData(
                table: "GroupEnrollments",
                keyColumn: "Id",
                keyValue: new Guid("576dea69-a564-4f60-99b4-b2643eeff00c"));

            migrationBuilder.DeleteData(
                table: "GroupEnrollments",
                keyColumn: "Id",
                keyValue: new Guid("68cbab08-c836-4166-85cb-81caff531bc5"));

            migrationBuilder.DeleteData(
                table: "GroupEnrollments",
                keyColumn: "Id",
                keyValue: new Guid("9b9ea386-97d6-4ef1-b1f9-01d525ad9b74"));

            migrationBuilder.InsertData(
                table: "GroupEnrollments",
                columns: new[] { "Id", "ScheduleId", "TraineeId" },
                values: new object[,]
                {
                    { new Guid("185f01bb-cb3d-4a44-a718-8da91b77a46a"), new Guid("47d1b94a-1e4b-4ae4-986d-60298849b1c7"), new Guid("7cb387f1-d0c1-4be2-9cc8-31cba24fdd7c") },
                    { new Guid("21fe6937-bd86-44af-8c25-3740756f3943"), new Guid("1452eef9-d47f-48ce-bea6-8bc0ec775f5e"), new Guid("5546a97c-3ed4-48b7-90c7-2c0d70159e28") },
                    { new Guid("5ec7ebbf-9791-4607-a03c-5a0278a4ba88"), new Guid("c4d374b1-c657-4f03-a46c-2c725f630375"), new Guid("10d01292-4c4a-46b3-a1d7-e87212c0a87b") },
                    { new Guid("9a28747c-0dd9-4a0f-b489-78c2ae91d8fb"), new Guid("1452eef9-d47f-48ce-bea6-8bc0ec775f5e"), new Guid("44ea1e99-19e1-4d88-80f7-3d13cad88c5c") },
                    { new Guid("b4c5dd72-11d1-4f18-96b3-c03597a0d132"), new Guid("6d88f805-232d-4ce4-a05f-a62da3a02474"), new Guid("b6830fbd-a3e8-4465-a596-04565c4568bc") },
                    { new Guid("db91e9ab-e05b-4121-b1dd-137d8ac80db9"), new Guid("abd78db4-0a0d-466c-a14d-4f1c6da8bfb0"), new Guid("02f24448-29e7-48d1-ae7e-54282df6cc53") }
                });
        }
    }
}
