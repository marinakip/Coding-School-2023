using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Session_16.Model;

namespace Session_16.Orm.Configurations {
    public class TransactionLineConfiguration : IEntityTypeConfiguration<TransactionLine> {
        public void Configure(EntityTypeBuilder<TransactionLine> builder) {
            builder.ToTable("TransactionLine");
            builder.HasKey(transactionLine => transactionLine.TransactionLineID);
            builder.Property(transactionLine => transactionLine.TransactionLineID).ValueGeneratedOnAdd();
            builder.Property(transactionLine => transactionLine.PetFoodQty).IsRequired(true);
            builder.Property(transactionLine => transactionLine.PetFoodCost).HasPrecision(10,2).IsRequired(true);
            builder.Property(transactionLine => transactionLine.PetFoodPrice).HasPrecision(10,2);
            builder.Property(transactionLine => transactionLine.PetPrice).HasPrecision(10, 2).IsRequired(true);
            builder.Property(transactionLine => transactionLine.LineTotal).HasPrecision(10, 2);

            builder.HasOne(transactionLine => transactionLine.Transaction)
                   .WithMany(transaction => transaction.TransactionLines)
                   .HasForeignKey(transactionLine => transactionLine.TransactionID);

            builder.HasOne(transactionLine => transactionLine.Pet)
                   .WithOne(pet => pet.TransactionLine)
                   .HasForeignKey<TransactionLine>(transactionLine => transactionLine.PetID);
            
            builder.HasOne(transactionLine => transactionLine.PetFood)
                   .WithOne(petFood => petFood.TransactionLine)
                   .HasForeignKey<TransactionLine>(transactionLine => transactionLine.PetFoodID);
            
            builder.HasOne(transactionLine => transactionLine.SpecialOffer)
                   .WithOne(specialOffer => specialOffer.TransactionLine)
                   .HasForeignKey<TransactionLine>(transactionLine => transactionLine.SpecialOfferID);


        }   
    }
}
