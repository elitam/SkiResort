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
            this.rateContext = new SkiResortContext();
        }

        public RateController(SkiResortContext context)
        {
            this.rateContext = context;
        }
        

        /// <summary>
        /// Gives all rates from database.
        /// </summary>
        /// <returns>a list of all hikes</returns>
        public List<Rate> GetAll()
        {
            return rateContext.Rates.ToList();
        }

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
        public int CalculateRateForHike(Hike hike)
        {
            var rates = GetAll();
            var result = 0;
            var ratesForCurrHike = rates.Where(r => r.HikeId == hike.Id).ToList();
            foreach (var rate in ratesForCurrHike)
            {
                result += rate.Stars;
            }
            if (ratesForCurrHike.Count ==0)
            {
                return result = 0;
            }
            else
            {
                return result / ratesForCurrHike.Count;
            }
           
            
        }

        /// <summary>
        /// Adds a rate.
        /// </summary>
        public void AddRate(Rate rate)
        {
            this.rateContext.Rates.Add(rate);
            this.rateContext.SaveChanges();
        }

    }
}
