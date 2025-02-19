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
    internal class InstructorConfiguration : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> I)
        {
            I.HasKey(I => I.Id);
            I.Property(I => I.Name).IsRequired().HasColumnType("nvarchar")
                                                   .HasMaxLength(50);
           // I.Property(I => I.DepartmentId).IsRequired();
            I.Property(I => I.Bouns).IsRequired();
            I.Property(I => I.Salary).IsRequired();
            I.Property(I => I.HourRate).IsRequired();
        }
    }
}
