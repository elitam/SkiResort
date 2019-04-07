using Microsoft.EntityFrameworkCore;
using SkiResort.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SkiResort.Data
{
   

    public class SkiResortContext:DbContext
    {
        public SkiResortContext()
        {

        }
        public SkiResortContext(DbContextOptions options)
                : base(options)
        {

        }

        public DbSet<Hike> Hikes { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Lift > Lifts { get; set; }
        public DbSet<LiftPass> liftPasses { get; set; }
        public DbSet<Trail> Trails { get; set; }
        public DbSet<Rental> Rentals { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

           //това нищо не ми работи и не знам защо
            //modelBuilder.Entity<Trail>().HasForeignKey(x => x.LiftId);
        }


        protected override void OnConfiguring
            (DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(Configuration.ConnectionString);
            }
            base.OnConfiguring(optionsBuilder);
        }
    }

   
}
