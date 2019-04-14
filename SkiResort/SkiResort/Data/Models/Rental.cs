using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using static SkiResort.Data.Models.Item;

namespace SkiResort.Data.Models
{
    public class Rental
    {

        public Rental()
        {

        }
<<<<<<< HEAD
        public Rental(List<Item> items, string name)
        {
            this.Items = items;
            this.Name = name;
        }

       
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
       
        public ICollection<Item> Items { get; set; }

        

    }
}
=======
        public Rental(List<Item> items)
        {
            this.Items = items;
        }

        // PROPERTIES
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Item> Items { get; set; }
        

    }
}
>>>>>>> 5b8a688afb28000f9d15563c0ade89958f34d7da
