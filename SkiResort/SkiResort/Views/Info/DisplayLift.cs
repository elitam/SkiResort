<<<<<<< HEAD
﻿using SkiResort.Business;
using SkiResort.Data.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Console = Colorful.Console;

=======
﻿
using SkiResort.Business;
using SkiResort.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
>>>>>>> 5b8a688afb28000f9d15563c0ade89958f34d7da

namespace SkiResort.Views
{
    class DisplayLift
    {
        public DisplayLift()
        {
            liftController = new LiftController();
            InputLifts();
        }

<<<<<<< HEAD
        private LiftController liftController;

        private void ShowMenuLifts()
        {
            Console.WriteLine();
=======


        private LiftController liftController;

       

        private void ShowMenuLifts()
        {
>>>>>>> 5b8a688afb28000f9d15563c0ade89958f34d7da
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
<<<<<<< HEAD
            Console.WriteLine();

=======
>>>>>>> 5b8a688afb28000f9d15563c0ade89958f34d7da
        }

        private void InputLifts()
        {
<<<<<<< HEAD
            ShowMenuLifts();
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
<<<<<<< HEAD

=======
                 
>>>>>>> 5b8a688afb28000f9d15563c0ade89958f34d7da

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
            Lift lift = GetById();
            do
            {
                lift = GetById();
            } while (lift.Name == null);

            liftController.Delete(lift.Id);
            Console.WriteLine("\nLift removed successfully!", Color.LightGreen);
        } // validated

        private void Add()
        {

            Lift lift = new Lift();

            Console.WriteLine("\nEnter name: ");
            lift.Name = Console.ReadLine();

            AddLenght(lift);

            AddVerticalRise(lift);

            Console.WriteLine("\nEnter working hours: ");
            lift.WorkingHours = Console.ReadLine();

            AddNightWorking(lift);

            this.liftController.Add(lift);
            Console.WriteLine("\nLift added successfully!", Color.LightGreen);
        } // validated

        private static void AddNightWorking(Lift lift)
        {
            string inputNight;
            bool valueNight;
            int n = 1;
            do
            {
                if (n > 1)
                {
                    Console.WriteLine("Invalid input!", Color.Pink);

                }
                Console.WriteLine("\nIs it working at night: (true/false)");
                inputNight = Console.ReadLine();
                n++;

            } while (!bool.TryParse(inputNight.ToLower(), out valueNight));
            lift.NightSkiing = valueNight;
        }

        private static void AddVerticalRise(Lift lift)
        {
            string inputRise;
            decimal valueRise;
            int c = 1;
            do
            {
                if (c > 1)
                {
                    Console.WriteLine("Invalid input!", Color.Pink);

                }
                Console.WriteLine("\nEnter lift vertical rise: ");
                inputRise = Console.ReadLine();
                c++;

            } while (!decimal.TryParse(inputRise, out valueRise));
            lift.VerticalRise = valueRise;
        }

        private static void AddLenght(Lift lift)
        {
            string input;
            decimal value;
            int i = 1;
            do
            {
                if (i > 1)
                {
                    Console.WriteLine("Invalid input!", Color.Pink);

                }
                Console.WriteLine("\nEnter lift lenght: ");
                input = Console.ReadLine();
                i++;

            } while (!decimal.TryParse(input, out value));
            lift.Length = value;
=======
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
>>>>>>> 5b8a688afb28000f9d15563c0ade89958f34d7da
        }

        private void ListAll()
        {

            Console.WriteLine(new string('-', 40));
            Console.WriteLine(new string(' ', 18) + "LIFTS" + new string(' ', 18));
            Console.WriteLine(new string('-', 40));

            var lifts = this.liftController.GetAll();
<<<<<<< HEAD

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

        private Lift GetById()
        {
            Lift lift = new Lift();
            Console.WriteLine("\nEnter ID :");

            int value;
            if (!int.TryParse(Console.ReadLine(), out value))
            {
                Console.WriteLine("Input must be a number!", Color.Pink);
            }
            else
            {
                int id = value;
                lift = liftController.Get(id);
            }

            return lift;
        }

    }
}
=======
            
            foreach (var lift in lifts)
            {
                Console.WriteLine($"{lift.Id} - {lift.Name} is {lift.Length}m long with {lift.VerticalRise}m vertical rise " +
                    $"and it works {lift.WorkingHours}");
            }
        }




    }
}
>>>>>>> 5b8a688afb28000f9d15563c0ade89958f34d7da
