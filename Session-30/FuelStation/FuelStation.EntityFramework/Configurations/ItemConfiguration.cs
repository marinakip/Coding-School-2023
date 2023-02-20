using FuelStation.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.EntityFramework.Configurations {
    public class ItemConfiguration : IEntityTypeConfiguration<Item> {
        public void Configure(EntityTypeBuilder<Item> builder) {
            // Table Name
            builder.ToTable("Items");

            // Primary Key
            builder.HasKey(item => item.Id);
            builder.Property(item => item.Id).ValueGeneratedOnAdd();

            // Properties
            builder.HasIndex(item => item.Code).IsUnique();
            builder.Property(item => item.Description).HasMaxLength(200).IsRequired();
            builder.Property(item => item.ItemType).IsRequired();
            builder.Property(item => item.Price).HasPrecision(9, 3).IsRequired(); // Fuel has precision of 3 decimal places
            builder.Property(item => item.Cost).HasPrecision(9, 3).IsRequired();  // so, maybe change precision based on item type in the DTO
                                                                                  // The number it can hold in price and cost is big, because
                                                                                  // for example a gasoline truck may load fuel and it has thousands of gallons capacity,
            // Relations                                                          // so in this case the price is going to be big, //TODO: maybe cost should have small precision
                                                                                  // TODO: maybe i need this thought on transaction line, come back to check this later


        }
    }
}
