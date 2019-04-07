using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SkiResort.Data.Models
{
    public class Lift
    {
<<<<<<< HEAD
=======
        public Lift()
        {
                
        }
>>>>>>> ccbde461353ae3845e9794f2a49ededd741c4790
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
