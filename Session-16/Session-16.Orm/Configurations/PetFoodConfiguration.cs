using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Session_16.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_16.Orm.Configurations {
    public class PetFoodConfiguration : IEntityTypeConfiguration<PetFood> {
        public void Configure(EntityTypeBuilder<PetFood> builder) {
            builder.ToTable("PetFood");
            builder.HasKey(petFood => petFood.PetFoodID);
            builder.Property(petFood => petFood.PetFoodID).ValueGeneratedOnAdd();
            builder.Property(petFood => petFood.AnimalType).HasMaxLength(15).IsRequired(true);
            builder.Property(petFood => petFood.PetFoodPrice);
            builder.Property(petFood => petFood.PetFoodCost);

            builder.HasOne(petFood => petFood.Transaction)
              .WithMany(transaction => transaction.TransactionLines)
              .HasForeignKey(transaction => transaction.TransactionLineID);
        }
    }
}
