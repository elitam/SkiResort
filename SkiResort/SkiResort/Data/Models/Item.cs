using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SkiResort.Data.Models
{
    public class Item
    {
        public Item()
        {
            this.Status = "Not Rented";
<<<<<<< HEAD
        }
        public Item(string name, decimal price, int quantity, string size, string gender)
        {
            this.Id = 0;
            this.Name = name;
            this.Price = price;
=======

        }
        public Item(int id, string name, decimal price, string size,string gender)
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
           
>>>>>>> 5b8a688afb28000f9d15563c0ade89958f34d7da
            this.Size = size;
            this.Gender = gender;
            this.Status = "Not Rented";
            this.RentalId = 1;
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        public string Name { get; set; }

        [Required]
        public decimal Price { get; set; }

<<<<<<< HEAD
=======
        

>>>>>>> 5b8a688afb28000f9d15563c0ade89958f34d7da
        [Required]
        public string Size { get; set; }

        [Required]
        public string Gender { get; set; }

        public Rental Rental { get; set; }
        
        public int? RentalId { get; set; }

        

        public string Status { get; set; }

        public Rental Rental { get; set; }

        public int? RentalId { get; set; }

    }
}
