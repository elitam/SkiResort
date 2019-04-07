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

        public Trail()
        {
                
        }
>>>>>>> ccbde461353ae3845e9794f2a49ededd741c4790
        public Trail(string name, string type, string mode)
        {
            this.Name = name;
            this.Type = type;
            this.Mode = mode;

        }
<<<<<<< HEAD
       
=======

        //public enum TrailsType { Green, Blue, Red, Black }
       // public enum TrailsMode { Beginners, Easy, Intermediate, Experts_only }
>>>>>>> ccbde461353ae3845e9794f2a49ededd741c4790

        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Type { get; set; }

        [Required]
        public string Mode { get; set; }

        [ForeignKey("FK_Lifts_Id")]
        
        public int? LiftId { get; set; }
    }
}
