using KolokwiumPoprawa.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KolokwiumPoprawa.Configurations
{
    public class FireTruckConfiguration : IEntityTypeConfiguration<FireTruck>
    {
        public void Configure(EntityTypeBuilder<FireTruck> builder)
        {
            builder.HasKey(e => e.IdFireTruck).HasName("FireTruck_pk");
            builder.Property(e => e.SpecialEquipment).HasColumnType("bit");
            builder.Property(e => e.OperationNumber).HasMaxLength(10);
        }
    }
}
