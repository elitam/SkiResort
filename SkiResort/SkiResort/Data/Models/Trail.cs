using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SkiResort.Data.Models
{


    public class Trail

    {
        public Trail(string name, string type, string mode)
        {
            this.Name = name;
            this.Type = type;
            this.Mode = mode;

        }
       

        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Type { get; set; }

        [Required]
        public string Mode { get; set; }

        public int LiftId { get; set; }
    }
}
