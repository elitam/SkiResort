
using SkiResort.Business;
using SkiResort.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SkiResort.Views
{
    class DisplayLift
    {
        public DisplayLift()
        {
            liftController = new LiftController();
            InputLifts();
        }



        private LiftController liftController;

       

        private void ShowMenuLifts()
        {
            Console.WriteLine("         ┌────────────────────────────────┐");
            Console.WriteLine("         │             LIFTS!             │");
            Console.WriteLine("┌────────└────────────────────────────────┘────────┐");
            Console.WriteLine("│                      MENU:                       │   ");
            Console.WriteLine("│                                                  │   ");
            Console.WriteLine("│       0. BACK                2. DELETE           │   ");
            Console.WriteLine("│                                                  │   ");
            Console.WriteLine("│       1. ADD                 3. LIST ALL         │   ");
            Console.WriteLine("│                                                  │   ");
            Console.WriteLine("└──────────────────────────────────────────────────┘");
        }

        private void InputLifts()
        {
            var operation = -1;
            do
            {
                ShowMenuLifts();
                operation = int.Parse(Console.ReadLine());
                switch (operation)
                {
                    case 0:
                        Exit();
                        break;
                    case 1:
                        Add();
                        break;
                    case 2:
                        Delete();
                        break;
                    case 3:
                        ListAll();
                        break;
                 

                }

            } while (true);
        }

        private void Exit()
        {
            DisplayInfo displayInfo = new DisplayInfo();

        }

        private void Delete()
        {
            Console.WriteLine("Enter ID to delete: ");
            int id = int.Parse(Console.ReadLine());
            Lift lift = new Lift();
            liftController.Delete(id);
            Console.WriteLine("Done!");
        }

     

        private void Add()
        {
            //name, decimal length, decimal verticalRise, string workingHours, bool nightSkiing
            Lift lift = new Lift();
            Console.WriteLine("Enter name: ");
            lift.Name = Console.ReadLine();
            Console.WriteLine("Enter lenght: ");
            lift.Length = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter vertical rise : ");
            lift.VerticalRise = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter working hours: ");
            lift.WorkingHours = Console.ReadLine();
            Console.WriteLine("Is it working at night: ");
            lift.NightSkiing = bool.Parse(Console.ReadLine());

            this.liftController.Add(lift);
        }

        private void ListAll()
        {

            Console.WriteLine(new string('-', 40));
            Console.WriteLine(new string(' ', 18) + "LIFTS" + new string(' ', 18));
            Console.WriteLine(new string('-', 40));

            var lifts = this.liftController.GetAll();
            
            foreach (var lift in lifts)
            {
                Console.WriteLine($"{lift.Id} - {lift.Name} is {lift.Length}m long with {lift.VerticalRise}m vertical rise " +
                    $"and it works {lift.WorkingHours}");
            }
        }




    }
}
