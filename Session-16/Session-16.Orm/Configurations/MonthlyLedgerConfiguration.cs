using Microsoft.EntityFrameworkCore;
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
            builder.HasKey(monthlyLedger => new { monthlyLedger.Month, monthlyLedger.Year});
            builder.Property(monthlyLedger => monthlyLedger.Year).HasPrecision(10).IsRequired(true);
            builder.Property(monthlyLedger => monthlyLedger.Month).HasPrecision(10).IsRequired(true);
            builder.Property(monthlyLedger => monthlyLedger.Income).HasPrecision(10).IsRequired(true);
            builder.Property(monthlyLedger => monthlyLedger.Expenses).HasPrecision(10).IsRequired(true);
            builder.Property(monthlyLedger => monthlyLedger.Total).HasPrecision(10);
        }
    }
}
