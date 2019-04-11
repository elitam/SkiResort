using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SkiResort.Data.Models
{
    public class Rate
    {

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(5)]
        public int Stars { get; set; }

        public Hike Hike { get; set; }

        public int HikeId { get; set; }


    }
}
