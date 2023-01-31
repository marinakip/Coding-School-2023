﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Session_16.Orm.Context;

#nullable disable

namespace Session16.Orm.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Session_16.Model.Customer", b =>
                {
                    b.Property<Guid>("CustomerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(14)
                        .HasColumnType("nvarchar(14)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("TIN")
                        .IsRequired()
                        .HasMaxLength(9)
                        .HasColumnType("nvarchar(9)");

                    b.HasKey("CustomerID");

                    b.ToTable("Customer", (string)null);
                });

            modelBuilder.Entity("Session_16.Model.Employee", b =>
                {
                    b.Property<Guid>("EmployeeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<double>("SalaryPerMonth")
                        .HasColumnType("float");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("TypeEmployee")
                        .HasMaxLength(14)
                        .HasColumnType("int");

                    b.HasKey("EmployeeID");

                    b.ToTable("Employee", (string)null);
                });

            modelBuilder.Entity("Session_16.Model.MonthlyLedger", b =>
                {
                    b.Property<Guid>("MonthlyLedgerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("Expenses")
                        .HasColumnType("float");

                    b.Property<double>("Income")
                        .HasColumnType("float");

                    b.Property<int>("Month")
                        .HasColumnType("int");

                    b.Property<double>("Total")
                        .HasColumnType("float");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("MonthlyLedgerID");

                    b.ToTable("MonthlyLedger", (string)null);
                });

            modelBuilder.Entity("Session_16.Model.Pet", b =>
                {
                    b.Property<Guid>("PetID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Breed")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<double>("Cost")
                        .HasColumnType("float");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("Status")
                        .HasMaxLength(20)
                        .HasColumnType("int");

                    b.Property<int>("Type")
                        .HasMaxLength(15)
                        .HasColumnType("int");

                    b.HasKey("PetID");

                    b.ToTable("Pet", (string)null);
                });

            modelBuilder.Entity("Session_16.Model.PetFood", b =>
                {
                    b.Property<Guid>("PetFoodID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AnimalType")
                        .HasMaxLength(15)
                        .HasColumnType("int");

                    b.Property<double>("PetFoodCost")
                        .HasColumnType("float");

                    b.Property<double>("PetFoodPrice")
                        .HasColumnType("float");

                    b.HasKey("PetFoodID");

                    b.ToTable("PetFood", (string)null);
                });

            modelBuilder.Entity("Session_16.Model.PetReport", b =>
                {
                    b.Property<Guid>("PetReportID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Month")
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    b.Property<int>("TotalSold")
                        .HasColumnType("int");

                    b.Property<int>("TypeAnimal")
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    b.Property<int>("Year")
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    b.HasKey("PetReportID");

                    b.ToTable("PetReport", (string)null);
                });

            modelBuilder.Entity("Session_16.Model.Transaction", b =>
                {
                    b.Property<Guid>("TransactionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CustomerID")
                        .HasMaxLength(50)
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("EmployeeID")
                        .HasMaxLength(50)
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PetFoodID")
                        .HasMaxLength(50)
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("PetFoodPrice")
                        .HasColumnType("float");

                    b.Property<double>("PetFoodQty")
                        .HasColumnType("float");

                    b.Property<Guid>("PetID")
                        .HasMaxLength(50)
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("PetPrice")
                        .HasColumnType("float");

                    b.Property<double>("TotalPrice")
                        .HasColumnType("float");

                    b.Property<DateTime>("TransactionDate")
                        .HasColumnType("datetime2");

                    b.HasKey("TransactionID");

                    b.ToTable("Transaction", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
