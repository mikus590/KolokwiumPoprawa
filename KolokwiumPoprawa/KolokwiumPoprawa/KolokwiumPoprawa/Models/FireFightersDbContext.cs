using KolokwiumPoprawa.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KolokwiumPoprawa.Models
{
    public class FireFightersDbContext : DbContext
    {

        public DbSet<FireFighter> FireFighter { get; set; }
        public DbSet<Action> Action { get; set; }
        public DbSet<FireTruck> FireTruck { get; set; }
        public DbSet<FireTruck_Action> FireTruck_Action { get; set; }
        public DbSet<FireFighter_Action> FireFighter_Action { get; set; }
        public FireFightersDbContext()
        {
        }

        public FireFightersDbContext(DbContextOptions<FireFightersDbContext> options)
            : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfiguration(new FireTruck());
            modelBuilder.ApplyConfiguration(new FireFightersConfiguration());
            
            modelBuilder.ApplyConfiguration(new FireTruckConfiguration());
            modelBuilder.ApplyConfiguration(new FireFighterActionConfiguration());
        }



    }
}
