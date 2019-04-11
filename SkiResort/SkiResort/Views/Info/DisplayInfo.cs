using SkiResort.Views.Info;
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
            Console.WriteLine("│                      MENU:                       │   ");
            Console.WriteLine("│                                                  │   ");
            Console.WriteLine("│      0. BACK              2. TRAILS              │   ");
            Console.WriteLine("│                                                  │   ");
            Console.WriteLine("│      1. LIFTS             3. LIFT PASSES         │   ");
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
                    case 0:
                        Exit();
                        break;
                    case 1:
                        Lift();
                        break;
                    case 2:
                        Trail();
                        break;
                    case 3:
                        LiftPass();
                        break;

                    default:
                        break;
                }

            } while (operation != closeOperation);
        }

        private void LiftPass()
        {
            DisplayLiftPass displayLiftPass = new DisplayLiftPass();
        }

        private void Exit()
        {
            Display display = new Display();
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
