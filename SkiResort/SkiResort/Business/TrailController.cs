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
    public class TrailController
    {
        private SkiResortContext trailContext;

<<<<<<< HEAD

=======
       
>>>>>>> 5b8a688afb28000f9d15563c0ade89958f34d7da
        public TrailController()
        {
            this.trailContext = new SkiResortContext();
        }
<<<<<<< HEAD
=======

>>>>>>> 5b8a688afb28000f9d15563c0ade89958f34d7da
        public TrailController(SkiResortContext context)
        {
            this.trailContext = context;
        }

<<<<<<< HEAD
=======
        /// <summary>
        /// Gives all trails from database.
        /// </summary>
        /// <returns> List of all hikes</returns>
>>>>>>> 5b8a688afb28000f9d15563c0ade89958f34d7da
        public List<Trail> GetAll()
        {
            return trailContext.Trails.ToList();
        }

<<<<<<< HEAD
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

=======
        /// <summary>
        /// Gives a trail from database by id.
        /// <param name="id">The id chosen by the user.</param>
        /// </summary>
        public Trail Get(int id)
        {
            var trail = this.trailContext.Trails.FirstOrDefault(x => x.Id == id);
            return trail;
        }

        /// <summary>
        /// Adds a trail in database.
        /// <param name="trail">The trail chosen by the user.</param>
        /// </summary>
>>>>>>> 5b8a688afb28000f9d15563c0ade89958f34d7da
        public void Add(Trail trail)
        {

            this.trailContext.Trails.Add(trail);
            this.trailContext.SaveChanges();
        }

<<<<<<< HEAD
=======
        /// <summary>
        /// Deletes a trail from the database.
        /// </summary>
>>>>>>> 5b8a688afb28000f9d15563c0ade89958f34d7da
        public void Delete(int id)
        {
            var trail = this.Get(id);
            this.trailContext.Trails.Remove(trail);
            this.trailContext.SaveChanges();

        }




    }
<<<<<<< HEAD
}
=======
}
>>>>>>> 5b8a688afb28000f9d15563c0ade89958f34d7da
