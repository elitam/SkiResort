using System;
using System.Collections.Generic;
using System.Text;

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
            Console.WriteLine("         │      SEVICES & ACTIVITIES      │");
            Console.WriteLine("┌────────└────────────────────────────────┘────────┐");
            Console.WriteLine("│                      MENU:                       │   ");
            Console.WriteLine("│                                                  │   ");
            Console.WriteLine("│                    0. BACK                       │   ");
            Console.WriteLine("│                                                  │   ");
            Console.WriteLine("│        1. RENTAL              2. HIKES           │   ");
            Console.WriteLine("│                                                  │   ");
            Console.WriteLine("└──────────────────────────────────────────────────┘");
            Console.WriteLine();
        }

        

        private void InputServices()
        {
            var operation = -1;
            do
            {
                ShowMenuServices();
                operation = int.Parse(Console.ReadLine());
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
           Display display = new Display();
        }
    }
}
