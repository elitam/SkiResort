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
        public DbSet<LiftPass> LiftPasses { get; set; }
        public DbSet<Trail> Trails { get; set; }
        public DbSet<Rate> Rates { get; set; }
        public DbSet<Rental> Rentals { get; set; }




        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

           
            modelBuilder.Entity<Item>().HasOne(rt => rt.Rental).WithMany(r => r.Items).HasForeignKey(rt => rt.RentalId);
            modelBuilder.Entity<Rate>().HasOne(rt => rt.Hike).WithMany(r => r.Rates).HasForeignKey(rt => rt.HikeId);


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
