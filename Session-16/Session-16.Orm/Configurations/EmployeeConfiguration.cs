using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Session_16.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_16.Orm.Configurations
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee> {
        public void Configure(EntityTypeBuilder<Employee> builder) {
            builder.ToTable("Employee");
            builder.HasKey(employee => employee.EmployeeID);
            builder.Property(employee => employee.EmployeeID).ValueGeneratedOnAdd();
            builder.Property(employee => employee.Name).HasMaxLength(50).IsRequired(true);
            builder.Property(employee => employee.Surname).HasMaxLength(50).IsRequired(true);
            builder.Property(employee => employee.TypeEmployee).HasMaxLength(14).IsRequired(true);
            builder.Property(employee => employee.SalaryPerMonth).HasMaxLength(9);
        }
    }
}
