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
            builder.HasKey(monthlyLedger => monthlyLedger.Id);
            builder.Property(monthlyLedger => monthlyLedger.Id).ValueGeneratedOnAdd();            
            builder.Property(monthlyLedger => monthlyLedger.Year).IsRequired(true);
            builder.Property(monthlyLedger => monthlyLedger.Month).IsRequired(true);
            builder.Property(monthlyLedger => monthlyLedger.Income).IsRequired(true);
            builder.Property(monthlyLedger => monthlyLedger.Expenses).IsRequired(true);
            builder.Property(monthlyLedger => monthlyLedger.Total);
        }
    }
}
