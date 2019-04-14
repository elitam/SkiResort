using SkiResort.Business;
using SkiResort.Data.Models;
using System;
using System.Collections.Generic;
<<<<<<< HEAD
using System.Drawing;
using System.Linq;
using System.Text;
using Console = Colorful.Console;
=======
using System.Text;
>>>>>>> 5b8a688afb28000f9d15563c0ade89958f34d7da

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

<<<<<<< HEAD
        private TrailController trailController;
        private LiftController liftController;

        private void ShowMenuTrails()
        {
            Console.WriteLine();
=======


        private TrailController trailController;
        private LiftController liftController;




        private void ShowMenuLifts()
        {
>>>>>>> 5b8a688afb28000f9d15563c0ade89958f34d7da
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
<<<<<<< HEAD
            Console.WriteLine();

=======
>>>>>>> 5b8a688afb28000f9d15563c0ade89958f34d7da
        }

        private void InputLifts()
        {
<<<<<<< HEAD
            ShowMenuTrails();
            var operation = -1;
            do
            {
                try
                {
                    operation = int.Parse(Console.ReadLine());

                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input!", Color.Salmon);
                }
=======
            var operation = -1;
            do
            {
                ShowMenuLifts();
                operation = int.Parse(Console.ReadLine());
>>>>>>> 5b8a688afb28000f9d15563c0ade89958f34d7da
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
<<<<<<< HEAD
            ListAll();
            Trail trail = GetById();
            do
            {
                trail = GetById();
            } while (trail.Name == null);

            trailController.Delete(trail.Id);
            Console.WriteLine("\nTrail removed successfully!", Color.LightGreen);
        } //validated


        private void Add()
        {
            Trail trail = new Trail();
            Console.WriteLine("\nEnter name: ");
            trail.Name = Console.ReadLine();

            AddType(trail);

            AddMode(trail);

            AddLiftId(trail);

            this.trailController.Add(trail);
            Console.WriteLine("\nTrail added successfully!", Color.LightGreen);

        }

        private void AddLiftId(Trail trail)
        {
            bool isIdValid = false;
            ListAllLifts();
            while (isIdValid == false)
            {
                Console.WriteLine("\nEnter lift id to access the trail: ");
                int value;

                if (!int.TryParse(Console.ReadLine(), out value))
                {
                    Console.WriteLine("Input must be a number!", Color.Pink);
                }
                else
                {
                    int id = value;
                    Lift lift = liftController.Get(id);
                    if (lift.Name != null)
                    {
                        isIdValid = true;
                        trail.LiftId = id;
                    }
                }
            }
        }

        private void AddMode(Trail trail)
        {
            string mode;
            int i = 1;
            do
            {
                if (i > 1)
                {
                    Console.WriteLine("Invalid input!", Color.Pink);
                }
                Console.WriteLine("\nEnter mode : (Beginner/Intermediante/Advanced/Expert)");
                mode = Console.ReadLine();
                i++;
            } while (mode.ToLower() != "beginner" && mode.ToLower() != "intermediante" && mode.ToLower() != "advanced" && mode.ToLower() != "expert");
            trail.Mode = FirstCharToUpper(mode);
        }

        private void AddType(Trail trail)
        {
            string type;
            int i = 1;
            do
            {
                if (i > 1)
                {
                    Console.WriteLine("Invalid input!", Color.Pink);
                }
                Console.WriteLine("\nEnter type: (Green/Blue/Red/Black)");
                type = Console.ReadLine();
                i++;
            } while (type.ToLower() != "green" && type.ToLower() != "blue" && type.ToLower() != "red" && type.ToLower() != "black");
            trail.Type = FirstCharToUpper(type);
=======
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
>>>>>>> 5b8a688afb28000f9d15563c0ade89958f34d7da
        }

        private void ListAll()
        {

            Console.WriteLine(new string('-', 40));
            Console.WriteLine(new string(' ', 18) + "TRAILS" + new string(' ', 18));
            Console.WriteLine(new string('-', 40));

            var trails = this.trailController.GetAll();
<<<<<<< HEAD


            foreach (var trail in trails)
            {

                var liftId = trail.LiftId;
                var lift = this.liftController.Get(liftId);

                //Console.WriteLine($"{trail.Id} - {trail.Name} is {trail.Type} and it is suitable for {trail.Mode} skiers.");
                //Console.WriteLine($"Änd you can access it by the {lift.Name} .");


                string text = "{0}. {1} is {2} and it is suitable for {3} skiers.\nAnd you can access it by the {4}.";
                string[] data = new string[]
                {
                     trail.Id.ToString(),
                     trail.Name,
                     trail.Type,
                     trail.Mode,
                     lift.Name
                };

                Console.WriteLineFormatted(text, Color.Salmon, Color.White, data);
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

        private Trail GetById()
        {
            Trail trail = new Trail();
            Console.WriteLine("\nEnter ID :");

            int value;
            if (!int.TryParse(Console.ReadLine(), out value))
            {
                Console.WriteLine("Input must be a number!", Color.Pink);
            }
            else
            {
                int id = value;
                trail = trailController.Get(id);
            }

            return trail;
        }

        private string FirstCharToUpper(string input)
        {
            switch (input)
            {
                case null: throw new ArgumentNullException(nameof(input));
                case "": throw new ArgumentException($"{nameof(input)} cannot be empty", nameof(input));
                default: return input.First().ToString().ToUpper() + input.Substring(1);
            }
        }
        private void ListAllLifts()
        {

            Console.WriteLine(new string('-', 40));
            Console.WriteLine(new string(' ', 18) + "LIFTS" + new string(' ', 18));
            Console.WriteLine(new string('-', 40));

            var lifts = this.liftController.GetAll();

            foreach (var lift in lifts)
            {
                //Console.WriteLine($"{lift.Id} - {lift.Name} is {lift.Length}m long with {lift.VerticalRise}m vertical rise " +
                //$"and it works {lift.WorkingHours}");
                string text = "{0}: {1} is {2} m long with {3}m vertical rise and it works {4}";
                string[] data = new string[]
                {
                     lift.Id.ToString(),
                     lift.Name,
                     lift.Length.ToString(),
                     lift.VerticalRise.ToString(),
                     lift.WorkingHours
                };

                Console.WriteLineFormatted(text, Color.Salmon, Color.White, data);
            }

        }
    }
}
=======
           
            
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
>>>>>>> 5b8a688afb28000f9d15563c0ade89958f34d7da
