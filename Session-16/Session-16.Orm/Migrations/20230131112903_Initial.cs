using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Session16.Orm.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    CustomerID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: false),
                    TIN = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.CustomerID);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    EmployeeID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TypeEmployee = table.Column<int>(type: "int", maxLength: 14, nullable: false),
                    SalaryPerMonth = table.Column<double>(type: "float", maxLength: 9, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.EmployeeID);
                });

            migrationBuilder.CreateTable(
                name: "MonthlyLedger",
                columns: table => new
                {
                    Year = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    Month = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    Income = table.Column<double>(type: "float", maxLength: 10, nullable: false),
                    Expenses = table.Column<double>(type: "float", maxLength: 10, nullable: false),
                    Total = table.Column<double>(type: "float", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonthlyLedger", x => new { x.Month, x.Year });
                });

            migrationBuilder.CreateTable(
                name: "Pet",
                columns: table => new
                {
                    PetID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Breed = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Type = table.Column<int>(type: "int", maxLength: 15, nullable: false),
                    Status = table.Column<int>(type: "int", maxLength: 20, nullable: false),
                    Price = table.Column<double>(type: "float", maxLength: 10, nullable: false),
                    Cost = table.Column<double>(type: "float", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pet", x => x.PetID);
                });

            migrationBuilder.CreateTable(
                name: "PetFood",
                columns: table => new
                {
                    PetFoodID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AnimalType = table.Column<int>(type: "int", maxLength: 15, nullable: false),
                    PetFoodPrice = table.Column<double>(type: "float", maxLength: 10, nullable: false),
                    PetFoodCost = table.Column<double>(type: "float", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PetFood", x => x.PetFoodID);
                });

            migrationBuilder.CreateTable(
                name: "PetReport",
                columns: table => new
                {
                    Year = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    Month = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    TypeAnimal = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    TotalSold = table.Column<int>(type: "int", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PetReport", x => new { x.Month, x.Year });
                });

            migrationBuilder.CreateTable(
                name: "Transaction",
                columns: table => new
                {
                    TransactionID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TransactionDate = table.Column<DateTime>(type: "datetime2", maxLength: 30, nullable: false),
                    CustomerID = table.Column<Guid>(type: "uniqueidentifier", maxLength: 50, nullable: false),
                    EmployeeID = table.Column<Guid>(type: "uniqueidentifier", maxLength: 50, nullable: false),
                    PetID = table.Column<Guid>(type: "uniqueidentifier", maxLength: 50, nullable: false),
                    PetPrice = table.Column<double>(type: "float", maxLength: 10, nullable: false),
                    PetFoodID = table.Column<Guid>(type: "uniqueidentifier", maxLength: 50, nullable: false),
                    PetFoodQty = table.Column<double>(type: "float", maxLength: 10, nullable: false),
                    PetFoodPrice = table.Column<double>(type: "float", maxLength: 10, nullable: false),
                    TotalPrice = table.Column<double>(type: "float", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transaction", x => x.TransactionID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "MonthlyLedger");

            migrationBuilder.DropTable(
                name: "Pet");

            migrationBuilder.DropTable(
                name: "PetFood");

            migrationBuilder.DropTable(
                name: "PetReport");

            migrationBuilder.DropTable(
                name: "Transaction");
        }
    }
}
