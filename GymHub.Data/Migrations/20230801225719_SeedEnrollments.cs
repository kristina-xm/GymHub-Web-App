using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GymHub.Data.Migrations
{
    public partial class SeedEnrollments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("4ce3627a-7ed9-460f-8954-e84bdf978a18"));

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("a95ee763-73af-4f1e-9942-30004ccdb826"));

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("b903e948-dbb2-4177-b9f1-5d2feb46f1a6"));

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("e88db467-0004-4e11-9d80-648316f73a31"));

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("fd2fa2eb-2bce-482e-9f28-08a2a705b6c9"));

            migrationBuilder.InsertData(
                table: "Enrollments",
                columns: new[] { "Id", "TraineeId", "TrainingId" },
                values: new object[,]
                {
                    { new Guid("8e03520b-84bd-4aec-a19e-b6a461a18609"), new Guid("5546a97c-3ed4-48b7-90c7-2c0d70159e28"), new Guid("88034cb7-c971-4520-a3a1-d48099502562") },
                    { new Guid("91898c44-8c40-4c2f-8b4b-d2992a4166c3"), new Guid("02f24448-29e7-48d1-ae7e-54282df6cc53"), new Guid("17e17c3c-ba43-44bb-9fe3-8ec50c4a8dca") },
                    { new Guid("96faeece-d48a-4039-ba74-48aef7c37505"), new Guid("7cb387f1-d0c1-4be2-9cc8-31cba24fdd7c"), new Guid("922bf694-a4e1-4fbe-b508-8cbfa836600f") },
                    { new Guid("da72aef2-fed5-47c6-b6b4-f0433b2347fc"), new Guid("b6830fbd-a3e8-4465-a596-04565c4568bc"), new Guid("82a1b1c7-1b12-4973-a8c0-9720fe4255fc") },
                    { new Guid("f2a2d524-be88-4c27-9a99-b17a33619a64"), new Guid("b6830fbd-a3e8-4465-a596-04565c4568bc"), new Guid("5bd931f9-f5ca-472c-8c81-9f011118c0e5") }
                });

            migrationBuilder.UpdateData(
                table: "GroupEnrollments",
                keyColumn: "Id",
                keyValue: new Guid("185f01bb-cb3d-4a44-a718-8da91b77a46a"),
                column: "ScheduleId",
                value: new Guid("47d1b94a-1e4b-4ae4-986d-60298849b1c7"));

            migrationBuilder.UpdateData(
                table: "GroupEnrollments",
                keyColumn: "Id",
                keyValue: new Guid("21fe6937-bd86-44af-8c25-3740756f3943"),
                column: "ScheduleId",
                value: new Guid("1452eef9-d47f-48ce-bea6-8bc0ec775f5e"));

            migrationBuilder.UpdateData(
                table: "GroupEnrollments",
                keyColumn: "Id",
                keyValue: new Guid("5ec7ebbf-9791-4607-a03c-5a0278a4ba88"),
                column: "ScheduleId",
                value: new Guid("c4d374b1-c657-4f03-a46c-2c725f630375"));

            migrationBuilder.UpdateData(
                table: "GroupEnrollments",
                keyColumn: "Id",
                keyValue: new Guid("b4c5dd72-11d1-4f18-96b3-c03597a0d132"),
                column: "ScheduleId",
                value: new Guid("6d88f805-232d-4ce4-a05f-a62da3a02474"));

            migrationBuilder.UpdateData(
                table: "GroupEnrollments",
                keyColumn: "Id",
                keyValue: new Guid("db91e9ab-e05b-4121-b1dd-137d8ac80db9"),
                column: "ScheduleId",
                value: new Guid("abd78db4-0a0d-466c-a14d-4f1c6da8bfb0"));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("8e03520b-84bd-4aec-a19e-b6a461a18609"));

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("91898c44-8c40-4c2f-8b4b-d2992a4166c3"));

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("96faeece-d48a-4039-ba74-48aef7c37505"));

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("da72aef2-fed5-47c6-b6b4-f0433b2347fc"));

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("f2a2d524-be88-4c27-9a99-b17a33619a64"));

            migrationBuilder.InsertData(
                table: "Enrollments",
                columns: new[] { "Id", "TraineeId", "TrainingId" },
                values: new object[,]
                {
                    { new Guid("4ce3627a-7ed9-460f-8954-e84bdf978a18"), new Guid("b6830fbd-a3e8-4465-a596-04565c4568bc"), new Guid("82a1b1c7-1b12-4973-a8c0-9720fe4255fc") },
                    { new Guid("a95ee763-73af-4f1e-9942-30004ccdb826"), new Guid("b6830fbd-a3e8-4465-a596-04565c4568bc"), new Guid("5bd931f9-f5ca-472c-8c81-9f011118c0e5") },
                    { new Guid("b903e948-dbb2-4177-b9f1-5d2feb46f1a6"), new Guid("02f24448-29e7-48d1-ae7e-54282df6cc53"), new Guid("17e17c3c-ba43-44bb-9fe3-8ec50c4a8dca") },
                    { new Guid("e88db467-0004-4e11-9d80-648316f73a31"), new Guid("5546a97c-3ed4-48b7-90c7-2c0d70159e28"), new Guid("88034cb7-c971-4520-a3a1-d48099502562") },
                    { new Guid("fd2fa2eb-2bce-482e-9f28-08a2a705b6c9"), new Guid("7cb387f1-d0c1-4be2-9cc8-31cba24fdd7c"), new Guid("922bf694-a4e1-4fbe-b508-8cbfa836600f") }
                });

            migrationBuilder.UpdateData(
                table: "GroupEnrollments",
                keyColumn: "Id",
                keyValue: new Guid("185f01bb-cb3d-4a44-a718-8da91b77a46a"),
                column: "ScheduleId",
                value: new Guid("da220d33-5a34-46a2-9e95-415aaafbe7cd"));

            migrationBuilder.UpdateData(
                table: "GroupEnrollments",
                keyColumn: "Id",
                keyValue: new Guid("21fe6937-bd86-44af-8c25-3740756f3943"),
                column: "ScheduleId",
                value: new Guid("6104ae44-7737-4bfe-9146-969c78f8664b"));

            migrationBuilder.UpdateData(
                table: "GroupEnrollments",
                keyColumn: "Id",
                keyValue: new Guid("5ec7ebbf-9791-4607-a03c-5a0278a4ba88"),
                column: "ScheduleId",
                value: new Guid("296e3b96-8ad1-4ceb-847c-331444d36016"));

            migrationBuilder.UpdateData(
                table: "GroupEnrollments",
                keyColumn: "Id",
                keyValue: new Guid("b4c5dd72-11d1-4f18-96b3-c03597a0d132"),
                column: "ScheduleId",
                value: new Guid("8d827ef7-962b-4a01-a391-88663ecac213"));

            migrationBuilder.UpdateData(
                table: "GroupEnrollments",
                keyColumn: "Id",
                keyValue: new Guid("db91e9ab-e05b-4121-b1dd-137d8ac80db9"),
                column: "ScheduleId",
                value: new Guid("8d827ef7-962b-4a01-a391-88663ecac213"));
        }
    }
}
