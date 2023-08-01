using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GymHub.Data.Migrations
{
    public partial class SeedApplicationUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("0fa5eb44-0f0b-455c-bc32-ed60a57f875e"), 0, "83abe2ba-cd77-4d38-9183-6ec77987f9da", "sophia.nikolova@gmail.com", false, "Sophia", "Nikolova", false, null, "SOPHIA.NIKOLOVA@GMAIL.COM", "SOPHIA.NIKOLOVA@GMAIL.COM", "AQAAAAEAACcQAAAAEAiCCxi119P7Wdt5HACevTAKRJhISG5l+Mnkxp9TG2YpqF6KZdr8Vze+a8cyuxmEtQ==", "359895998877", false, "1e865714-af27-45a8-a9be-4b86b249e89b", false, "sophia.nikolova@gmail.com" },
                    { new Guid("3a0c980b-98fe-4e88-a95e-8926dd775c68"), 0, "3c06599b-894d-4154-b9a5-566c6d76e349", "ivan.petrov@gmail.com", false, "Ivan", "Petrov", false, null, "IVAN.PETROV@GMAIL.COM", "IVAN.PETROV@GMAIL.COM", "AQAAAAEAACcQAAAAEPUoCG/lNTCHguHAzcXCCme1hosTeDQfk6/gmPEwMZr4GVeZ+cR9yv2i715XAMTqvA==", "359899556677", false, "1a4acdeb-7c12-4dc2-a027-47777ae76da9", false, "ivan.petrov@gmail.com" },
                    { new Guid("557c75b3-d089-46a0-9b71-c800aa685010"), 0, "caa59b17-30ba-4438-8723-4beebc34208c", "noah.sanchez@gmail.com", false, "Noah", "Sanchez", false, null, "NOAH.SANCHEZ@GMAIL.COM", "NOAH.SANCHEZ@GMAIL.COM", "AQAAAAEAACcQAAAAEJ3myLaQis7wuEub+d6eb51OsRNv4AeG2UGivyYBq84r3cmWMufFtKF7fPkAYUEtbg==", null, false, "fba2ef14-58cd-4af6-9e54-a7e927395d86", false, "noah.sanchez@gmail.com" },
                    { new Guid("5f28263d-a630-4364-8267-75307568014f"), 0, "efcc1d34-06e3-4a27-ac83-191f06838a61", "remi.leroy@yahoo.com", false, "Remi", "Leroy", false, null, "REMI.LEROY@YAHOO.COM", "REMI.LEROY@YAHOO.COM", "AQAAAAEAACcQAAAAEDV+wZw8xv0hl14DORhzdJFEDQX9cLY8VPh/lLWswyo2x6ctW5YxJY9qYPM9T6ZEsg==", "33612345678", false, "886fa01d-8b34-4ab8-90c1-60dfcc8728b9", false, "remi.leroy@yahoo.com" },
                    { new Guid("9f76fb38-94d6-4ba8-9069-fd078ca22ebf"), 0, "5a60110c-2001-4c33-ad49-b3c108102c10", "yana.georgieva@gmail.com", false, "Yana", "Georgieva", false, null, "YANA.GEORGIEVA@GMAIL.COM", "YANA.GEORGIEVA@GMAIL.COM", "AQAAAAEAACcQAAAAELHTCK4lvQkj+qbWISvG4lGE3xlXkucQ3QgQDx3XdNMUZ86cI4tKLUE1wrFBgg3LqQ==", "35987223344", false, "60a77677-4454-4bf5-b05f-98024417f6c4", false, "yana.georgieva@gmail.com" },
                    { new Guid("aeba13bb-2b27-4b1b-b702-5fd482830491"), 0, "8609df25-1c9e-4633-bb76-bd3fddd98573", "amelie.dupont@gmail.com", false, "Amelie", "Dupont", false, null, "AMELIE.DUPONT@GMAIL.COM", "AMELIE.DUPONT@GMAIL.COM", "AQAAAAEAACcQAAAAEBb+L7aAA95liJYAxSbgfeFvX4kSakl/ffhxXlCs3ZEdOJ62V678ccZZsOhYyMPgkA==", null, false, "b226ebd8-f251-4e47-8ede-01b9ae0866eb", false, "amelie.dupont@gmail.com" },
                    { new Guid("bcd3cb31-dc3a-4c20-ad5f-79324bb62443"), 0, "2b25f6df-6efc-4d16-9ef5-08b1418f11d0", "alexander.angelov@gmail.com", false, "Alexander", "Angelov", false, null, "ALEXANDER.ANGELOV@GMAIL.COM", "ALEXANDER.ANGELOV@GMAIL.COM", "AQAAAAEAACcQAAAAEBfG0iOA8h5kvAMERijFVoP7HqiS1qGtWCMK2RAq0vjQJuNmSXuaei2j+KhamuvHAw==", "359899112233", false, "4b80ebde-264f-431e-a4a6-c1589b41e616", false, "alexander.angelov@gmail.com" },
                    { new Guid("dbc5c34e-0e90-42c9-83db-9421948f8f44"), 0, "6f3eb9fa-c6f4-44e7-adab-68b4d886b8cc", "james.turner@gmail.com", false, "James", "Turner", false, null, "JAMES.TURNER@GMAIL.COM", "JAMES.TURNER@GMAIL.COM", "AQAAAAEAACcQAAAAEAaMeejDsW7TTTRErnNkktE4HlK+xXCHgFiJZO5J7nTwJmAkFJM6myLFYSAGEoKBLg==", null, false, "14126ad6-1c4c-4a8a-a26d-2810ec96485d", false, "james.turner@gmail.com" },
                    { new Guid("ea4bb973-7977-455a-a92d-6a2cb1dfcca3"), 0, "4adb2ede-4773-4283-8360-e22ca09e4253", "olivia.parker@gmail.com", false, "Olivia", "Parker", false, null, "OLIVIA.PARKER@GMAIL.COM", "OLIVIA.PARKER@GMAIL.COM", "AQAAAAEAACcQAAAAEHtfzsAaVxrwVzmZinE9tgvi9jcwvbuQNeYsjc6VSdAWUZ0h1m8qwPcd//FhC0XU+w==", "447123456789", false, "2b39aeb0-bbc6-4c8e-9d6e-f0fd53fe0216", false, "olivia.parker@gmail.com" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0fa5eb44-0f0b-455c-bc32-ed60a57f875e"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3a0c980b-98fe-4e88-a95e-8926dd775c68"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("557c75b3-d089-46a0-9b71-c800aa685010"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("5f28263d-a630-4364-8267-75307568014f"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9f76fb38-94d6-4ba8-9069-fd078ca22ebf"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("aeba13bb-2b27-4b1b-b702-5fd482830491"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("bcd3cb31-dc3a-4c20-ad5f-79324bb62443"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("dbc5c34e-0e90-42c9-83db-9421948f8f44"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ea4bb973-7977-455a-a92d-6a2cb1dfcca3"));
        }
    }
}
