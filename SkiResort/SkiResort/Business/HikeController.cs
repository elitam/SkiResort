using Microsoft.EntityFrameworkCore;
using SkiResort.Data;
using SkiResort.Data.Models;
using System;
using System.Collections.Generic;
<<<<<<< HEAD
using System.Drawing;
using System.Linq;
using System.Text;
using Console = Colorful.Console;
=======
using System.Linq;
using System.Text;
>>>>>>> 5b8a688afb28000f9d15563c0ade89958f34d7da

namespace SkiResort.Business
{
    public class HikeController
    {
        private SkiResortContext hikeContext;
        private RateController rateController;


<<<<<<< HEAD
=======

>>>>>>> 5b8a688afb28000f9d15563c0ade89958f34d7da
        public HikeController()
        {
            this.hikeContext = new SkiResortContext();
            this.rateController = new RateController();
<<<<<<< HEAD
=======
           
>>>>>>> 5b8a688afb28000f9d15563c0ade89958f34d7da
        }

        public HikeController(SkiResortContext context)
        {
            this.hikeContext = context;
            this.rateController = new RateController();
<<<<<<< HEAD
=======


>>>>>>> 5b8a688afb28000f9d15563c0ade89958f34d7da
        }

        /// <summary>
        /// Gives all hikes from database.
        /// </summary>
<<<<<<< HEAD
        /// <returns>a list of all hikes</returns>
        public List<Hike> GetAll()
        {
            return hikeContext.Hikes.ToList();

=======
        /// <returns>List of all hikes</returns>
        public List<Hike> GetAll()
        {
            return hikeContext.Hikes.ToList(); 
            
>>>>>>> 5b8a688afb28000f9d15563c0ade89958f34d7da
        }

        /// <summary>
        /// Gives a hikes from database by id.
        /// </summary>
        public Hike Get(int id)
        {
<<<<<<< HEAD
            var hike = new Hike();
            try
            {
                hike = this.hikeContext.Hikes.First(x => x.Id == id);               
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("Invalid id!", e, Color.Pink);
                
            }
            return hike;
        }

=======
            var hike = this.hikeContext.Hikes.FirstOrDefault(x => x.Id == id);
            return hike;
        }



>>>>>>> 5b8a688afb28000f9d15563c0ade89958f34d7da
        /// <summary>
        /// Adds a hike.
        /// </summary>
        public void Add(Hike hike)
        {
<<<<<<< HEAD
=======

>>>>>>> 5b8a688afb28000f9d15563c0ade89958f34d7da
            this.hikeContext.Hikes.Add(hike);
            this.hikeContext.SaveChanges();
        }

        /// <summary>
        /// Deletes a hike from the database.
        /// </summary>
        public void Delete(int id)
        {
            var hike = this.Get(id);
            this.hikeContext.Hikes.Remove(hike);
            this.hikeContext.SaveChanges();
<<<<<<< HEAD
        }

        /// <summary>
        /// Calculate the hike rate .
=======


        }

        /// <summary>
        /// Calculate the hike rate using method from RateController .
>>>>>>> 5b8a688afb28000f9d15563c0ade89958f34d7da
        /// </summary>
        public void CalculateRateHike(int id)
        {
            var hike = this.Get(id);
            rateController.CalculateRateForHike(hike);
<<<<<<< HEAD
        }

        /// <summary>
        /// Updates current values for a hike.
        /// </summary>
        public void Update(Hike hike)
        {
            var currHike = hikeContext.Hikes.Find(hike.Id);
            if (currHike != null)
            {
                hikeContext.Entry(currHike).CurrentValues.SetValues(hike);
                hikeContext.SaveChanges();
            }
            else
            {
                throw new InvalidOperationException("Hike does not exist");
            }
        }
    }
}
=======

        }

        /// <summary>
        /// This method updates the description of a hike chosen by the user.
        /// </summary>
        /// <param name="hike">The hike chosen by the user.</param>
        public void Update(Hike hike)
        {
            
            
                var currHike = hikeContext.Hikes.Find(hike.Id);
                if (currHike != null)
                {
                    hikeContext.Entry(currHike).CurrentValues.SetValues(hike);
                    hikeContext.SaveChanges();
                }
                else
                {
                    throw new InvalidOperationException("Hike does not exist");

                }
            
        }

      
    }
}
>>>>>>> 5b8a688afb28000f9d15563c0ade89958f34d7da
