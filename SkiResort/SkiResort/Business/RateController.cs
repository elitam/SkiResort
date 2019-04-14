using SkiResort.Data;
using SkiResort.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SkiResort.Business
{
    public class RateController
    {
        public SkiResortContext rateContext;

        public RateController()
        {
<<<<<<< HEAD
            rateContext = new SkiResortContext();
        }

=======
            this.rateContext = new SkiResortContext();
        }

        public RateController(SkiResortContext context)
        {
            this.rateContext = context;
        }
        

>>>>>>> 5b8a688afb28000f9d15563c0ade89958f34d7da
        /// <summary>
        /// Gives all rates from database.
        /// </summary>
        /// <returns>a list of all hikes</returns>
        public List<Rate> GetAll()
        {
            return rateContext.Rates.ToList();
        }
<<<<<<< HEAD
        public Lift Get(int id)
        {
            var rate = this.rateContext.Lifts.FirstOrDefault(x => x.Id == id);
            return rate;
        }



        /// <summary>
        /// Calculate the average rate for a hike.
        /// </summary>
=======

        /// <summary>
        /// Gives a rate from database by id.
        /// </summary>  
        public Rate Get(int id)
        {
            var rate = this.rateContext.Rates.FirstOrDefault(x => x.Id == id);
            return rate;
        }

        
        /// <summary>
        /// This method calculates the rating of an existing hike.
        /// If there's more than one rating for a this hike the method calculates the average.
        /// </summary>
        /// <param name="hike">The hike chosen by the user.</param>
        /// <returns>Returns the average of ratings for a hike chosen by the user.</returns>
>>>>>>> 5b8a688afb28000f9d15563c0ade89958f34d7da
        public int CalculateRateForHike(Hike hike)
        {
            var rates = GetAll();
            var result = 0;
            var ratesForCurrHike = rates.Where(r => r.HikeId == hike.Id).ToList();
            foreach (var rate in ratesForCurrHike)
            {
                result += rate.Stars;
            }
<<<<<<< HEAD
            if (ratesForCurrHike.Count == 0)
=======
            if (ratesForCurrHike.Count ==0)
>>>>>>> 5b8a688afb28000f9d15563c0ade89958f34d7da
            {
                return result = 0;
            }
            else
            {
                return result / ratesForCurrHike.Count;
            }
<<<<<<< HEAD


=======
           
            
>>>>>>> 5b8a688afb28000f9d15563c0ade89958f34d7da
        }

        /// <summary>
        /// Adds a rate.
        /// </summary>
        public void AddRate(Rate rate)
        {
<<<<<<< HEAD

=======
>>>>>>> 5b8a688afb28000f9d15563c0ade89958f34d7da
            this.rateContext.Rates.Add(rate);
            this.rateContext.SaveChanges();
        }

    }
<<<<<<< HEAD
}
=======
}
>>>>>>> 5b8a688afb28000f9d15563c0ade89958f34d7da
