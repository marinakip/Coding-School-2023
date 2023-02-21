using FuelStation.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.EntityFramework.Configurations {
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer> {
        public void Configure(EntityTypeBuilder<Customer> builder) {
            // Table Name
            builder.ToTable("Customers");

            // Primary Key
            builder.HasKey(customer => customer.Id);
            builder.Property(customer => customer.Id).ValueGeneratedOnAdd();

            // Properties
            builder.Property(customer => customer.Name).HasMaxLength(50).IsRequired();
            builder.Property(customer => customer.Surname).HasMaxLength(100).IsRequired();
            builder.Property(customer => customer.CardNumber).IsFixedLength().HasMaxLength(18).IsRequired();  //TODO: Check again card length
            builder.HasIndex(customer => customer.CardNumber).IsUnique();

            // Relations
        }
    }
}
