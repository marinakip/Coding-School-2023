using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Session_16.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_16.Orm.Configurations {
    public class SpecialOfferConfiguration : IEntityTypeConfiguration<SpecialOffer> {
        public void Configure(EntityTypeBuilder<SpecialOffer> builder) {
            builder.ToTable("SpecialOffer");
            builder.HasKey(specialOffer => specialOffer.SpecialOfferID);
            builder.Property(specialOffer => specialOffer.SpecialOfferID).ValueGeneratedOnAdd();           
        }
    }
}
