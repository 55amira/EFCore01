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
    internal class Course_InstConfiguration : IEntityTypeConfiguration<Course_Inst>
    {
        public void Configure(EntityTypeBuilder<Course_Inst> C)
        {
            C.HasKey(C => new { C.Course_Id, C.Int_Id });
            C.Property(C => C.evaluate).IsRequired();
        }
    }
}
