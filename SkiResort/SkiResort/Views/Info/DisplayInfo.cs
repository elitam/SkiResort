<<<<<<< HEAD
﻿using SkiResort.Business;
using SkiResort.Data.Models;
using SkiResort.Views.Hikes;
using SkiResort.Views.Info;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Console = Colorful.Console;
=======
﻿using SkiResort.Views.Info;
using System;
using System.Collections.Generic;
using System.Text;
>>>>>>> 5b8a688afb28000f9d15563c0ade89958f34d7da

namespace SkiResort.Views
{
    public class DisplayInfo
    {
        public DisplayInfo()
        {
            InputInfo();
<<<<<<< HEAD
            // hikeController = new HikeController();
=======
           // hikeController = new HikeController();
>>>>>>> 5b8a688afb28000f9d15563c0ade89958f34d7da
        }



<<<<<<< HEAD
        // private HikeController hikeController;


        private void ShowMenuINFO()
        {
            Console.WriteLine();
=======
       // private HikeController hikeController;

        int closeOperation = 6;

        private void ShowMenuINFO()
        {
>>>>>>> 5b8a688afb28000f9d15563c0ade89958f34d7da
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
<<<<<<< HEAD
            Console.WriteLine();

=======
>>>>>>> 5b8a688afb28000f9d15563c0ade89958f34d7da
        }

        private void InputInfo()
        {
<<<<<<< HEAD
            ShowMenuINFO();

            do
            {
                int operation = -1;
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
                ShowMenuINFO();
                operation = int.Parse(Console.ReadLine());
>>>>>>> 5b8a688afb28000f9d15563c0ade89958f34d7da
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
<<<<<<< HEAD
                       
                        break;
                }

            } while (true);
=======
                        break;
                }

            } while (operation != closeOperation);
>>>>>>> 5b8a688afb28000f9d15563c0ade89958f34d7da
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
<<<<<<< HEAD
}
=======
}
>>>>>>> 5b8a688afb28000f9d15563c0ade89958f34d7da
