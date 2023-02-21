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
            builder.Property(item => item.Code).IsFixedLength().HasMaxLength(13).IsRequired(); //TODO: Check again code length 
            builder.Property(item => item.Description).HasMaxLength(200).IsRequired();
            builder.Property(item => item.ItemType).IsRequired();
            builder.Property(item => item.Price).HasPrecision(6, 3).IsRequired(); // Fuel has precision of 3 decimal places, e.g 1 lt of petrol has 1.895 euros,
                                                                                  // so made it big enough in case (of a bad outcome) that it goes up to 999,999  
            builder.Property(item => item.Cost).HasPrecision(6, 3).IsRequired();  // so, maybe change precision based on item type using annotations in the DTO

            // Relations
        }
    }
}
