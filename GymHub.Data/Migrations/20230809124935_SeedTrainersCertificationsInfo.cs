using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GymHub.Data.Migrations
{
    public partial class SeedTrainersCertificationsInfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TrainerCertifications_Certifications_CetrificationId",
                table: "TrainerCertifications");

            migrationBuilder.RenameColumn(
                name: "CetrificationId",
                table: "TrainerCertifications",
                newName: "CertificationId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Certifications",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddColumn<string>(
                name: "IssuingOrganization",
                table: "Certifications",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ba3a5230-8e32-4d72-bc27-def1a8ab665a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "eb9d9bc3-c148-48d7-ac27-55581fe64051", "AQAAAAEAACcQAAAAEM4tN+IjR5mNYwai+t41OPQSNcK6AZUpwoVLxIXlyT+B6ZE1TyMuM9/KhkZ2o2u6YQ==" });

            migrationBuilder.InsertData(
                table: "Certifications",
                columns: new[] { "Id", "IssueDate", "IssuingOrganization", "Name" },
                values: new object[,]
                {
                    { new Guid("5d8ce6bd-4def-4e06-beba-9beca0a08f94"), new DateTime(2021, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "The International Sports Sciences Association (ISSA)", "Martial Arts Trainer" },
                    { new Guid("8d52ff35-fcfc-4385-ae23-a45be1db42f4"), new DateTime(2019, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alison", "Internationally Accredited Diploma Certificate in Fitness" },
                    { new Guid("a108e18e-436d-4b80-b651-f06dc7dfc6fd"), new DateTime(2021, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "The National Academy of Sports Medicine (NASM)", "Personal Trainer" },
                    { new Guid("abc5ab25-3e76-43cb-be4b-2b05b50e7893"), new DateTime(2022, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Yoga Alliance Teacher Training", "Registered Yoga Teacher (RYT)" }
                });

            migrationBuilder.InsertData(
                table: "TrainerCertifications",
                columns: new[] { "CertificationId", "TrainerId" },
                values: new object[,]
                {
                    { new Guid("5d8ce6bd-4def-4e06-beba-9beca0a08f94"), new Guid("d1079610-d657-4cea-bf9b-0fc1053a6ee8") },
                    { new Guid("8d52ff35-fcfc-4385-ae23-a45be1db42f4"), new Guid("7b785253-5315-49fe-9d0c-39a8935c6902") },
                    { new Guid("a108e18e-436d-4b80-b651-f06dc7dfc6fd"), new Guid("3fcaa2a4-59e1-4af4-9146-6f30716f836c") },
                    { new Guid("abc5ab25-3e76-43cb-be4b-2b05b50e7893"), new Guid("1495c1e6-c21d-4b6f-b64d-a47d0226f4fc") }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_TrainerCertifications_Certifications_CertificationId",
                table: "TrainerCertifications",
                column: "CertificationId",
                principalTable: "Certifications",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TrainerCertifications_Certifications_CertificationId",
                table: "TrainerCertifications");

            migrationBuilder.DeleteData(
                table: "TrainerCertifications",
                keyColumns: new[] { "CertificationId", "TrainerId" },
                keyValues: new object[] { new Guid("5d8ce6bd-4def-4e06-beba-9beca0a08f94"), new Guid("d1079610-d657-4cea-bf9b-0fc1053a6ee8") });

            migrationBuilder.DeleteData(
                table: "TrainerCertifications",
                keyColumns: new[] { "CertificationId", "TrainerId" },
                keyValues: new object[] { new Guid("8d52ff35-fcfc-4385-ae23-a45be1db42f4"), new Guid("7b785253-5315-49fe-9d0c-39a8935c6902") });

            migrationBuilder.DeleteData(
                table: "TrainerCertifications",
                keyColumns: new[] { "CertificationId", "TrainerId" },
                keyValues: new object[] { new Guid("a108e18e-436d-4b80-b651-f06dc7dfc6fd"), new Guid("3fcaa2a4-59e1-4af4-9146-6f30716f836c") });

            migrationBuilder.DeleteData(
                table: "TrainerCertifications",
                keyColumns: new[] { "CertificationId", "TrainerId" },
                keyValues: new object[] { new Guid("abc5ab25-3e76-43cb-be4b-2b05b50e7893"), new Guid("1495c1e6-c21d-4b6f-b64d-a47d0226f4fc") });

            migrationBuilder.DeleteData(
                table: "Certifications",
                keyColumn: "Id",
                keyValue: new Guid("5d8ce6bd-4def-4e06-beba-9beca0a08f94"));

            migrationBuilder.DeleteData(
                table: "Certifications",
                keyColumn: "Id",
                keyValue: new Guid("8d52ff35-fcfc-4385-ae23-a45be1db42f4"));

            migrationBuilder.DeleteData(
                table: "Certifications",
                keyColumn: "Id",
                keyValue: new Guid("a108e18e-436d-4b80-b651-f06dc7dfc6fd"));

            migrationBuilder.DeleteData(
                table: "Certifications",
                keyColumn: "Id",
                keyValue: new Guid("abc5ab25-3e76-43cb-be4b-2b05b50e7893"));

            migrationBuilder.DropColumn(
                name: "IssuingOrganization",
                table: "Certifications");

            migrationBuilder.RenameColumn(
                name: "CertificationId",
                table: "TrainerCertifications",
                newName: "CetrificationId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Certifications",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(60)",
                oldMaxLength: 60);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ba3a5230-8e32-4d72-bc27-def1a8ab665a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4e32f838-9722-4a95-91b9-f4d2882609e6", "AQAAAAEAACcQAAAAEBxuatXta1Y6/rcl4rvkbqNiP/sWIMxoMf9OgF0Yosvw2xsbfxfbF8poImiRS2nbUA==" });

            migrationBuilder.AddForeignKey(
                name: "FK_TrainerCertifications_Certifications_CetrificationId",
                table: "TrainerCertifications",
                column: "CetrificationId",
                principalTable: "Certifications",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
