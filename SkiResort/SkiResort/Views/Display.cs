using SkiResort.Business;
using System;
using System.Collections.Generic;
using System.Text;

namespace SkiResort.Views
{
    public class Display
    {
        public Display()
        {
            Input();
            
        }
        private void WelcomeMenu()
        {

            Console.WriteLine();
            Console.WriteLine("         ┌────────────────────────────────┐");
            Console.WriteLine("         │   WELCOME TO OUR SKI RESORT!   │");
            Console.WriteLine("┌────────└────────────────────────────────┘────────┐");
            Console.WriteLine("│                     MENU:                        │   ");
            Console.WriteLine("│                                                  │   ");
            Console.WriteLine("│     0. EXIT                2. SEVICES            │   ");
            Console.WriteLine("│                                 &                │   ");
            Console.WriteLine("│     1. INFO                 ACTIVITIES           │   ");
            Console.WriteLine("│                                                  │   ");
            Console.WriteLine("└──────────────────────────────────────────────────┘");
            Console.WriteLine();
        }

        private int closeOperation = 0;

        private void Input()
        {
            var operation = -1;
            do
            {
                WelcomeMenu();
                operation  = int.Parse(Console.ReadLine());
                switch (operation)
                {
                   
                    case 1:
                        Info();
                        break;
                    case 2:
                        SevicesAndAct();
                        break;
                   
                    default:
                        break;
                }

            } while (operation !=closeOperation);
           
        }

       

      

        private void SevicesAndAct()
        {
            DisplayServicesAndActivities displayServicesAndActivities = new DisplayServicesAndActivities();
        }

        private void Info()
        {
            DisplayInfo displayInfo = new DisplayInfo();
        }
    }
}
