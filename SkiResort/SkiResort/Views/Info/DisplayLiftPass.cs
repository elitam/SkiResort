using SkiResort.Business;
using SkiResort.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SkiResort.Views.Info
{
    public class DisplayLiftPass
    {
        public DisplayLiftPass()
        {
            liftPassController = new LiftPassController();
            InputHikes();
        }



        private LiftPassController liftPassController;



        private void ShowMenuHikes()
        {

            Console.WriteLine();
            Console.WriteLine("         ┌────────────────────────────────┐");
            Console.WriteLine("         │           LIFT PASSES!         │");
            Console.WriteLine("┌────────└────────────────────────────────┘────────┐");
            Console.WriteLine("│                      MENU:                       │   ");
            Console.WriteLine("│                                                  │   ");
            Console.WriteLine("│                     0. BACK                      │   ");
            Console.WriteLine("│                                                  │   ");
            Console.WriteLine("│        1. BUY               2. SHOW ALL TYPES    │   ");
            Console.WriteLine("│                                                  │   ");
            Console.WriteLine("└──────────────────────────────────────────────────┘");
            Console.WriteLine();
        }

        public List<LiftPass> boughtPasses = new List<LiftPass>();


        private void InputHikes()
        {
            var operation = -1;
            do
            {
                ShowMenuHikes();
                operation = int.Parse(Console.ReadLine());
                switch (operation)
                {
                    case 0:
                        Back();
                        break;
                    case 1:
                        Buy();
                        break;
                    case 2:
                        ListAllTypes();
                        break;


                }

            } while (true);
        }

        private void ListAllTypes()
        {
            Console.WriteLine(new string('-', 40));
            Console.WriteLine(new string(' ', 15) + "LIFT PASSES" + new string(' ', 18));
            Console.WriteLine(new string('-', 40));
            Console.WriteLine();

            var liftPasses = this.liftPassController.GetAll();

            var i = 1;
            foreach (var liftPass in liftPasses)
            {

                Console.WriteLine($" {i}.  {liftPass.Description} -- {liftPass.Price} lv");
                Console.WriteLine();
                i++;
            }

            Console.WriteLine("┌──────────────────────────────────────────────────┐");
            Console.WriteLine("│            KIDS get 50% dicount !!!              │");
            Console.WriteLine("│     STUDENTS and RETIRED get 30% dicount !!!     │");
            Console.WriteLine("└──────────────────────────────────────────────────┘");

        }




        private void Buy()
        {
            ListAllTypes();
            Console.WriteLine("Selects type of pass: (1 ... 10)");
            var type = int.Parse(Console.ReadLine());
            LiftPass liftPass = liftPassController.GetByType(type);

            Console.WriteLine("Are you a (Adult / Kid / Student / Retired):");
            var typeOfPerson = Console.ReadLine();

            liftPass.Type = typeOfPerson;

            var price = liftPassController.CalculatePrice(liftPass);
            Console.WriteLine($"It costs {price} lv. ");
            boughtPasses.Add(liftPass);
            Console.WriteLine();
            Console.WriteLine(new string('─', 22));
            Console.WriteLine("   You have bought:");
            Console.WriteLine(new string('─', 22));
            foreach (var pass in boughtPasses)
            {
                Console.WriteLine($"   {pass.Description} for {pass.Type} ");
                Console.WriteLine();
            }



        }

        private void Back()
        {
            DisplayInfo displayInfo = new DisplayInfo();

        }
    }
}