using System;
using System.Collections.Generic;
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

        public int Id { get; set; }
        public string Type { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

    }
}
