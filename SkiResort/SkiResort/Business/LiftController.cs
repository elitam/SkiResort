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

        public List<Lift> GetAll()
        {
            return liftContext.Lifts.ToList();
        }

        public Lift Get(int id)
        {
            var lift = this.liftContext.Lifts.FirstOrDefault(x => x.Id == id);
            return lift;
        }

        public void Add(Lift lift)
        {

            this.liftContext.Lifts.Add(lift);
            this.liftContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var lift = this.Get(id);
            this.liftContext.Lifts.Remove(lift);
            this.liftContext.SaveChanges();

        }
    }
}
