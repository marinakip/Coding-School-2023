using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Session16.Orm.Migrations
{
    /// <inheritdoc />
    public partial class NewFixInIDs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PetFood_Transaction_Id",
                table: "PetFood");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PetFood",
                table: "PetFood");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Transaction",
                newName: "TransactionID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "PetReport",
                newName: "PetReportID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "PetFood",
                newName: "TransactionID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Pet",
                newName: "PetID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "MonthlyLedger",
                newName: "MonthlyLedgerID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Employee",
                newName: "EmployeeID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Customer",
                newName: "CustomerID");

            migrationBuilder.AddColumn<Guid>(
                name: "PetFoodID",
                table: "PetFood",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_PetFood",
                table: "PetFood",
                column: "PetFoodID");

            migrationBuilder.CreateIndex(
                name: "IX_PetFood_TransactionID",
                table: "PetFood",
                column: "TransactionID");

            migrationBuilder.AddForeignKey(
                name: "FK_PetFood_Transaction_TransactionID",
                table: "PetFood",
                column: "TransactionID",
                principalTable: "Transaction",
                principalColumn: "TransactionID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PetFood_Transaction_TransactionID",
                table: "PetFood");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PetFood",
                table: "PetFood");

            migrationBuilder.DropIndex(
                name: "IX_PetFood_TransactionID",
                table: "PetFood");

            migrationBuilder.DropColumn(
                name: "PetFoodID",
                table: "PetFood");

            migrationBuilder.RenameColumn(
                name: "TransactionID",
                table: "Transaction",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "PetReportID",
                table: "PetReport",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "TransactionID",
                table: "PetFood",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "PetID",
                table: "Pet",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "MonthlyLedgerID",
                table: "MonthlyLedger",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "EmployeeID",
                table: "Employee",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "CustomerID",
                table: "Customer",
                newName: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PetFood",
                table: "PetFood",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PetFood_Transaction_Id",
                table: "PetFood",
                column: "Id",
                principalTable: "Transaction",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
