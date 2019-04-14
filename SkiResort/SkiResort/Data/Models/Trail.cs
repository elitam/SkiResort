using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SkiResort.Data.Models
{


    public class Trail

    {
<<<<<<< HEAD

=======
>>>>>>> 5b8a688afb28000f9d15563c0ade89958f34d7da

        public Trail()
        {
                
        }
<<<<<<< HEAD

=======
>>>>>>> 5b8a688afb28000f9d15563c0ade89958f34d7da
        public Trail(string name, string type, string mode)
        {
            this.Name = name;
            this.Type = type;
            this.Mode = mode;

        }

<<<<<<< HEAD
=======
      
>>>>>>> 5b8a688afb28000f9d15563c0ade89958f34d7da

        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Type { get; set; }

        [Required]
        public string Mode { get; set; }

        [ForeignKey("FK_Lifts_Id")]
        
<<<<<<< HEAD
        [Required]
=======
>>>>>>> 5b8a688afb28000f9d15563c0ade89958f34d7da
        public int LiftId { get; set; }
    }
}
