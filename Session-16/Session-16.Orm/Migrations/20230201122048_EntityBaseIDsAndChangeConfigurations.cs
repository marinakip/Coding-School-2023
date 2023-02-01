using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Session16.Orm.Migrations
{
    /// <inheritdoc />
    public partial class EntityBaseIDsAndChangeConfigurations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PetFood_Transaction_PetFoodID",
                table: "PetFood");

            migrationBuilder.RenameColumn(
                name: "TransactionID",
                table: "Transaction",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "PetReportID",
                table: "PetReport",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "PetFoodID",
                table: "PetFood",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "PetID",
                table: "Pet",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "MonthlyLedgerID",
                table: "MonthlyLedger",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "EmployeeID",
                table: "Employee",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "CustomerID",
                table: "Customer",
                newName: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_PetFood_Transaction_ID",
                table: "PetFood",
                column: "ID",
                principalTable: "Transaction",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PetFood_Transaction_ID",
                table: "PetFood");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Transaction",
                newName: "TransactionID");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "PetReport",
                newName: "PetReportID");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "PetFood",
                newName: "PetFoodID");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Pet",
                newName: "PetID");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "MonthlyLedger",
                newName: "MonthlyLedgerID");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Employee",
                newName: "EmployeeID");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Customer",
                newName: "CustomerID");

            migrationBuilder.AddForeignKey(
                name: "FK_PetFood_Transaction_PetFoodID",
                table: "PetFood",
                column: "PetFoodID",
                principalTable: "Transaction",
                principalColumn: "TransactionID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
