using SkiResort.Data;
using SkiResort.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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

        /// <summary>
        /// Gives a item from database by id.
        /// </summary>
        internal Item GetItem(int id)
        {
            var item = this.rentalContext.Items.FirstOrDefault(x => x.Id == id);
            return item;
        }

        /// <summary>
        /// Gives all items from database.
        /// </summary>
        /// <returns>a list of all items</returns>
        public List<Item> GetAllItems()
        {
            return rentalContext.Items.ToList();
        }

        /// <summary>
        /// Adds a item.
        /// </summary>
        internal void Add(Item item)
        {
            this.rentalContext.Items.Add(item);
            this.rentalContext.SaveChanges();
        }

        /// <summary>
        /// Removes a item from the database.
        /// </summary>
        internal void RemoveById(int id)
        {
            var item = this.GetItem(id);
            this.rentalContext.Items.Remove(item);
            this.rentalContext.SaveChanges();

        }

        /// <summary>
        /// Sets status of a item to Rented.
        /// </summary>
        internal void RentItem(int id)
        {
            var item = this.GetItem(id);
            item.Status = "Rented";
            this.rentalContext.SaveChanges();
        }

        /// <summary>
        /// Sets status of a item to Not Rented.
        /// </summary>
        internal void ReturnItem(int id)
        {
            var item = this.GetItem(id);
            item.Status = "Not Rented";
            this.rentalContext.SaveChanges();
        }
    }
}