using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Session_16.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_16.Orm.Configurations {
    public class TransactionConfiguration : IEntityTypeConfiguration<Transaction> {
        public void Configure(EntityTypeBuilder<Transaction> builder) {
            builder.ToTable("Transaction");
            builder.HasKey(transaction => transaction.TransactionID);
            builder.Property(transaction => transaction.TransactionID).ValueGeneratedOnAdd();
            builder.Property(transaction => transaction.TransactionDate).IsRequired(true);
            builder.Property(transaction => transaction.CustomerID).HasMaxLength(50).IsRequired(true);
            builder.Property(transaction => transaction.EmployeeID).HasMaxLength(50).IsRequired(true);
            builder.Property(transaction => transaction.PetID).HasMaxLength(50).IsRequired(true);
            builder.Property(transaction => transaction.PetPrice);
            builder.Property(transaction => transaction.PetFoodID).HasMaxLength(50).IsRequired(true);
            builder.Property(transaction => transaction.PetFoodQty);
            builder.Property(transaction => transaction.PetFoodPrice);
            builder.Property(transaction => transaction.TotalPrice);          
        }
    }
}
