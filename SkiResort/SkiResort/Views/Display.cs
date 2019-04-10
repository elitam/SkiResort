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


            Console.WriteLine("         ┌────────────────────────────────┐");
            Console.WriteLine("         │   WELCOME TO OUR SKI RESORT!   │");
            Console.WriteLine("┌────────└────────────────────────────────┘────────┐");
            Console.WriteLine("│                     MENU:                        │   ");
            Console.WriteLine("│   1. INFO                      3. LIFTPASSES     │   ");
            Console.WriteLine("│                                                  │   ");
            Console.WriteLine("│   2. RENTAL                    4. HIKES          │   ");
            Console.WriteLine("│                                                  │   ");
            Console.WriteLine("└──────────────────────────────────────────────────┘");
        }
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
                        Rental();
                        break;
                    case 3:
                        LiftPasses();
                        break;
                    case 4:
                        Hikes();
                        break;
                    default:
                        break;
                }

            } while (true);
           
        }

       

        private void Hikes()
        {

            DisplayHikes displayHikes = new DisplayHikes();
            
        }

        private void LiftPasses()
        {
            throw new NotImplementedException();
        }

        private void Rental()
        {
            throw new NotImplementedException();
        }

        private void Info()
        {
            DisplayInfo displayInfo = new DisplayInfo();
        }
    }
}
