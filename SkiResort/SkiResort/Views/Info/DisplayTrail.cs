using SkiResort.Business;
using SkiResort.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SkiResort.Views
{
    public class DisplayTrail
    {
        public DisplayTrail()
        {
            trailController = new TrailController();
            liftController = new LiftController();
            InputLifts();
        }



        private TrailController trailController;
        private LiftController liftController;




        private void ShowMenuLifts()
        {
            Console.WriteLine("         ┌────────────────────────────────┐");
            Console.WriteLine("         │            TRAILS!             │");
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
            Trail trail = new Trail();
            trailController.Delete(id);
            Console.WriteLine("Trail removed successfully!");
        }

        

        private void Add()
        {
            //string name, string type, string mode
            Trail trail = new Trail();
            Console.WriteLine("Enter name: ");
            trail.Name = Console.ReadLine();


            Console.WriteLine("Enter type: (Green/Blue/Red/Black)");
            var trailType = Console.ReadLine();
            ValidateType(trailType);
            trail.Type = trailType;
            
            Console.WriteLine("Enter mode : (Beginner/Intermediante/Advanced/Expert)");
            var trailMode = Console.ReadLine();
            ValidateMode(trailMode);
            trail.Mode = trailMode;
            
            Console.WriteLine("Enter lift id to access the trail: ");
            trail.LiftId = int.Parse(Console.ReadLine());


            this.trailController.Add(trail);
            Console.WriteLine("Trail added successfully!");
        }

        private void ListAll()
        {

            Console.WriteLine(new string('-', 40));
            Console.WriteLine(new string(' ', 18) + "TRAILS" + new string(' ', 18));
            Console.WriteLine(new string('-', 40));

            var trails = this.trailController.GetAll();
           
            
            foreach (var trail in trails)
            {
                
                var liftId = trail.LiftId;
                var lift = this.liftController.Get(liftId);


               
                Console.WriteLine($"{trail.Id} - {trail.Name} is {trail.Type} and it is suitable for {trail.Mode} skiers.");
                Console.WriteLine($"Änd you can access it by the {lift.Name} .");
            }
        }


        private void ValidateType(string trailType)
        {
            while (trailType != "Green" && trailType != "Blue" && trailType != "Red" && trailType != "Black")
            {
                Console.WriteLine("Invalid trail type. Only Green, Blue, Red Or Black available !");
                Console.WriteLine("Enter type: (Green/Blue/Red/Black)");
                trailType = Console.ReadLine();
            }
        }

        private void ValidateMode(string trailMode)
        {
            while (trailMode != "Beginner" && trailMode != "Intermediante" && trailMode != "Advanced" && trailMode != "Expert")
            {
                Console.WriteLine("Invalid trail mode. Only Beginner, Intermediante, Advanced or Expert available!");
                Console.WriteLine("Enter mode: (Beginner/Intermediante/Advanced/Expert)");
                trailMode = Console.ReadLine();
            }
        }



    }
}
