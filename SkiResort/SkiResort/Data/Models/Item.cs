using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SkiResort.Data.Models
{
    public class Item
    {
        public Item(string name, decimal price, int quantity, double size, string gender)
        {
            Id = 0;
            Name = name;
            Price = price;
            Quantity = quantity;
            Size = size;
            Gender = gender;
            Status = "Not Rented";
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        public string Name { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public double Size { get; set; }

        [Required]
        public string Gender { get; set; }

        public string Status { get; set; }

    }
}
