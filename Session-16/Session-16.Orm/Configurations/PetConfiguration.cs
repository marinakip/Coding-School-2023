using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Session_16.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_16.Orm.Configurations {
    public class PetConfiguration : IEntityTypeConfiguration<Pet> {
        public void Configure(EntityTypeBuilder<Pet> builder) {
            builder.ToTable("Pet");
            builder.HasKey(pet => pet.PetID);
            builder.Property(pet => pet.PetID).ValueGeneratedOnAdd();
            builder.Property(pet => pet.Breed).HasMaxLength(20).IsRequired(true);
            builder.Property(pet => pet.Type).HasMaxLength(15).IsRequired(true);
            builder.Property(pet => pet.Status).HasMaxLength(20).IsRequired(true);
            builder.Property(pet => pet.Price).HasPrecision(10);
            builder.Property(pet => pet.Cost).HasPrecision(10);

        }
    }
}
