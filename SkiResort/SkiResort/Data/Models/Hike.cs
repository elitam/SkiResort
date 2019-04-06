using System;
using System.Collections.Generic;
using System.Text;

namespace SkiResort.Data.Models
{
    public class Hike
    {
        public Hike(string startPoint, string endPoint, decimal length, DateTime startDate)
        {
            this.StartPoint = startPoint;
            this.EndPoint = endPoint;
            this.Length = length;
            this.StartDate = startDate;
        }

        public int Id { get; set; }
        public string StartPoint { get; set; }
        public string EndPoint { get; set; }
        public decimal Length { get; set; }
        public DateTime StartDate { get; set; }
        public string Rate { get; set; }
        
    }
}
