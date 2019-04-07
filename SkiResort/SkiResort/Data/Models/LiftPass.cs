using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SkiResort.Data.Models
{
    public abstract class LiftPass
    {
        protected LiftPass(string type, DateTime startDate, DateTime endDate)
        {
            this.Type = type;
            this.StartDate = startDate;
            this.EndDate = endDate;
        }
        [Key]
        public int Id { get; set; }

        [Required]
        public string Type { get; set; }

        [Required]
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

    }
}
