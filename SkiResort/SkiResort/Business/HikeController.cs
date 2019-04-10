using Microsoft.EntityFrameworkCore;
using SkiResort.Data;
using SkiResort.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SkiResort.Business
{
    public class HikeController
    {
        private SkiResortContext hikeContext;
        

        //Hike hike = new Hike();

        public HikeController()
        {
            this.hikeContext = new SkiResortContext();
            //hikeList = new List<Hike>();

        }

        //private List<Hike> hikeList;

        public List<Hike> GetAll()
        {
            return hikeContext.Hikes
                   .Include(r => r.StartPoint)
                   .Include(r => r.EndPoint)
                   .Include(x=>x.Length)
                   .Include(x=>x.StartDate)
                   .ToList();

            //return hikeContext.Hikes.ToList(); 

            //hikeList = hikeContext.Hikes.ToList();

            //if (hikeList.Count <0)
            //{
            //    throw new Exception("There is no hikes listed!");
            //}
            //else
            //{
            //    return hikeList;
            //}
        

            // return hikeContext.Hikes.OrderBy(x => x.Length).ToList();
            
            //using (hikeContext = new SkiResortContext())
            //{
            //    return hikeContext.Hikes.ToList();
            //}

        }

        public Hike Get(int id)
        {
            var hike = this.hikeContext.Hikes.FirstOrDefault(x => x.Id == id);
            return hike;
        }

        public void Add(Hike hike)
        {

            this.hikeContext.Hikes.Add(hike);
            this.hikeContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var hike = this.Get(id);
            this.hikeContext.Hikes.Remove(hike);
            this.hikeContext.SaveChanges();


        }

        //RateHike 
        public void CalculateRateHike(int id)
        {
            var hike = this.Get(id);

        }

        public void Update(Hike hike)
        {
            using (hikeContext = new SkiResortContext())
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
}
