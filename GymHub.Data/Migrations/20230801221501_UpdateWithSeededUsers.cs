using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GymHub.Data.Migrations
{
    public partial class UpdateWithSeededUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GroupActivityTrainers",
                keyColumns: new[] { "ActivityId", "TrainerId" },
                keyValues: new object[] { new Guid("6ad5a4d2-11fa-4fee-89e6-a341a47bf527"), new Guid("5b86293b-856f-47b8-8b93-63a3c7a965e1") });

            migrationBuilder.DeleteData(
                table: "GroupActivityTrainers",
                keyColumns: new[] { "ActivityId", "TrainerId" },
                keyValues: new object[] { new Guid("0bb32c51-d799-4004-915f-91ccea62ce11"), new Guid("ad716331-39a9-4ef2-88f2-0e69f7654ec1") });

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
                table: "GroupActivities",
                keyColumn: "Id",
                keyValue: new Guid("0bb32c51-d799-4004-915f-91ccea62ce11"));

            migrationBuilder.DeleteData(
                table: "GroupActivities",
                keyColumn: "Id",
                keyValue: new Guid("6ad5a4d2-11fa-4fee-89e6-a341a47bf527"));

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

            migrationBuilder.InsertData(
                table: "GroupActivities",
                columns: new[] { "Id", "CategoryId", "CountOfMaxSpots", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("25b00a8d-13b9-4c33-a145-96b89264d699"), 6, 15, "Cross training is a diverse workout approach that involves mixing various exercises and activities to enhance overall fitness and prevent workout plateaus. By combining cardio, strength training, and flexibility exercises, it targets multiple muscle groups and reduces the risk of overuse injuries.", "Cross Training" },
                    { new Guid("436818ef-d86c-4e43-88ca-29ff34ad5850"), 1, 25, "Yoga is a holistic practice that unites mind, body, and spirit. It incorporates physical postures, breathing techniques, and meditation to promote flexibility, strength, and inner peace. Embracing yoga can reduce stress and foster overall well-being. Connect with yourself and experience the transformative power of yoga.", "Yoga" },
                    { new Guid("6d6ee926-6fa3-43a7-8bac-dc86632094a5"), 3, 10, "Kickboxing is a high-intensity martial art and cardio workout that combines punching, kicking, and knee strikes. It improves overall fitness, endurance, and self-defense skills while providing a fun and challenging way to burn calories and relieve stress.", "Kickboxing" }
                });

            migrationBuilder.InsertData(
                table: "IndividualTrainings",
                columns: new[] { "Id", "EndTime", "Intensity", "IsCanceled", "StartTime" },
                values: new object[,]
                {
                    { new Guid("17e17c3c-ba43-44bb-9fe3-8ec50c4a8dca"), new DateTime(2023, 8, 22, 15, 0, 0, 0, DateTimeKind.Unspecified), "High", false, new DateTime(2023, 8, 22, 14, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5bd931f9-f5ca-472c-8c81-9f011118c0e5"), new DateTime(2023, 8, 15, 11, 0, 0, 0, DateTimeKind.Unspecified), "High", false, new DateTime(2023, 8, 15, 10, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("82a1b1c7-1b12-4973-a8c0-9720fe4255fc"), new DateTime(2023, 8, 17, 13, 0, 0, 0, DateTimeKind.Unspecified), "Moderate", false, new DateTime(2023, 8, 17, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("88034cb7-c971-4520-a3a1-d48099502562"), new DateTime(2023, 8, 23, 13, 0, 0, 0, DateTimeKind.Unspecified), "Low", false, new DateTime(2023, 8, 23, 10, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("922bf694-a4e1-4fbe-b508-8cbfa836600f"), new DateTime(2023, 8, 18, 19, 30, 0, 0, DateTimeKind.Unspecified), "Moderate", false, new DateTime(2023, 8, 18, 18, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Trainees",
                columns: new[] { "Id", "Age", "Gender", "Height", "Level", "UserId", "Weight" },
                values: new object[,]
                {
                    { new Guid("02f24448-29e7-48d1-ae7e-54282df6cc53"), 27, null, 1.8999999999999999, "Advanced", new Guid("557c75b3-d089-46a0-9b71-c800aa685010"), 95.0 },
                    { new Guid("10d01292-4c4a-46b3-a1d7-e87212c0a87b"), 38, null, 1.7, "Intermediate", new Guid("ea4bb973-7977-455a-a92d-6a2cb1dfcca3"), 62.0 },
                    { new Guid("44ea1e99-19e1-4d88-80f7-3d13cad88c5c"), 20, null, null, "Beginner", new Guid("3a0c980b-98fe-4e88-a95e-8926dd775c68"), null },
                    { new Guid("5546a97c-3ed4-48b7-90c7-2c0d70159e28"), 36, null, 1.6699999999999999, "Beginner", new Guid("aeba13bb-2b27-4b1b-b702-5fd482830491"), null },
                    { new Guid("7cb387f1-d0c1-4be2-9cc8-31cba24fdd7c"), 25, null, 1.74, "Intermediate", new Guid("9f76fb38-94d6-4ba8-9069-fd078ca22ebf"), 55.0 },
                    { new Guid("b6830fbd-a3e8-4465-a596-04565c4568bc"), 30, null, 1.8500000000000001, "Advanced", new Guid("dbc5c34e-0e90-42c9-83db-9421948f8f44"), 89.0 }
                });

            migrationBuilder.InsertData(
                table: "Trainers",
                columns: new[] { "Id", "Bio", "CountOfTrainees", "Experience", "UserId" },
                values: new object[,]
                {
                    { new Guid("1495c1e6-c21d-4b6f-b64d-a47d0226f4fc"), "Hi, I'm Sophia, your dynamic gym trainer. Passionate about guiding clients to a healthy life, I'll create personalized workout plans. From strength training to cardio, I'll motivate you to push boundaries. Let's achieve fitness goals together!", 0, 4, new Guid("0fa5eb44-0f0b-455c-bc32-ed60a57f875e") },
                    { new Guid("7b785253-5315-49fe-9d0c-39a8935c6902"), "Hello! I'm Remy Leroy, your energetic gym trainer. Passionate about helping clients reach fitness goals, I'll guide you with knowledge and motivation. Let's transform lives, one rep at a time!", 0, 5, new Guid("5f28263d-a630-4364-8267-75307568014f") },
                    { new Guid("d1079610-d657-4cea-bf9b-0fc1053a6ee8"), "Hey there! I'm Alexander, your dedicated fitness coach. With a mission to inspire a healthier lifestyle, I craft personalized workout routines and nutrition plans. Let's conquer challenges and unleash your potential!", 0, 2, new Guid("bcd3cb31-dc3a-4c20-ad5f-79324bb62443") }
                });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("4ce3627a-7ed9-460f-8954-e84bdf978a18"),
                columns: new[] { "TraineeId", "TrainingId" },
                values: new object[] { new Guid("b6830fbd-a3e8-4465-a596-04565c4568bc"), new Guid("82a1b1c7-1b12-4973-a8c0-9720fe4255fc") });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("a95ee763-73af-4f1e-9942-30004ccdb826"),
                columns: new[] { "TraineeId", "TrainingId" },
                values: new object[] { new Guid("b6830fbd-a3e8-4465-a596-04565c4568bc"), new Guid("5bd931f9-f5ca-472c-8c81-9f011118c0e5") });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("b903e948-dbb2-4177-b9f1-5d2feb46f1a6"),
                columns: new[] { "TraineeId", "TrainingId" },
                values: new object[] { new Guid("02f24448-29e7-48d1-ae7e-54282df6cc53"), new Guid("17e17c3c-ba43-44bb-9fe3-8ec50c4a8dca") });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("e88db467-0004-4e11-9d80-648316f73a31"),
                columns: new[] { "TraineeId", "TrainingId" },
                values: new object[] { new Guid("5546a97c-3ed4-48b7-90c7-2c0d70159e28"), new Guid("88034cb7-c971-4520-a3a1-d48099502562") });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("fd2fa2eb-2bce-482e-9f28-08a2a705b6c9"),
                columns: new[] { "TraineeId", "TrainingId" },
                values: new object[] { new Guid("7cb387f1-d0c1-4be2-9cc8-31cba24fdd7c"), new Guid("922bf694-a4e1-4fbe-b508-8cbfa836600f") });

            migrationBuilder.InsertData(
                table: "GroupActivityTrainers",
                columns: new[] { "ActivityId", "TrainerId" },
                values: new object[,]
                {
                    { new Guid("436818ef-d86c-4e43-88ca-29ff34ad5850"), new Guid("1495c1e6-c21d-4b6f-b64d-a47d0226f4fc") },
                    { new Guid("25b00a8d-13b9-4c33-a145-96b89264d699"), new Guid("7b785253-5315-49fe-9d0c-39a8935c6902") },
                    { new Guid("6d6ee926-6fa3-43a7-8bac-dc86632094a5"), new Guid("d1079610-d657-4cea-bf9b-0fc1053a6ee8") }
                });

            migrationBuilder.UpdateData(
                table: "GroupEnrollments",
                keyColumn: "Id",
                keyValue: new Guid("185f01bb-cb3d-4a44-a718-8da91b77a46a"),
                column: "TraineeId",
                value: new Guid("7cb387f1-d0c1-4be2-9cc8-31cba24fdd7c"));

            migrationBuilder.UpdateData(
                table: "GroupEnrollments",
                keyColumn: "Id",
                keyValue: new Guid("21fe6937-bd86-44af-8c25-3740756f3943"),
                column: "TraineeId",
                value: new Guid("5546a97c-3ed4-48b7-90c7-2c0d70159e28"));

            migrationBuilder.UpdateData(
                table: "GroupEnrollments",
                keyColumn: "Id",
                keyValue: new Guid("b4c5dd72-11d1-4f18-96b3-c03597a0d132"),
                column: "TraineeId",
                value: new Guid("b6830fbd-a3e8-4465-a596-04565c4568bc"));

            migrationBuilder.UpdateData(
                table: "GroupEnrollments",
                keyColumn: "Id",
                keyValue: new Guid("db91e9ab-e05b-4121-b1dd-137d8ac80db9"),
                column: "TraineeId",
                value: new Guid("02f24448-29e7-48d1-ae7e-54282df6cc53"));

            migrationBuilder.UpdateData(
                table: "GroupSchedules",
                keyColumn: "Id",
                keyValue: new Guid("539d5620-f636-439c-a7d5-94f3b3654f70"),
                column: "ActivityId",
                value: new Guid("6d6ee926-6fa3-43a7-8bac-dc86632094a5"));

            migrationBuilder.UpdateData(
                table: "GroupSchedules",
                keyColumn: "Id",
                keyValue: new Guid("5ea2a2d0-10f6-4fff-a4a5-28ce33c5a5ec"),
                column: "ActivityId",
                value: new Guid("25b00a8d-13b9-4c33-a145-96b89264d699"));

            migrationBuilder.UpdateData(
                table: "GroupSchedules",
                keyColumn: "Id",
                keyValue: new Guid("6104ae44-7737-4bfe-9146-969c78f8664b"),
                columns: new[] { "ActivityId", "EndTime", "StartTime" },
                values: new object[] { new Guid("6d6ee926-6fa3-43a7-8bac-dc86632094a5"), new DateTime(2023, 8, 10, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 10, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "GroupSchedules",
                keyColumn: "Id",
                keyValue: new Guid("8d827ef7-962b-4a01-a391-88663ecac213"),
                column: "ActivityId",
                value: new Guid("25b00a8d-13b9-4c33-a145-96b89264d699"));

            migrationBuilder.UpdateData(
                table: "GroupSchedules",
                keyColumn: "Id",
                keyValue: new Guid("a9a81c48-7e25-469e-8f61-75b4669c1b4a"),
                column: "ActivityId",
                value: new Guid("25b00a8d-13b9-4c33-a145-96b89264d699"));

            migrationBuilder.UpdateData(
                table: "GroupSchedules",
                keyColumn: "Id",
                keyValue: new Guid("b3a5cc92-fd09-4fe0-89a9-f6bd98bf90e1"),
                column: "ActivityId",
                value: new Guid("25b00a8d-13b9-4c33-a145-96b89264d699"));

            migrationBuilder.UpdateData(
                table: "GroupSchedules",
                keyColumn: "Id",
                keyValue: new Guid("da220d33-5a34-46a2-9e95-415aaafbe7cd"),
                column: "ActivityId",
                value: new Guid("6d6ee926-6fa3-43a7-8bac-dc86632094a5"));

            migrationBuilder.UpdateData(
                table: "GroupSchedules",
                keyColumn: "Id",
                keyValue: new Guid("f1f607d8-e1e2-4ca8-9bda-caa1cfd0c31f"),
                column: "ActivityId",
                value: new Guid("6d6ee926-6fa3-43a7-8bac-dc86632094a5"));

            migrationBuilder.InsertData(
                table: "GroupSchedules",
                columns: new[] { "Id", "ActivityId", "CountOfTrainees", "EndTime", "StartTime" },
                values: new object[,]
                {
                    { new Guid("1452eef9-d47f-48ce-bea6-8bc0ec775f5e"), new Guid("436818ef-d86c-4e43-88ca-29ff34ad5850"), 0, new DateTime(2023, 8, 28, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 28, 10, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("296e3b96-8ad1-4ceb-847c-331444d36016"), new Guid("436818ef-d86c-4e43-88ca-29ff34ad5850"), 0, new DateTime(2023, 8, 28, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 28, 10, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3d254f93-f684-4536-8dc4-523dd7e69794"), new Guid("25b00a8d-13b9-4c33-a145-96b89264d699"), 0, new DateTime(2023, 8, 16, 13, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 16, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a8ba6cc6-2e6d-4709-ab9b-bc4c4024e29b"), new Guid("436818ef-d86c-4e43-88ca-29ff34ad5850"), 0, new DateTime(2023, 8, 28, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 28, 10, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("bccaca62-a573-47e1-b815-0569bf15dd70"), new Guid("6d6ee926-6fa3-43a7-8bac-dc86632094a5"), 0, new DateTime(2023, 8, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 17, 10, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c4d374b1-c657-4f03-a46c-2c725f630375"), new Guid("436818ef-d86c-4e43-88ca-29ff34ad5850"), 0, new DateTime(2023, 8, 28, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 28, 10, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "IndividualTrainingsTrainers",
                columns: new[] { "TrainerId", "TrainingId" },
                values: new object[,]
                {
                    { new Guid("1495c1e6-c21d-4b6f-b64d-a47d0226f4fc"), new Guid("82a1b1c7-1b12-4973-a8c0-9720fe4255fc") },
                    { new Guid("1495c1e6-c21d-4b6f-b64d-a47d0226f4fc"), new Guid("922bf694-a4e1-4fbe-b508-8cbfa836600f") },
                    { new Guid("7b785253-5315-49fe-9d0c-39a8935c6902"), new Guid("17e17c3c-ba43-44bb-9fe3-8ec50c4a8dca") },
                    { new Guid("7b785253-5315-49fe-9d0c-39a8935c6902"), new Guid("88034cb7-c971-4520-a3a1-d48099502562") },
                    { new Guid("d1079610-d657-4cea-bf9b-0fc1053a6ee8"), new Guid("5bd931f9-f5ca-472c-8c81-9f011118c0e5") }
                });

            migrationBuilder.UpdateData(
                table: "GroupEnrollments",
                keyColumn: "Id",
                keyValue: new Guid("5ec7ebbf-9791-4607-a03c-5a0278a4ba88"),
                columns: new[] { "ScheduleId", "TraineeId" },
                values: new object[] { new Guid("296e3b96-8ad1-4ceb-847c-331444d36016"), new Guid("10d01292-4c4a-46b3-a1d7-e87212c0a87b") });

            migrationBuilder.UpdateData(
                table: "GroupEnrollments",
                keyColumn: "Id",
                keyValue: new Guid("9a28747c-0dd9-4a0f-b489-78c2ae91d8fb"),
                columns: new[] { "ScheduleId", "TraineeId" },
                values: new object[] { new Guid("1452eef9-d47f-48ce-bea6-8bc0ec775f5e"), new Guid("44ea1e99-19e1-4d88-80f7-3d13cad88c5c") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GroupActivityTrainers",
                keyColumns: new[] { "ActivityId", "TrainerId" },
                keyValues: new object[] { new Guid("436818ef-d86c-4e43-88ca-29ff34ad5850"), new Guid("1495c1e6-c21d-4b6f-b64d-a47d0226f4fc") });

            migrationBuilder.DeleteData(
                table: "GroupActivityTrainers",
                keyColumns: new[] { "ActivityId", "TrainerId" },
                keyValues: new object[] { new Guid("25b00a8d-13b9-4c33-a145-96b89264d699"), new Guid("7b785253-5315-49fe-9d0c-39a8935c6902") });

            migrationBuilder.DeleteData(
                table: "GroupActivityTrainers",
                keyColumns: new[] { "ActivityId", "TrainerId" },
                keyValues: new object[] { new Guid("6d6ee926-6fa3-43a7-8bac-dc86632094a5"), new Guid("d1079610-d657-4cea-bf9b-0fc1053a6ee8") });

            migrationBuilder.DeleteData(
                table: "GroupSchedules",
                keyColumn: "Id",
                keyValue: new Guid("1452eef9-d47f-48ce-bea6-8bc0ec775f5e"));

            migrationBuilder.DeleteData(
                table: "GroupSchedules",
                keyColumn: "Id",
                keyValue: new Guid("296e3b96-8ad1-4ceb-847c-331444d36016"));

            migrationBuilder.DeleteData(
                table: "GroupSchedules",
                keyColumn: "Id",
                keyValue: new Guid("3d254f93-f684-4536-8dc4-523dd7e69794"));

            migrationBuilder.DeleteData(
                table: "GroupSchedules",
                keyColumn: "Id",
                keyValue: new Guid("a8ba6cc6-2e6d-4709-ab9b-bc4c4024e29b"));

            migrationBuilder.DeleteData(
                table: "GroupSchedules",
                keyColumn: "Id",
                keyValue: new Guid("bccaca62-a573-47e1-b815-0569bf15dd70"));

            migrationBuilder.DeleteData(
                table: "GroupSchedules",
                keyColumn: "Id",
                keyValue: new Guid("c4d374b1-c657-4f03-a46c-2c725f630375"));

            migrationBuilder.DeleteData(
                table: "IndividualTrainingsTrainers",
                keyColumns: new[] { "TrainerId", "TrainingId" },
                keyValues: new object[] { new Guid("1495c1e6-c21d-4b6f-b64d-a47d0226f4fc"), new Guid("82a1b1c7-1b12-4973-a8c0-9720fe4255fc") });

            migrationBuilder.DeleteData(
                table: "IndividualTrainingsTrainers",
                keyColumns: new[] { "TrainerId", "TrainingId" },
                keyValues: new object[] { new Guid("1495c1e6-c21d-4b6f-b64d-a47d0226f4fc"), new Guid("922bf694-a4e1-4fbe-b508-8cbfa836600f") });

            migrationBuilder.DeleteData(
                table: "IndividualTrainingsTrainers",
                keyColumns: new[] { "TrainerId", "TrainingId" },
                keyValues: new object[] { new Guid("7b785253-5315-49fe-9d0c-39a8935c6902"), new Guid("17e17c3c-ba43-44bb-9fe3-8ec50c4a8dca") });

            migrationBuilder.DeleteData(
                table: "IndividualTrainingsTrainers",
                keyColumns: new[] { "TrainerId", "TrainingId" },
                keyValues: new object[] { new Guid("7b785253-5315-49fe-9d0c-39a8935c6902"), new Guid("88034cb7-c971-4520-a3a1-d48099502562") });

            migrationBuilder.DeleteData(
                table: "IndividualTrainingsTrainers",
                keyColumns: new[] { "TrainerId", "TrainingId" },
                keyValues: new object[] { new Guid("d1079610-d657-4cea-bf9b-0fc1053a6ee8"), new Guid("5bd931f9-f5ca-472c-8c81-9f011118c0e5") });

            migrationBuilder.DeleteData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: new Guid("02f24448-29e7-48d1-ae7e-54282df6cc53"));

            migrationBuilder.DeleteData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: new Guid("10d01292-4c4a-46b3-a1d7-e87212c0a87b"));

            migrationBuilder.DeleteData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: new Guid("44ea1e99-19e1-4d88-80f7-3d13cad88c5c"));

            migrationBuilder.DeleteData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: new Guid("5546a97c-3ed4-48b7-90c7-2c0d70159e28"));

            migrationBuilder.DeleteData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: new Guid("7cb387f1-d0c1-4be2-9cc8-31cba24fdd7c"));

            migrationBuilder.DeleteData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: new Guid("b6830fbd-a3e8-4465-a596-04565c4568bc"));

            migrationBuilder.DeleteData(
                table: "GroupActivities",
                keyColumn: "Id",
                keyValue: new Guid("25b00a8d-13b9-4c33-a145-96b89264d699"));

            migrationBuilder.DeleteData(
                table: "GroupActivities",
                keyColumn: "Id",
                keyValue: new Guid("436818ef-d86c-4e43-88ca-29ff34ad5850"));

            migrationBuilder.DeleteData(
                table: "GroupActivities",
                keyColumn: "Id",
                keyValue: new Guid("6d6ee926-6fa3-43a7-8bac-dc86632094a5"));

            migrationBuilder.DeleteData(
                table: "IndividualTrainings",
                keyColumn: "Id",
                keyValue: new Guid("17e17c3c-ba43-44bb-9fe3-8ec50c4a8dca"));

            migrationBuilder.DeleteData(
                table: "IndividualTrainings",
                keyColumn: "Id",
                keyValue: new Guid("5bd931f9-f5ca-472c-8c81-9f011118c0e5"));

            migrationBuilder.DeleteData(
                table: "IndividualTrainings",
                keyColumn: "Id",
                keyValue: new Guid("82a1b1c7-1b12-4973-a8c0-9720fe4255fc"));

            migrationBuilder.DeleteData(
                table: "IndividualTrainings",
                keyColumn: "Id",
                keyValue: new Guid("88034cb7-c971-4520-a3a1-d48099502562"));

            migrationBuilder.DeleteData(
                table: "IndividualTrainings",
                keyColumn: "Id",
                keyValue: new Guid("922bf694-a4e1-4fbe-b508-8cbfa836600f"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("1495c1e6-c21d-4b6f-b64d-a47d0226f4fc"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("7b785253-5315-49fe-9d0c-39a8935c6902"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("d1079610-d657-4cea-bf9b-0fc1053a6ee8"));

            migrationBuilder.InsertData(
                table: "GroupActivities",
                columns: new[] { "Id", "CategoryId", "CountOfMaxSpots", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("0bb32c51-d799-4004-915f-91ccea62ce11"), 6, 20, "Cross training is a diverse workout approach that involves mixing various exercises and activities to enhance overall fitness and prevent workout plateaus. By combining cardio, strength training, and flexibility exercises, it targets multiple muscle groups and reduces the risk of overuse injuries.", "Cross Training" },
                    { new Guid("6ad5a4d2-11fa-4fee-89e6-a341a47bf527"), 3, 20, "Kickboxing is a high-intensity martial art and cardio workout that combines punching, kicking, and knee strikes. It improves overall fitness, endurance, and self-defense skills while providing a fun and challenging way to burn calories and relieve stress.", "Kickboxing" }
                });

            migrationBuilder.UpdateData(
                table: "GroupEnrollments",
                keyColumn: "Id",
                keyValue: new Guid("185f01bb-cb3d-4a44-a718-8da91b77a46a"),
                column: "TraineeId",
                value: new Guid("3ee69130-4ce4-450d-be65-0ab522760278"));

            migrationBuilder.UpdateData(
                table: "GroupEnrollments",
                keyColumn: "Id",
                keyValue: new Guid("21fe6937-bd86-44af-8c25-3740756f3943"),
                column: "TraineeId",
                value: new Guid("f5c10860-7074-4121-ae6a-f8e6b832340b"));

            migrationBuilder.UpdateData(
                table: "GroupEnrollments",
                keyColumn: "Id",
                keyValue: new Guid("5ec7ebbf-9791-4607-a03c-5a0278a4ba88"),
                columns: new[] { "ScheduleId", "TraineeId" },
                values: new object[] { new Guid("b3a5cc92-fd09-4fe0-89a9-f6bd98bf90e1"), new Guid("f5c10860-7074-4121-ae6a-f8e6b832340b") });

            migrationBuilder.UpdateData(
                table: "GroupEnrollments",
                keyColumn: "Id",
                keyValue: new Guid("9a28747c-0dd9-4a0f-b489-78c2ae91d8fb"),
                columns: new[] { "ScheduleId", "TraineeId" },
                values: new object[] { new Guid("b3a5cc92-fd09-4fe0-89a9-f6bd98bf90e1"), new Guid("e89fc950-317b-454b-9c66-c082db3cbec2") });

            migrationBuilder.UpdateData(
                table: "GroupEnrollments",
                keyColumn: "Id",
                keyValue: new Guid("b4c5dd72-11d1-4f18-96b3-c03597a0d132"),
                column: "TraineeId",
                value: new Guid("efe69cd0-ff7a-4f5a-b038-18a62654c084"));

            migrationBuilder.UpdateData(
                table: "GroupEnrollments",
                keyColumn: "Id",
                keyValue: new Guid("db91e9ab-e05b-4121-b1dd-137d8ac80db9"),
                column: "TraineeId",
                value: new Guid("c4e34109-23ba-42a1-9a17-3797090de18c"));

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

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("4ce3627a-7ed9-460f-8954-e84bdf978a18"),
                columns: new[] { "TraineeId", "TrainingId" },
                values: new object[] { new Guid("efe69cd0-ff7a-4f5a-b038-18a62654c084"), new Guid("3e154226-2820-4837-81c8-247e4604cdd6") });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("a95ee763-73af-4f1e-9942-30004ccdb826"),
                columns: new[] { "TraineeId", "TrainingId" },
                values: new object[] { new Guid("e89fc950-317b-454b-9c66-c082db3cbec2"), new Guid("66afc146-91e8-461f-a9c2-8b61419f6af3") });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("b903e948-dbb2-4177-b9f1-5d2feb46f1a6"),
                columns: new[] { "TraineeId", "TrainingId" },
                values: new object[] { new Guid("f5c10860-7074-4121-ae6a-f8e6b832340b"), new Guid("a2b6df44-832f-4ae2-ae77-4f8bc89a66af") });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("e88db467-0004-4e11-9d80-648316f73a31"),
                columns: new[] { "TraineeId", "TrainingId" },
                values: new object[] { new Guid("3ee69130-4ce4-450d-be65-0ab522760278"), new Guid("492b5886-64cf-4f0e-9fdb-2baed606e361") });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("fd2fa2eb-2bce-482e-9f28-08a2a705b6c9"),
                columns: new[] { "TraineeId", "TrainingId" },
                values: new object[] { new Guid("efe69cd0-ff7a-4f5a-b038-18a62654c084"), new Guid("63d1f1d6-9348-4710-8082-20a1fbf189e2") });

            migrationBuilder.InsertData(
                table: "GroupActivityTrainers",
                columns: new[] { "ActivityId", "TrainerId" },
                values: new object[,]
                {
                    { new Guid("6ad5a4d2-11fa-4fee-89e6-a341a47bf527"), new Guid("5b86293b-856f-47b8-8b93-63a3c7a965e1") },
                    { new Guid("0bb32c51-d799-4004-915f-91ccea62ce11"), new Guid("ad716331-39a9-4ef2-88f2-0e69f7654ec1") }
                });

            migrationBuilder.UpdateData(
                table: "GroupSchedules",
                keyColumn: "Id",
                keyValue: new Guid("539d5620-f636-439c-a7d5-94f3b3654f70"),
                column: "ActivityId",
                value: new Guid("6ad5a4d2-11fa-4fee-89e6-a341a47bf527"));

            migrationBuilder.UpdateData(
                table: "GroupSchedules",
                keyColumn: "Id",
                keyValue: new Guid("5ea2a2d0-10f6-4fff-a4a5-28ce33c5a5ec"),
                column: "ActivityId",
                value: new Guid("0bb32c51-d799-4004-915f-91ccea62ce11"));

            migrationBuilder.UpdateData(
                table: "GroupSchedules",
                keyColumn: "Id",
                keyValue: new Guid("6104ae44-7737-4bfe-9146-969c78f8664b"),
                columns: new[] { "ActivityId", "EndTime", "StartTime" },
                values: new object[] { new Guid("6ad5a4d2-11fa-4fee-89e6-a341a47bf527"), new DateTime(2023, 8, 14, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 14, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "GroupSchedules",
                keyColumn: "Id",
                keyValue: new Guid("8d827ef7-962b-4a01-a391-88663ecac213"),
                column: "ActivityId",
                value: new Guid("0bb32c51-d799-4004-915f-91ccea62ce11"));

            migrationBuilder.UpdateData(
                table: "GroupSchedules",
                keyColumn: "Id",
                keyValue: new Guid("a9a81c48-7e25-469e-8f61-75b4669c1b4a"),
                column: "ActivityId",
                value: new Guid("0bb32c51-d799-4004-915f-91ccea62ce11"));

            migrationBuilder.UpdateData(
                table: "GroupSchedules",
                keyColumn: "Id",
                keyValue: new Guid("b3a5cc92-fd09-4fe0-89a9-f6bd98bf90e1"),
                column: "ActivityId",
                value: new Guid("0bb32c51-d799-4004-915f-91ccea62ce11"));

            migrationBuilder.UpdateData(
                table: "GroupSchedules",
                keyColumn: "Id",
                keyValue: new Guid("da220d33-5a34-46a2-9e95-415aaafbe7cd"),
                column: "ActivityId",
                value: new Guid("6ad5a4d2-11fa-4fee-89e6-a341a47bf527"));

            migrationBuilder.UpdateData(
                table: "GroupSchedules",
                keyColumn: "Id",
                keyValue: new Guid("f1f607d8-e1e2-4ca8-9bda-caa1cfd0c31f"),
                column: "ActivityId",
                value: new Guid("6ad5a4d2-11fa-4fee-89e6-a341a47bf527"));

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
    }
}
