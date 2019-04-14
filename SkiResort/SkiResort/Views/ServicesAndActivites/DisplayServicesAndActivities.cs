<<<<<<< HEAD
﻿using SkiResort.Business;
using SkiResort.Data.Models;
using SkiResort.Views.Hikes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Console = Colorful.Console;
=======
﻿using System;
using System.Collections.Generic;
using System.Text;
>>>>>>> 5b8a688afb28000f9d15563c0ade89958f34d7da

namespace SkiResort.Views
{
    public class DisplayServicesAndActivities
    {
        public DisplayServicesAndActivities()
        {
            InputServices();

        }
        private void ShowMenuServices()
        {

            Console.WriteLine();
            Console.WriteLine("         ┌────────────────────────────────┐");
<<<<<<< HEAD
            Console.WriteLine("         │      SERIVES & ACTIVITIES      │");
            Console.WriteLine("┌────────└────────────────────────────────┘────────┐");
            Console.WriteLine("│                      MENU:                       │   ");
            Console.WriteLine("│                                                  │   ");
            Console.WriteLine("│                     0. EXIT                      │   ");
=======
            Console.WriteLine("         │      SEVICES & ACTIVITIES      │");
            Console.WriteLine("┌────────└────────────────────────────────┘────────┐");
            Console.WriteLine("│                      MENU:                       │   ");
            Console.WriteLine("│                                                  │   ");
            Console.WriteLine("│                    0. BACK                       │   ");
>>>>>>> 5b8a688afb28000f9d15563c0ade89958f34d7da
            Console.WriteLine("│                                                  │   ");
            Console.WriteLine("│        1. RENTAL              2. HIKES           │   ");
            Console.WriteLine("│                                                  │   ");
            Console.WriteLine("└──────────────────────────────────────────────────┘");
            Console.WriteLine();
        }

<<<<<<< HEAD


        private void InputServices()
        {
            ShowMenuServices();
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
        

        private void InputServices()
        {
            var operation = -1;
            do
            {
                ShowMenuServices();
                operation = int.Parse(Console.ReadLine());
>>>>>>> 5b8a688afb28000f9d15563c0ade89958f34d7da
                switch (operation)
                {
                    case 0:
                        Back();
                        break;
                    case 1:
                        Rental();
                        break;
                    case 2:
                        Hikes();
                        break;

                    default:
                        break;
                }

            } while (true);

        }

        private void Rental()
        {
            DisplayRental displayRental = new DisplayRental();
        }

        private void Hikes()
        {
            DisplayHikes displayHikes = new DisplayHikes();
        }

        private void Back()
        {
<<<<<<< HEAD
            Display display = new Display();
        }
    }
}
=======
           Display display = new Display();
        }
    }
}
>>>>>>> 5b8a688afb28000f9d15563c0ade89958f34d7da
