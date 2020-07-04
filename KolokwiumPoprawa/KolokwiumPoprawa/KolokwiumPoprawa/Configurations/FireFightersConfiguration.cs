using KolokwiumPoprawa.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KolokwiumPoprawa.Configurations
{
    public class FireFightersConfiguration : IEntityTypeConfiguration<FireFighter>
    {
        public void Configure(EntityTypeBuilder<FireFighter> builder)
        {
            builder.HasKey(e => e.IdFireFighter).HasName("FireFighter_pk");
            builder.Property(e => e.FirstName).IsRequired().HasMaxLength(30);
            builder.Property(e => e.LastName).IsRequired().HasMaxLength(30);
        }
    }
}
