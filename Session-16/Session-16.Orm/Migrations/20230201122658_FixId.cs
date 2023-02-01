using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Session16.Orm.Migrations
{
    /// <inheritdoc />
    public partial class FixId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PetFood_Transaction_ID",
                table: "PetFood");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Transaction",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "PetReport",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "PetFood",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Pet",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "MonthlyLedger",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Employee",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Customer",
                newName: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PetFood_Transaction_Id",
                table: "PetFood",
                column: "Id",
                principalTable: "Transaction",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PetFood_Transaction_Id",
                table: "PetFood");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Transaction",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "PetReport",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "PetFood",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Pet",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "MonthlyLedger",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Employee",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "Id",
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
    }
}
