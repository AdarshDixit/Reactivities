using Domain;
using Microsoft.EntityFrameworkCore;
using System;

namespace Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {

        }

        // To add migrations Add-Migrations Name -StartUp API -Project Persistence
        public DbSet<Value> Values { get; set; }


        // Seeding data for the use on the first time
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Value>().HasData(
                new Value { Id = 1, Name = "First value"}
                );
        }
    }
}
