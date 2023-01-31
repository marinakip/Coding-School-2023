using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Session16.Orm.Migrations
{
    /// <inheritdoc />
    public partial class ChangesInConfigurations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_PetReport",
                table: "PetReport");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MonthlyLedger",
                table: "MonthlyLedger");

            migrationBuilder.AddColumn<Guid>(
                name: "PetReportID",
                table: "PetReport",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "MonthlyLedgerID",
                table: "MonthlyLedger",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_PetReport",
                table: "PetReport",
                column: "PetReportID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MonthlyLedger",
                table: "MonthlyLedger",
                column: "MonthlyLedgerID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_PetReport",
                table: "PetReport");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MonthlyLedger",
                table: "MonthlyLedger");

            migrationBuilder.DropColumn(
                name: "PetReportID",
                table: "PetReport");

            migrationBuilder.DropColumn(
                name: "MonthlyLedgerID",
                table: "MonthlyLedger");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PetReport",
                table: "PetReport",
                columns: new[] { "Month", "Year" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_MonthlyLedger",
                table: "MonthlyLedger",
                columns: new[] { "Month", "Year" });
        }
    }
}
