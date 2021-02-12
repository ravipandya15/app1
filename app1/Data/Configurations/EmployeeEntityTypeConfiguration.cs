using app1.Data.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app1.Data.Configurations
{
    public class EmployeeEntityTypeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("Employee");
            builder.HasKey(p => p.EmployeeID);
            builder.Property(p => p.EmployeeID).HasColumnName("EmployeeID");
            builder.Property(p => p.EmployeeName).HasColumnName("EmployeeName");
            builder.Property(p => p.JoiningDate).HasColumnName("JoiningDate");
            builder.Property(p => p.BirthDate).HasColumnName("BirthDate");
            builder.Property(p => p.Designation).HasColumnName("Designation");
            builder.Property(p => p.Salary).HasColumnName("Salary");
        }
    }
}
