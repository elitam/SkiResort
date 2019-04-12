
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
            Console.WriteLine("│       0. BACK                2. REMOVE           │   ");
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
                        Remove();
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

        private void Remove()
        {
            this.ListAll();
            Console.WriteLine("Enter ID to delete: ");
            int id = int.Parse(Console.ReadLine());
            Lift lift = new Lift();
            liftController.Delete(id);
            Console.WriteLine("Lift removed successfully!");
        }



        private void Add()
        {
            
            Lift lift = new Lift();
            Console.WriteLine("Enter name: ");
            lift.Name = Console.ReadLine();
            Console.WriteLine("Enter lenght: ");
            lift.Length = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter vertical rise : ");
            lift.VerticalRise = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter working hours: ");
            lift.WorkingHours = Console.ReadLine();
            Console.WriteLine("Is it working at night: (True/False) ");
            var liftNightSkiing = Console.ReadLine();
            liftNightSkiing = ValidateBoolean(liftNightSkiing);
            lift.NightSkiing = bool.Parse(liftNightSkiing);
            this.liftController.Add(lift);
            Console.WriteLine("Lift added successfully!");

        }
        
        // Validating if lift night skiing if true of false to parse it to Boolean
        private string ValidateBoolean(string liftNightSkiing)
        {
            while (liftNightSkiing.ToLower() != "true" && liftNightSkiing.ToLower() != "false")
            {
                Console.WriteLine("Invalid command. Enter True or False!");
                Console.WriteLine("Is it working at night: (True/False) ");
                liftNightSkiing = Console.ReadLine();
            }
            return liftNightSkiing;
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
