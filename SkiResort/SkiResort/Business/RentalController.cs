<<<<<<< HEAD
﻿using Microsoft.EntityFrameworkCore;
using SkiResort.Data;
using SkiResort.Data.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using Console = Colorful.Console;

=======
﻿using SkiResort.Data;
using SkiResort.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
>>>>>>> 5b8a688afb28000f9d15563c0ade89958f34d7da

namespace SkiResort.Business
{
    public class RentalController
    {
        public SkiResortContext rentalContext;

        public RentalController()
        {
            this.rentalContext = new SkiResortContext();
        }
        public RentalController(SkiResortContext context)
        {
            this.rentalContext = context;
        }

<<<<<<< HEAD
        internal Item GetItem(int id)
        {
            var item = new Item();
            try
            {
                item = this.rentalContext.Items.First(x => x.Id == id);
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("Invalid id!", e, Color.Pink);

            }
            return item;
        }

        public  List<Item> GetAllItems()
=======
        /// <summary>
        /// Gives a item from database by id.
        /// </summary>
        public Item GetItem(int id)
        {
            var item = this.rentalContext.Items.FirstOrDefault(x => x.Id == id);
            return item;
        }

        /// <summary>
        /// Gives all items from database.
        /// </summary>
        /// <returns>a list of all items</returns>
        public List<Item> GetAllItems()
>>>>>>> 5b8a688afb28000f9d15563c0ade89958f34d7da
        {
            return rentalContext.Items.ToList();
        }

<<<<<<< HEAD
        internal void Add(Item item)
=======
        /// <summary>
        /// Adds a item.
        /// </summary>
        public void Add(Item item)
>>>>>>> 5b8a688afb28000f9d15563c0ade89958f34d7da
        {
            this.rentalContext.Items.Add(item);
            this.rentalContext.SaveChanges();
        }

<<<<<<< HEAD
=======
        /// <summary>
        /// Removes a item from the database.
        /// </summary>
>>>>>>> 5b8a688afb28000f9d15563c0ade89958f34d7da
        internal void RemoveById(int id)
        {
            var item = this.GetItem(id);
            this.rentalContext.Items.Remove(item);
            this.rentalContext.SaveChanges();

        }

<<<<<<< HEAD
        internal void RentItem(int id)
=======
        /// <summary>
        /// Sets status of a item to Rented.
        /// </summary>
        public void RentItem(int id)
>>>>>>> 5b8a688afb28000f9d15563c0ade89958f34d7da
        {
            var item = this.GetItem(id);
            item.Status = "Rented";
            this.rentalContext.SaveChanges();
        }

<<<<<<< HEAD
        internal void ReturnItem(int id)
=======
        /// <summary>
        /// Sets status of a item to Not Rented.
        /// </summary>
        public void ReturnItem(int id)
>>>>>>> 5b8a688afb28000f9d15563c0ade89958f34d7da
        {
            var item = this.GetItem(id);
            item.Status = "Not Rented";
            this.rentalContext.SaveChanges();
        }
    }
<<<<<<< HEAD
}
=======
}
>>>>>>> 5b8a688afb28000f9d15563c0ade89958f34d7da
