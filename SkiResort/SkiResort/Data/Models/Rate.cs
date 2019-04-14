using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SkiResort.Data.Models
{
    public class Rate
    {
        public Rate()
        {
<<<<<<< HEAD

        }
        public Rate(int stars, int hikeId)
        {
            Stars = stars;
            // Hike = hike;
            HikeId = hikeId;
=======
                
        }
        public Rate(int stars, int hikeId)
        {
            this.Stars = stars; 
            this.HikeId = hikeId;
>>>>>>> 5b8a688afb28000f9d15563c0ade89958f34d7da
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(5)]
        public int Stars { get; set; }

        public Hike Hike { get; set; }

        public int HikeId { get; set; }


    }
<<<<<<< HEAD
}
=======
}
>>>>>>> 5b8a688afb28000f9d15563c0ade89958f34d7da
