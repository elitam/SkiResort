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
        public Rental(List<Item> items)
        {
            this.Items = items;
        }

        // PROPERTIES
        [Key]
        public int Id { get; set; }

        
        public ICollection<Item> Items { get; set; }
        

    }
}