using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SkiResort.Data.Models
{
    public class Hike
    {
        public Hike()
        {
                    
        }
        public Hike(string startPoint, string endPoint, decimal length, DateTime startDate)
        {
            this.StartPoint = startPoint;
            this.EndPoint = endPoint;
            this.Length = length;
            this.StartDate = startDate;
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string StartPoint { get; set; }

        [Required]
        public string EndPoint { get; set; }

        [Required]
        public decimal Length { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        public int Rate { get; set; }
        
    }
}
