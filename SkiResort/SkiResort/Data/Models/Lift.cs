﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SkiResort.Data.Models
{
    public class Lift
    {
        public Lift()
        {
                
        }
<<<<<<< HEAD
    
=======
>>>>>>> 5b8a688afb28000f9d15563c0ade89958f34d7da
        public Lift(string name, decimal length, decimal verticalRise, string workingHours, bool nightSkiing)
        {
            this.Name = name;
            this.Length = length;
            this.VerticalRise = verticalRise;
            this.WorkingHours = workingHours;
            this.NightSkiing = nightSkiing;
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public decimal Length { get; set; }

        [Required]
        public decimal VerticalRise { get; set; }

        [Required]
        public string WorkingHours { get; set; }

        [Required]
        public bool NightSkiing { get; set; }
    }
}
