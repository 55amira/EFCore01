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
    internal class CourseCongfiduration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> C)
        {
            C.HasKey(S => S.Id);
            C.Property(C => C.Description).IsRequired(false)
                                                         .HasColumnType("varchar")
                                                          .HasMaxLength(50);
            C.Property(C => C.Name).IsRequired()
                                                 .HasColumnType("varchar")
                                                          .HasMaxLength(50);
            C.Property(C => C.Duration).IsRequired();
            C.Property(C => C.TopicId).IsRequired();
        }
    }
}
