using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Session16.Orm.Migrations
{
    /// <inheritdoc />
    public partial class RelationsInTransactionAndPetFoodConfigs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Transaction_CustomerID",
                table: "Transaction",
                column: "CustomerID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Transaction_EmployeeID",
                table: "Transaction",
                column: "EmployeeID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Transaction_PetID",
                table: "Transaction",
                column: "PetID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_PetFood_Transaction_PetFoodID",
                table: "PetFood",
                column: "PetFoodID",
                principalTable: "Transaction",
                principalColumn: "TransactionID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Transaction_Customer_CustomerID",
                table: "Transaction",
                column: "CustomerID",
                principalTable: "Customer",
                principalColumn: "CustomerID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Transaction_Employee_EmployeeID",
                table: "Transaction",
                column: "EmployeeID",
                principalTable: "Employee",
                principalColumn: "EmployeeID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Transaction_Pet_PetID",
                table: "Transaction",
                column: "PetID",
                principalTable: "Pet",
                principalColumn: "PetID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PetFood_Transaction_PetFoodID",
                table: "PetFood");

            migrationBuilder.DropForeignKey(
                name: "FK_Transaction_Customer_CustomerID",
                table: "Transaction");

            migrationBuilder.DropForeignKey(
                name: "FK_Transaction_Employee_EmployeeID",
                table: "Transaction");

            migrationBuilder.DropForeignKey(
                name: "FK_Transaction_Pet_PetID",
                table: "Transaction");

            migrationBuilder.DropIndex(
                name: "IX_Transaction_CustomerID",
                table: "Transaction");

            migrationBuilder.DropIndex(
                name: "IX_Transaction_EmployeeID",
                table: "Transaction");

            migrationBuilder.DropIndex(
                name: "IX_Transaction_PetID",
                table: "Transaction");
        }
    }
}
