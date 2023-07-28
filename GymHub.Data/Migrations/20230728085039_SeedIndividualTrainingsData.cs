using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GymHub.Data.Migrations
{
    public partial class SeedIndividualTrainingsData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "GroupSchedules",
                keyColumn: "Id",
                keyValue: new Guid("da220d33-5a34-46a2-9e95-415aaafbe7cd"),
                column: "EndTime",
                value: new DateTime(2023, 8, 28, 12, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "IndividualTrainings",
                columns: new[] { "Id", "EndTime", "Intensity", "IsCanceled", "StartTime" },
                values: new object[,]
                {
                    { new Guid("3e154226-2820-4837-81c8-247e4604cdd6"), new DateTime(2023, 8, 22, 15, 0, 0, 0, DateTimeKind.Unspecified), "High", false, new DateTime(2023, 8, 22, 14, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("492b5886-64cf-4f0e-9fdb-2baed606e361"), new DateTime(2023, 8, 18, 19, 30, 0, 0, DateTimeKind.Unspecified), "Moderate", false, new DateTime(2023, 8, 18, 18, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("63d1f1d6-9348-4710-8082-20a1fbf189e2"), new DateTime(2023, 8, 23, 13, 0, 0, 0, DateTimeKind.Unspecified), "Low", false, new DateTime(2023, 8, 23, 10, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("66afc146-91e8-461f-a9c2-8b61419f6af3"), new DateTime(2023, 8, 15, 11, 0, 0, 0, DateTimeKind.Unspecified), "High", false, new DateTime(2023, 8, 15, 10, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a2b6df44-832f-4ae2-ae77-4f8bc89a66af"), new DateTime(2023, 8, 17, 13, 0, 0, 0, DateTimeKind.Unspecified), "Moderate", false, new DateTime(2023, 8, 17, 12, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Enrollments",
                columns: new[] { "Id", "TraineeId", "TrainingId" },
                values: new object[,]
                {
                    { new Guid("4ce3627a-7ed9-460f-8954-e84bdf978a18"), new Guid("efe69cd0-ff7a-4f5a-b038-18a62654c084"), new Guid("3e154226-2820-4837-81c8-247e4604cdd6") },
                    { new Guid("a95ee763-73af-4f1e-9942-30004ccdb826"), new Guid("e89fc950-317b-454b-9c66-c082db3cbec2"), new Guid("66afc146-91e8-461f-a9c2-8b61419f6af3") },
                    { new Guid("b903e948-dbb2-4177-b9f1-5d2feb46f1a6"), new Guid("f5c10860-7074-4121-ae6a-f8e6b832340b"), new Guid("a2b6df44-832f-4ae2-ae77-4f8bc89a66af") },
                    { new Guid("e88db467-0004-4e11-9d80-648316f73a31"), new Guid("3ee69130-4ce4-450d-be65-0ab522760278"), new Guid("492b5886-64cf-4f0e-9fdb-2baed606e361") },
                    { new Guid("fd2fa2eb-2bce-482e-9f28-08a2a705b6c9"), new Guid("efe69cd0-ff7a-4f5a-b038-18a62654c084"), new Guid("63d1f1d6-9348-4710-8082-20a1fbf189e2") }
                });

            migrationBuilder.InsertData(
                table: "IndividualTrainingsTrainers",
                columns: new[] { "TrainerId", "TrainingId" },
                values: new object[,]
                {
                    { new Guid("0d61d878-2b3d-49bd-b4fb-ac482a7d9bda"), new Guid("492b5886-64cf-4f0e-9fdb-2baed606e361") },
                    { new Guid("0d61d878-2b3d-49bd-b4fb-ac482a7d9bda"), new Guid("a2b6df44-832f-4ae2-ae77-4f8bc89a66af") },
                    { new Guid("ad716331-39a9-4ef2-88f2-0e69f7654ec1"), new Guid("3e154226-2820-4837-81c8-247e4604cdd6") },
                    { new Guid("ad716331-39a9-4ef2-88f2-0e69f7654ec1"), new Guid("63d1f1d6-9348-4710-8082-20a1fbf189e2") },
                    { new Guid("e4c6589b-afa8-49c0-8d78-119d3ee95269"), new Guid("66afc146-91e8-461f-a9c2-8b61419f6af3") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DeleteData(
                table: "IndividualTrainingsTrainers",
                keyColumns: new[] { "TrainerId", "TrainingId" },
                keyValues: new object[] { new Guid("0d61d878-2b3d-49bd-b4fb-ac482a7d9bda"), new Guid("492b5886-64cf-4f0e-9fdb-2baed606e361") });

            migrationBuilder.DeleteData(
                table: "IndividualTrainingsTrainers",
                keyColumns: new[] { "TrainerId", "TrainingId" },
                keyValues: new object[] { new Guid("0d61d878-2b3d-49bd-b4fb-ac482a7d9bda"), new Guid("a2b6df44-832f-4ae2-ae77-4f8bc89a66af") });

            migrationBuilder.DeleteData(
                table: "IndividualTrainingsTrainers",
                keyColumns: new[] { "TrainerId", "TrainingId" },
                keyValues: new object[] { new Guid("ad716331-39a9-4ef2-88f2-0e69f7654ec1"), new Guid("3e154226-2820-4837-81c8-247e4604cdd6") });

            migrationBuilder.DeleteData(
                table: "IndividualTrainingsTrainers",
                keyColumns: new[] { "TrainerId", "TrainingId" },
                keyValues: new object[] { new Guid("ad716331-39a9-4ef2-88f2-0e69f7654ec1"), new Guid("63d1f1d6-9348-4710-8082-20a1fbf189e2") });

            migrationBuilder.DeleteData(
                table: "IndividualTrainingsTrainers",
                keyColumns: new[] { "TrainerId", "TrainingId" },
                keyValues: new object[] { new Guid("e4c6589b-afa8-49c0-8d78-119d3ee95269"), new Guid("66afc146-91e8-461f-a9c2-8b61419f6af3") });

            migrationBuilder.DeleteData(
                table: "IndividualTrainings",
                keyColumn: "Id",
                keyValue: new Guid("3e154226-2820-4837-81c8-247e4604cdd6"));

            migrationBuilder.DeleteData(
                table: "IndividualTrainings",
                keyColumn: "Id",
                keyValue: new Guid("492b5886-64cf-4f0e-9fdb-2baed606e361"));

            migrationBuilder.DeleteData(
                table: "IndividualTrainings",
                keyColumn: "Id",
                keyValue: new Guid("63d1f1d6-9348-4710-8082-20a1fbf189e2"));

            migrationBuilder.DeleteData(
                table: "IndividualTrainings",
                keyColumn: "Id",
                keyValue: new Guid("66afc146-91e8-461f-a9c2-8b61419f6af3"));

            migrationBuilder.DeleteData(
                table: "IndividualTrainings",
                keyColumn: "Id",
                keyValue: new Guid("a2b6df44-832f-4ae2-ae77-4f8bc89a66af"));

            migrationBuilder.UpdateData(
                table: "GroupSchedules",
                keyColumn: "Id",
                keyValue: new Guid("da220d33-5a34-46a2-9e95-415aaafbe7cd"),
                column: "EndTime",
                value: new DateTime(2023, 9, 28, 12, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
