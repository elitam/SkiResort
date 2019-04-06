using SkiResort.Business;
using SkiResort.Data.Models;
using System;

namespace SkiResort
{
    class Program
    {
        public static object HikeComtroller { get; private set; }

        static void Main(string[] args)
        {
            Hike hike = new Hike("hotel Rila", "Musala", 20, new DateTime(2019, 9, 8));
            HikeController hikeController = new HikeController();

            //hikeController.Add(hike);

            hikeController.Delete(2);
            

        }
    }
}
