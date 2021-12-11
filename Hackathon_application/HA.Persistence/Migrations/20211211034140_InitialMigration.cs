using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HA.Persistence.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FirstSurveys",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Survey = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ZoneId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SurveyDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FirstSurveys", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FirstThresholds",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Level = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FirstThresholds", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PriceMultipliers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Multiplier = table.Column<double>(type: "float", nullable: false),
                    ThresholdFirstId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ThresholdSecondId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PriceMultipliers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SecondSurveys",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Survey = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ZoneId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SurveyDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SecondSurveys", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SecondThresholds",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Level = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SecondThresholds", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Zones",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ZoneName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DefaultPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SurveyFirstId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SurveySecondId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zones", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "FirstSurveys",
                columns: new[] { "Id", "Survey", "SurveyDate", "ZoneId" },
                values: new object[,]
                {
                    { new Guid("cf680241-854c-48f2-925c-d15c49ed1af1"), "87", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("68ef9410-3a7c-443d-ab0c-1e2b15939415") },
                    { new Guid("094234be-b6c7-438a-ae17-5fa53324f5bb"), "21", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f610e3de-a686-4987-8bcf-457c009fd47f") },
                    { new Guid("2b9b964f-85ef-4e24-8bd3-39cd8198aaf8"), "62", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("19752857-ea39-4229-90f8-a14f0695b042") },
                    { new Guid("80d8e42e-dd52-463e-823d-b9a0b887530b"), "180", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("0363c650-fc4f-4df4-b0a4-912dc7ca3151") },
                    { new Guid("010067d6-43b2-4f19-ba0f-40a175bd8185"), "250", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("043ce184-4089-4614-bac8-a1bd300c8a7c") },
                    { new Guid("b2af4bb0-708e-4b90-8a90-e1c25a28e9fa"), "1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("cf169adb-cdcd-4f2e-9635-34b48235fba5") },
                    { new Guid("deddf733-ab67-4737-a7b6-ec17a6e4b3ad"), "19", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("7ee11209-89fc-4361-9d64-7941a21baa23") },
                    { new Guid("990b0236-b377-41f3-bb06-bdaec289be2d"), "137", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8fd9ec8f-2bc3-4f36-9d70-0e6ad5b10b14") },
                    { new Guid("cbe23efd-4dbb-4cd4-b83a-ae353db0d954"), "300", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3529a503-c48f-47ad-ad43-9fdcb8744d89") }
                });

            migrationBuilder.InsertData(
                table: "FirstThresholds",
                columns: new[] { "Id", "Level" },
                values: new object[,]
                {
                    { new Guid("5427565f-60be-4644-a617-590de1355544"), 60 },
                    { new Guid("792aaeda-61a5-44ea-b357-718b9da5ca10"), 100 },
                    { new Guid("d3346656-a7b2-43a9-a23e-6ac4e5bff879"), 140 },
                    { new Guid("2f04ee11-48ae-45e5-afcc-f32babeebe38"), 200 }
                });

            migrationBuilder.InsertData(
                table: "PriceMultipliers",
                columns: new[] { "Id", "Multiplier", "Name", "ThresholdFirstId", "ThresholdSecondId" },
                values: new object[,]
                {
                    { new Guid("9d9c9700-2137-4c81-9c44-c75fb32e5e83"), 1.0, "VGoodGood", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("837a442f-fb96-43ef-a5a7-167323b15823"), 3.0, "Vbad", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("f52a50d2-980a-4061-ab04-6c961fa5a37d"), 2.0, "Bad", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("fcb99fe6-7cbe-436b-b521-80eb9fa2d12b"), 1.5, "Satisfactory", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("7a9a08bb-8453-401a-887e-3e91e834f24f"), 1.25, "Moderate", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "SecondSurveys",
                columns: new[] { "Id", "Survey", "SurveyDate", "ZoneId" },
                values: new object[,]
                {
                    { new Guid("4f971182-3a72-4e28-8be2-118555b01606"), "0", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("cf169adb-cdcd-4f2e-9635-34b48235fba5") },
                    { new Guid("3ba78a8f-fe79-4ad9-b414-545ed0f51cbb"), "157", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3529a503-c48f-47ad-ad43-9fdcb8744d89") },
                    { new Guid("65e416bf-15d7-44b2-9d00-7832b177496b"), "15", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("7ee11209-89fc-4361-9d64-7941a21baa23") },
                    { new Guid("240d13e3-719a-487f-bb69-d807498c0302"), "49", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("68ef9410-3a7c-443d-ab0c-1e2b15939415") },
                    { new Guid("fd931c8b-df99-431e-9267-25f0ff4e37e4"), "68", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("043ce184-4089-4614-bac8-a1bd300c8a7c") },
                    { new Guid("79bfc186-7775-4c4f-83e1-6b5416d59a50"), "56", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("0363c650-fc4f-4df4-b0a4-912dc7ca3151") },
                    { new Guid("ed26e72b-1c72-48be-aea7-898c49b5952d"), "26", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("19752857-ea39-4229-90f8-a14f0695b042") },
                    { new Guid("b4682943-ded9-435b-a689-45d5103b6f33"), "45", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f610e3de-a686-4987-8bcf-457c009fd47f") },
                    { new Guid("2b2b48d9-ee31-48f4-a495-65af6c8f8859"), "125", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8fd9ec8f-2bc3-4f36-9d70-0e6ad5b10b14") }
                });

            migrationBuilder.InsertData(
                table: "SecondThresholds",
                columns: new[] { "Id", "Level" },
                values: new object[,]
                {
                    { new Guid("db814f80-0154-4e71-a787-625487ea2bbc"), 120 },
                    { new Guid("ada39846-4e68-4a4f-a219-ca6bcefda46c"), 36 },
                    { new Guid("45eb5a2c-f47a-47d7-8bbf-881ac5b58909"), 60 },
                    { new Guid("8b778ce7-9cda-4c45-b8d7-23c02ae6a4af"), 84 }
                });

            migrationBuilder.InsertData(
                table: "Zones",
                columns: new[] { "Id", "DefaultPrice", "SurveyFirstId", "SurveySecondId", "TotalPrice", "ZoneName" },
                values: new object[,]
                {
                    { new Guid("8fd9ec8f-2bc3-4f36-9d70-0e6ad5b10b14"), 6.00m, new Guid("990b0236-b377-41f3-bb06-bdaec289be2d"), new Guid("2b2b48d9-ee31-48f4-a495-65af6c8f8859"), 0m, "S7" },
                    { new Guid("7ee11209-89fc-4361-9d64-7941a21baa23"), 4.50m, new Guid("deddf733-ab67-4737-a7b6-ec17a6e4b3ad"), new Guid("65e416bf-15d7-44b2-9d00-7832b177496b"), 0m, "S6" },
                    { new Guid("68ef9410-3a7c-443d-ab0c-1e2b15939415"), 4.50m, new Guid("cf680241-854c-48f2-925c-d15c49ed1af1"), new Guid("240d13e3-719a-487f-bb69-d807498c0302"), 0m, "S5" },
                    { new Guid("3529a503-c48f-47ad-ad43-9fdcb8744d89"), 6.00m, new Guid("cbe23efd-4dbb-4cd4-b83a-ae353db0d954"), new Guid("3ba78a8f-fe79-4ad9-b414-545ed0f51cbb"), 0m, "S8" },
                    { new Guid("0363c650-fc4f-4df4-b0a4-912dc7ca3151"), 3.50m, new Guid("80d8e42e-dd52-463e-823d-b9a0b887530b"), new Guid("79bfc186-7775-4c4f-83e1-6b5416d59a50"), 0m, "S3" },
                    { new Guid("19752857-ea39-4229-90f8-a14f0695b042"), 3.50m, new Guid("2b9b964f-85ef-4e24-8bd3-39cd8198aaf8"), new Guid("ed26e72b-1c72-48be-aea7-898c49b5952d"), 0m, "S2" },
                    { new Guid("f610e3de-a686-4987-8bcf-457c009fd47f"), 3.50m, new Guid("094234be-b6c7-438a-ae17-5fa53324f5bb"), new Guid("b4682943-ded9-435b-a689-45d5103b6f33"), 0m, "S1" },
                    { new Guid("043ce184-4089-4614-bac8-a1bd300c8a7c"), 4.50m, new Guid("010067d6-43b2-4f19-ba0f-40a175bd8185"), new Guid("fd931c8b-df99-431e-9267-25f0ff4e37e4"), 0m, "S4" },
                    { new Guid("cf169adb-cdcd-4f2e-9635-34b48235fba5"), 6.00m, new Guid("b2af4bb0-708e-4b90-8a90-e1c25a28e9fa"), new Guid("4f971182-3a72-4e28-8be2-118555b01606"), 0m, "S9" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FirstSurveys");

            migrationBuilder.DropTable(
                name: "FirstThresholds");

            migrationBuilder.DropTable(
                name: "PriceMultipliers");

            migrationBuilder.DropTable(
                name: "SecondSurveys");

            migrationBuilder.DropTable(
                name: "SecondThresholds");

            migrationBuilder.DropTable(
                name: "Zones");
        }
    }
}
