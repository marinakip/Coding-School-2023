using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Session_16.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_16.Orm.Configurations {
    public class PetReportConfiguration : IEntityTypeConfiguration<PetReport> {
        public void Configure(EntityTypeBuilder<PetReport> builder) {
            builder.ToTable("PetReport");
            builder.HasKey(petReport => petReport.PetReportID);
            builder.Property(petReport => petReport.PetReportID).ValueGeneratedOnAdd();
            builder.Property(petReport => petReport.Year).HasMaxLength(10).IsRequired(true);
            builder.Property(petReport => petReport.Month).HasMaxLength(10).IsRequired(true);
            builder.Property(petReport => petReport.TypeAnimal).HasMaxLength(10).IsRequired(true);
            builder.Property(petReport => petReport.TotalSold).HasPrecision(10,2);
        }
    }
}
