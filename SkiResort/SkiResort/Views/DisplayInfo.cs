using System;
using System.Collections.Generic;
using System.Text;

namespace SkiResort.Views
{
    public class DisplayInfo
    {
        public DisplayInfo()
        {
            InputInfo();
           // hikeController = new HikeController();
        }



       // private HikeController hikeController;

        int closeOperation = 6;

        private void ShowMenuINFO()
        {
            Console.WriteLine("         ┌────────────────────────────────┐");
            Console.WriteLine("         │             INFO!              │");
            Console.WriteLine("┌────────└────────────────────────────────┘────────┐");
            Console.WriteLine("│                     MENU:                        │   ");
            Console.WriteLine("│      1. LIFT MENU              2. TRAIL MENU     │   ");
            Console.WriteLine("│                                                  │   ");
            Console.WriteLine("│      3. MAIN MENU                                │   ");
            Console.WriteLine("│                                                  │   ");
            Console.WriteLine("└──────────────────────────────────────────────────┘");
        }

        private void InputInfo()
        {
            var operation = -1;
            do
            {
                ShowMenuINFO();
                operation = int.Parse(Console.ReadLine());
                switch (operation)
                {
                    case 1:
                        Lift();
                        break;
                    case 2:
                        Trail();
                        break;
                    
                    default:
                        break;
                }

            } while (operation != closeOperation);
        }

        private void Trail()
        {
            var displayTrail = new DisplayTrail();
        }

        private void Lift()
        {
            var displayLift = new DisplayLift();
        }
    }
}
