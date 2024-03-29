﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Session_16.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_16.Orm.Configurations {
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer> {
        public void Configure(EntityTypeBuilder<Customer> builder) {
            builder.ToTable("Customer");
            builder.HasKey(customer => customer.CustomerID);
            builder.Property(customer => customer.CustomerID).ValueGeneratedOnAdd();    
            builder.Property(customer => customer.Name).HasMaxLength(50).IsRequired(true); 
            builder.Property(customer => customer.Surname).HasMaxLength(50).IsRequired(true);
            builder.Property(customer => customer.Phone).HasMaxLength(40).IsRequired(true);
            builder.Property(customer => customer.TIN).HasMaxLength(20); 
            
        }
    }
}
