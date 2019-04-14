<<<<<<< HEAD
﻿using Microsoft.EntityFrameworkCore;
using SkiResort.Data;
using SkiResort.Data.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using Console = Colorful.Console;
=======
﻿using SkiResort.Data;
using SkiResort.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
>>>>>>> 5b8a688afb28000f9d15563c0ade89958f34d7da

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
<<<<<<< HEAD
            this.liftContext = context;
=======
            this.liftContext = context;  
>>>>>>> 5b8a688afb28000f9d15563c0ade89958f34d7da
        }

        /// <summary>
        /// Gives all lifts from database.
        /// </summary>
<<<<<<< HEAD
        /// <returns>
        /// a list of all hikes
        /// </returns>
=======
        /// <returns>List of all hikes</returns>
>>>>>>> 5b8a688afb28000f9d15563c0ade89958f34d7da
        public List<Lift> GetAll()
        {
            return liftContext.Lifts.ToList();
        }

        /// <summary>
        /// Gives a lift from database by id.
        /// </summary>
        public Lift Get(int id)
        {
<<<<<<< HEAD
            var lift = new Lift();
            try
            {
                lift = this.liftContext.Lifts.First(x => x.Id == id);
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("Invalid id!", e, Color.Pink);

            }
=======
            var lift = this.liftContext.Lifts.FirstOrDefault(x => x.Id == id);
>>>>>>> 5b8a688afb28000f9d15563c0ade89958f34d7da
            return lift;
        }

        /// <summary>
<<<<<<< HEAD
        /// Adds a lift.
=======
        /// Adds a lift in database.
>>>>>>> 5b8a688afb28000f9d15563c0ade89958f34d7da
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
<<<<<<< HEAD
}
=======
}
>>>>>>> 5b8a688afb28000f9d15563c0ade89958f34d7da
