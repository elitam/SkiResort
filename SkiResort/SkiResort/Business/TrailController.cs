using SkiResort.Data;
using SkiResort.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SkiResort.Business
{
    public class TrailController
    {
        private SkiResortContext trailContext;

       
        public TrailController()
        {
            this.trailContext = new SkiResortContext();
        }

        public TrailController(SkiResortContext context)
        {
            this.trailContext = context;
        }

        /// <summary>
        /// Gives all trails from database.
        /// </summary>
        /// <returns>a list of all hikes</returns>
        public List<Trail> GetAll()
        {
            return trailContext.Trails.ToList();
        }

        /// <summary>
        /// Gives a trail from database by id.
        /// </summary>
        public Trail Get(int id)
        {
            var trail = this.trailContext.Trails.FirstOrDefault(x => x.Id == id);
            return trail;
        }

        /// <summary>
        /// Adds a trail.
        /// </summary>
        public void Add(Trail trail)
        {

            this.trailContext.Trails.Add(trail);
            this.trailContext.SaveChanges();
        }

        /// <summary>
        /// Deletes a trail from the database.
        /// </summary>
        public void Delete(int id)
        {
            var trail = this.Get(id);
            this.trailContext.Trails.Remove(trail);
            this.trailContext.SaveChanges();

        }




    }
}
