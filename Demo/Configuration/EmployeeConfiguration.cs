using Demo.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Configuration
{
    internal class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> E)
        {

            E.HasKey(E => E.Id);
                E.Property(E => E.Id).ValueGeneratedOnAdd(); 

            E.Property(E => E.Name)
                                           .IsRequired()
                                           .HasColumnName("EmployeeName")
                                           .HasColumnType("varchar")
                                           .HasMaxLength(50);

            E.Property(E => E.Age).IsRequired(false);

            E.Property(E => E.Salary).HasColumnType("money");

            E.Property(E => E.DateOfCreation).HasDefaultValueSql("GETDATE()");

        }
    }
}
