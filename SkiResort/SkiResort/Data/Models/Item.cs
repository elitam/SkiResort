using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SkiResort.Data.Models
{
    public class Item
    {
        public Item(int id, string name, decimal price, int quantity, double size)
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
            this.quantity = quantity;
            this.size = size;
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        public string Name { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public int quantity { get; set; }

        [Required]
        public double size { get; set; }

    }
}
