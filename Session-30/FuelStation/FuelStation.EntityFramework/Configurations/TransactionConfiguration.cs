using FuelStation.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.EntityFramework.Configurations {
    public class TransactionConfiguration : IEntityTypeConfiguration<Transaction> {
        public void Configure(EntityTypeBuilder<Transaction> builder) {
            // Table Name
            builder.ToTable("Transactions");

            // Primary Key
            builder.HasKey(transaction => transaction.Id);
            builder.Property(transaction => transaction.Id).ValueGeneratedOnAdd();

            // Properties
            builder.Property(transaction => transaction.Date).IsRequired();
            builder.Property(transaction => transaction.PaymentMethod).IsRequired();
            builder.Property(transaction => transaction.TotalValue).HasPrecision(9, 3).IsRequired();  //TODO: Check again precision

            // Relations
           
            builder.HasOne(t => t.Employee)
                .WithMany(t => t.Transactions)        
                .HasForeignKey(t => t.EmployeeId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(t => t.Customer)
              .WithMany(t => t.Transactions)
              .HasForeignKey(t => t.CustomerId)
              .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
