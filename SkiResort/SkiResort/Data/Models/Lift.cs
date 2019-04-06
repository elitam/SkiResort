using System;
using System.Collections.Generic;
using System.Text;

namespace SkiResort.Data.Models
{
    public class Lift
    {
        public Lift(string name, decimal length, decimal vertical_Rise, string workingHours, bool nightSkiing)
        {
            this.Name = name;
            this.Length = length;
            this.Vertical_Rise = vertical_Rise;
            this.WorkingHours = workingHours;
            this.NightSkiing = nightSkiing;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Length { get; set; }
        public decimal Vertical_Rise { get; set; }
        public string WorkingHours { get; set; }
        public bool NightSkiing { get; set; }
    }
}
