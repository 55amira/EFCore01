using Assig01.Enitity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assig01.Configuration
{
    internal class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> S)
        {
            S.HasKey(S => S.Id);

            S.Property(S => S.FName).IsRequired()
                                                    .HasColumnType("varchar")
                                                    .HasMaxLength(50);
            S.Property(S => S.LName).IsRequired()
                                                   .HasColumnType("varchar")
                                                   .HasMaxLength(50);
            S.Property(S => S.Age).IsRequired();
            S.Property(S => S.Address).IsRequired(false)
                                                     .HasColumnType("varchar")
                                                     .HasMaxLength(50);
            S.Property(S => S.DepartmentId).IsRequired();
        }
    }
}
