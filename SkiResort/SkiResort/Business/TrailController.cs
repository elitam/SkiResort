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

        public List<Trail> GetAll()
        {
            return trailContext.Trails.ToList();
        }

        public Trail Get(int id)
        {
            var trail = new Trail();
            try
            {
                trail = this.trailContext.Trails.First(x => x.Id == id);
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("Invalid id!", e, Color.Pink);

            }
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