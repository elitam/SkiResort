using SkiResort.Business;
using SkiResort.Data.Models;
<<<<<<< HEAD
using SkiResort.Views.Hikes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using Console = Colorful.Console;
=======
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
>>>>>>> 5b8a688afb28000f9d15563c0ade89958f34d7da

namespace SkiResort.Views.Info
{
    public class DisplayLiftPass
    {
        public DisplayLiftPass()
        {
            liftPassController = new LiftPassController();
<<<<<<< HEAD
            InputLiftPass();
        }

        private LiftPassController liftPassController;

=======
            InputHikes();
        }



        private LiftPassController liftPassController;



>>>>>>> 5b8a688afb28000f9d15563c0ade89958f34d7da
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
<<<<<<< HEAD
       
        private void InputLiftPass()
        {
            ShowMenuHikes();
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


        private void InputHikes()
        {
            var operation = -1;
            do
            {
                ShowMenuHikes();
                operation = int.Parse(Console.ReadLine());
>>>>>>> 5b8a688afb28000f9d15563c0ade89958f34d7da
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

<<<<<<< HEAD
                 
=======

>>>>>>> 5b8a688afb28000f9d15563c0ade89958f34d7da
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
<<<<<<< HEAD
                
                //Console.WriteLine($" {i}.  {liftPass.Description} -- {liftPass.Price} lv");

                string text = "{0}.  {1} -- {2} lv";
                string[] data = new string[]
                {
                     i.ToString(),
                     liftPass.Description,
                     liftPass.Price.ToString()
                };
                Console.WriteLineFormatted(text, Color.LightSalmon, Color.White, data);
                //Console.WriteLine();
                i++;
            }
            System.Console.WriteLine();
            Console.WriteLine("┌──────────────────────────────────────────────────┐", Color.Yellow);
            Console.WriteLine("│            KIDS get 50% dicount !!!              │", Color.Yellow);
            Console.WriteLine("│     STUDENTS and RETIRED get 30% dicount !!!     │", Color.Yellow);
            Console.WriteLine("└──────────────────────────────────────────────────┘", Color.Yellow);

        }

        private void Buy()
        {
            ListAllTypes();

            LiftPass liftPass = SelectType();

            string type;
            int i = 1;
            do
            {
                if (i > 1)
                {
                    Console.WriteLine("Invalid input!", Color.Pink);
                }
                Console.WriteLine("\nAre you a (Adult / Kid / Student / Retired):");
                type = Console.ReadLine();
                i++;
            } while (type.ToLower() != "adult" && type.ToLower() != "kid" && type.ToLower() != "student" && type.ToLower() != "retired");
            liftPass.Type = FirstCharToUpper(type);


            var price = liftPassController.CalculatePrice(liftPass);
            Console.WriteLine($"\nIt costs {price} lv. ");
            boughtPasses.Add(liftPass);
            Console.WriteLine();
            Console.WriteLine(new string('-', 52) , Color.LightGoldenrodYellow);
            Console.WriteLine(new string(' ', 19) + "You have bought:", Color.LightGoldenrodYellow);
            Console.WriteLine(new string('-', 52), Color.LightGoldenrodYellow);

            foreach (var pass in boughtPasses)
            {
                Console.WriteLine(new string(' ', 18) + $"{pass.Description} for {pass.Type} ");
=======

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
>>>>>>> 5b8a688afb28000f9d15563c0ade89958f34d7da
                Console.WriteLine();
            }



        }

<<<<<<< HEAD
        private string FirstCharToUpper(string type)
        {
            switch (type)
            {
                case null: throw new ArgumentNullException(nameof(type));
                case "": throw new ArgumentException($"{nameof(type)} cannot be empty", nameof(type));
                default: return type.First().ToString().ToUpper() + type.Substring(1);
            }
        }

        private LiftPass SelectType()
        {
            string input;
            int value;
            int i = 1;
            do
            {
                if (i > 1)
                {
                    Console.WriteLine("Invalid input!", Color.Pink);

                }
                Console.WriteLine("\nSelects type of pass: (1 ... 10)");

                input = Console.ReadLine();
                i++;

            } while (!int.TryParse(input, out value) || value < 1 || value > 10);

            LiftPass liftPass = liftPassController.GetByType(value);
            return liftPass;
        }

=======
>>>>>>> 5b8a688afb28000f9d15563c0ade89958f34d7da
        private void Back()
        {
            DisplayInfo displayInfo = new DisplayInfo();

        }
    }
<<<<<<< HEAD
}
=======
}
>>>>>>> 5b8a688afb28000f9d15563c0ade89958f34d7da
