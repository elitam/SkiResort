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

        public List<Trail> GetAll()
        {
            return trailContext.Trails.ToList();
        }

        public Trail Get(int id)
        {
            var trail = this.trailContext.Trails.FirstOrDefault(x => x.Id == id);
            return trail;
        }

        public void Add(Trail trail)
        {

            this.trailContext.Trails.Add(trail);
            this.trailContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var trail = this.Get(id);
            this.trailContext.Trails.Remove(trail);
            this.trailContext.SaveChanges();

        }




    }
}
