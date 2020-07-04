using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KolokwiumPoprawa.Configurations
{
    public class ActionConfiguration : IEntityTypeConfiguration<Models.Action>
    {
        public void Configure(EntityTypeBuilder<Models.Action> builder)
        {

            builder.HasKey(e => e.IdAction).HasName("Action_pk");
            builder.Property(e => e.StartTime).HasColumnType("date");
            builder.Property(e => e.StartTime).HasColumnType("date");
            builder.Property(e => e.NeedSpecialEquipment).HasColumnType("bit");

        }
    }
}
