using FuelStation.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.EntityFramework.Configurations {
    public class TransactionLineConfiguration : IEntityTypeConfiguration<TransactionLine> {
        public void Configure(EntityTypeBuilder<TransactionLine> builder) {
            // Table Name
            builder.ToTable("TransactionLines");

            // Primary Key
            builder.HasKey(transactionLine => transactionLine.Id);
            builder.Property(transactionLine => transactionLine.Id).ValueGeneratedOnAdd();

            // Properties
            builder.Property(transactionLine => transactionLine.Quantity).IsRequired();
            builder.Property(transactionLine => transactionLine.ItemPrice).HasPrecision(6,3).IsRequired();
            builder.Property(transactionLine => transactionLine.NetValue).HasPrecision(9,3).IsRequired(); 
            // Net Value has big precision, because for example a gasoline truck may load fuel
            // and it has thousands of gallons capacity, so in this case the net value is going to be big 

            builder.Property(transactionLine => transactionLine.DiscountPercent).HasPrecision(5,4).IsRequired();  //e.g 22,22% will be 0,2222
            builder.Property(transactionLine => transactionLine.DiscountValue).HasPrecision(9,3).IsRequired();     //TODO: Check again precision
            builder.Property(transactionLine => transactionLine.TotalValue).HasPrecision(9,3).IsRequired();  
           
            // Relations
            
            builder.HasOne(t => t.Transaction)
                .WithMany(t => t.TransactionLines)             
                .HasForeignKey(t => t.TransactionId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(t => t.Item)
              .WithMany(t => t.TransactionLines)
              .HasForeignKey(t => t.ItemId)
              .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
