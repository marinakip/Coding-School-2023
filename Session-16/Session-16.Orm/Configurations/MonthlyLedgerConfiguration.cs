﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Session_16.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_16.Orm.Configurations {
    public class MonthlyLedgerConfiguration : IEntityTypeConfiguration<MonthlyLedger> {
        public void Configure(EntityTypeBuilder<MonthlyLedger> builder) {
            builder.ToTable("MonthlyLedger");
            builder.HasKey(monthlyLedger => monthlyLedger.MonthlyLedgerID);
            builder.Property(monthlyLedger => monthlyLedger.MonthlyLedgerID).ValueGeneratedOnAdd();            
            builder.Property(monthlyLedger => monthlyLedger.Year).IsRequired(true);
            builder.Property(monthlyLedger => monthlyLedger.Month).IsRequired(true);
            builder.Property(monthlyLedger => monthlyLedger.Income).HasPrecision(12,2).IsRequired(true);
            builder.Property(monthlyLedger => monthlyLedger.Expenses).HasPrecision(12,2).IsRequired(true);
            builder.Property(monthlyLedger => monthlyLedger.Total).HasPrecision(12,2);
        }
    }
}
