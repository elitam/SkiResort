using Microsoft.EntityFrameworkCore;
using SkiResort.Data;
using SkiResort.Data.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using Console = Colorful.Console;


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
        {
            return rentalContext.Items.ToList();
        }

        internal void Add(Item item)
        {
            this.rentalContext.Items.Add(item);
            this.rentalContext.SaveChanges();
        }

        internal void RemoveById(int id)
        {
            var item = this.GetItem(id);
            this.rentalContext.Items.Remove(item);
            this.rentalContext.SaveChanges();

        }

        internal void RentItem(int id)
        {
            var item = this.GetItem(id);
            item.Status = "Rented";
            this.rentalContext.SaveChanges();
        }

        internal void ReturnItem(int id)
        {
            var item = this.GetItem(id);
            item.Status = "Not Rented";
            this.rentalContext.SaveChanges();
        }
    }
}
