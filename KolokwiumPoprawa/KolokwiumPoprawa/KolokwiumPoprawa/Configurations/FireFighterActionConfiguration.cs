using KolokwiumPoprawa.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KolokwiumPoprawa.Configurations
{
    public class FireFighterActionConfiguration : IEntityTypeConfiguration<FireFighter_Action>
    {
        public void Configure(EntityTypeBuilder<FireFighter_Action> builder)
        {
            builder.HasKey(e => new { e.IdAction, e.IdFireFighter });
            builder.HasOne(e => e.IdActionNavigation).WithMany().HasForeignKey(e => e.IdAction).HasConstraintName("IdAction");
            builder.HasOne(e => e.IdFireFighterNavigation).WithMany().HasForeignKey(e => e.IdFireFighter).HasConstraintName("IdFireFighter");
        }
    }
}
