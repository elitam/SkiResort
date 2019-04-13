using SkiResort.Data;
using SkiResort.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SkiResort.Business
{
    public class LiftController
    {
        public SkiResortContext liftContext;


        public LiftController()
        {
            this.liftContext = new SkiResortContext();
        }

        public LiftController(SkiResortContext context)
        {
            this.liftContext = context;  
        }

        /// <summary>
        /// Gives all lifts from database.
        /// </summary>
        /// <returns>List of all hikes</returns>
        public List<Lift> GetAll()
        {
            return liftContext.Lifts.ToList();
        }

        /// <summary>
        /// Gives a lift from database by id.
        /// </summary>
        public Lift Get(int id)
        {
            var lift = this.liftContext.Lifts.FirstOrDefault(x => x.Id == id);
            return lift;
        }

        /// <summary>
        /// Adds a lift in database.
        /// </summary>
        public void Add(Lift lift)
        {

            this.liftContext.Lifts.Add(lift);
            this.liftContext.SaveChanges();
        }

        /// <summary>
        /// Deletes a lift from the database.
        /// </summary>
        public void Delete(int id)
        {
            var lift = this.Get(id);
            this.liftContext.Lifts.Remove(lift);
            this.liftContext.SaveChanges();

        }
    }
}
