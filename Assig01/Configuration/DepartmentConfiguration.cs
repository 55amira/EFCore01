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
    internal class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> D)
        {
            D.HasKey(D => D.Id);
            D.Property(D => D.Name).IsRequired().HasColumnType("nvarchar")
                                                   .HasMaxLength(50);
            D.Property(D => D.Inst_ID).IsRequired();
            D.Property(D => D.HiringDate).HasDefaultValueSql("GETDAtE()");
        }
    }
}
