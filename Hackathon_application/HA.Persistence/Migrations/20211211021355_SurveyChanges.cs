using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HA.Persistence.Migrations
{
    public partial class SurveyChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "TotalPrice",
                table: "Zones",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<DateTime>(
                name: "SurveyDate",
                table: "SurveySecond",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "SurveyDate",
                table: "SurveyFirst",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TotalPrice",
                table: "Zones");

            migrationBuilder.DropColumn(
                name: "SurveyDate",
                table: "SurveySecond");

            migrationBuilder.DropColumn(
                name: "SurveyDate",
                table: "SurveyFirst");
        }
    }
}
