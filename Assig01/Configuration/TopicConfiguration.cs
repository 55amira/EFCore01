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
    internal class TopicConfiguration : IEntityTypeConfiguration<Topic>
    {
        public void Configure(EntityTypeBuilder<Topic> T)
        {
            T.HasKey(T => T.Id);
            T.Property(T => T.Name).IsRequired().HasColumnType("nvarchar")
                                                   .HasMaxLength(50);
        }
    }
}
