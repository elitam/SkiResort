﻿using Microsoft.EntityFrameworkCore;
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

        public virtual DbSet<Hike> Hikes { get; set; }
        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<Lift > Lifts { get; set; }
<<<<<<< HEAD
        public virtual DbSet<LiftPass> liftPasses { get; set; }
        public virtual DbSet<Trail> Trails { get; set; }
        public virtual DbSet<Rental> Rentals { get; set; }
        public virtual DbSet<Rate> Rates { get; set; }
        
=======
        public virtual DbSet<LiftPass> LiftPasses { get; set; }
        public virtual DbSet<Trail> Trails { get; set; }
        public virtual DbSet<Rate> Rates { get; set; }
        public virtual DbSet<Rental> Rentals { get; set; }


>>>>>>> 5b8a688afb28000f9d15563c0ade89958f34d7da


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

<<<<<<< HEAD
=======
           
>>>>>>> 5b8a688afb28000f9d15563c0ade89958f34d7da
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
