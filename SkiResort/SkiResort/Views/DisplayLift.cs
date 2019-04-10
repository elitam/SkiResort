
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
            InputLifts();
            liftController = new LiftController();
        }



        private LiftController liftController;

        int closeOperation = 6;

        private void ShowMenuLifts()
        {
            Console.WriteLine("         ┌────────────────────────────────┐");
            Console.WriteLine("         │             LIFTS!             │");
            Console.WriteLine("┌────────└────────────────────────────────┘────────┐");
            Console.WriteLine("│                     MENU:                        │   ");
            Console.WriteLine("│      1. ADD                        4. UPDATE     │   ");
            Console.WriteLine("│                                                  │   ");
            Console.WriteLine("│      2. LISTALL                    5. DELETE     │   ");
            Console.WriteLine("│                                                  │   ");
            Console.WriteLine("│      3. FETCH                      6. EXIT       │   ");
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
                    case 1:
                        Add();
                        break;
                    case 2:
                        ListAll();
                        break;
                    case 3:
                        Fetch();
                        break;
                    case 4:
                        Update();
                        break;
                    case 5:
                        Delete();
                        break;
                    case 6:
                        Exit();
                        break;
                    default:
                        break;
                }

            } while (operation != closeOperation);
        }

        private void Exit()
        {
            Display display = new Display();

        }

        private void Delete()
        {
            Console.WriteLine("Enter ID to delete: ");
            int id = int.Parse(Console.ReadLine());
            Lift lift = new Lift();
            liftController.Delete(id);
            Console.WriteLine("Done!");
        }

        private void Update()
        {
            throw new NotImplementedException();
        }

        private void Fetch()
        {
            throw new NotImplementedException();
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
