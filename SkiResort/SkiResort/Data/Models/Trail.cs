using System;
using System.Collections.Generic;
using System.Text;

namespace SkiResort.Data.Models
{
   

    public class Trail

    {
        public Trail(string name, TrailsType type, TrailsMode mode)
        {
            this.Name = name;
            this.Type = type;
            this.Mode = mode;
           
        }

        public enum TrailsType { Green, Blue, Red, Black }
        public enum TrailsMode { Beginners, Easy, Intermediate, Experts_only }

        public int Id { get; set; }
        public string Name { get; set; }
        public TrailsType Type { get; set; }
        public TrailsMode Mode { get; set; }
        public int LiftId { get; set; }
    }
}
