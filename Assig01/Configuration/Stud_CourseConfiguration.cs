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
    internal class Stud_CourseConfiguration : IEntityTypeConfiguration<Stud_Course>
    {
        public void Configure(EntityTypeBuilder<Stud_Course> SC)
        {

            SC.HasKey(SC => new { SC.Course_ID, SC.StudId });
            SC.Property(SC => SC.Grade).IsRequired();
        }
    }
}
