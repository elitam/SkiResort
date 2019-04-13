using SkiResort.Data;
using SkiResort.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace SkiResort.Business
{

    public class LiftPassController
    {
        public const double KidsDiscount = 0.5;
        public const double StudentsAndRetieredDiscount = 0.7;

        public SkiResortContext liftPassContext;

        public LiftPassController()
        {
            this.liftPassContext = new SkiResortContext();
        }
        public LiftPassController(SkiResortContext context)
        {
            this.liftPassContext = context;
        }

        public List<LiftPass> GetAll()
        {
            return liftPassContext.liftPasses.ToList();
        }

        internal double CalculatePrice(LiftPass liftPass) 
        {
            double price = liftPass.Price;

            switch (liftPass.Type)
            {
                case "Kid":
                    price *= KidsDiscount;
                    break;
                case "Student":
                    price *= StudentsAndRetieredDiscount;
                    break;
                case "Retired":
                    price *= StudentsAndRetieredDiscount;
                    break;
                default:
                    break;
            }
            return price;

        }


        internal LiftPass GetByType(int type)
        {
            var liftPass = this.liftPassContext.liftPasses.First(l => l.Id == type);
            return liftPass;
        }
       
    }
}
