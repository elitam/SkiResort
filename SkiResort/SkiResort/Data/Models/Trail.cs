using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public TrailsType Type { get; set; }

        [Required]
        public TrailsMode Mode { get; set; }

        public int LiftId { get; set; }
    }
}
