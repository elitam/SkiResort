using SkiResort.Business;
<<<<<<< HEAD
using SkiResort.Data.Models;
using SkiResort.Views.Hikes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Console = Colorful.Console;
=======
using System;
using System.Collections.Generic;
using System.Text;
>>>>>>> 5b8a688afb28000f9d15563c0ade89958f34d7da

namespace SkiResort.Views
{
    public class Display
    {
        public Display()
        {
            Input();
<<<<<<< HEAD
=======
            
>>>>>>> 5b8a688afb28000f9d15563c0ade89958f34d7da
        }
        private void WelcomeMenu()
        {

            Console.WriteLine();
            Console.WriteLine("         ┌────────────────────────────────┐");
            Console.WriteLine("         │   WELCOME TO OUR SKI RESORT!   │");
            Console.WriteLine("┌────────└────────────────────────────────┘────────┐");
            Console.WriteLine("│                     MENU:                        │   ");
            Console.WriteLine("│                                                  │   ");
<<<<<<< HEAD
            Console.WriteLine("│     0. EXIT                    2. SEVICES        │   ");
            Console.WriteLine("│                                     &            │   ");
            Console.WriteLine("│     1. INFO                     ACTIVITIES       │   ");
=======
            Console.WriteLine("│     0. EXIT                2. SEVICES            │   ");
            Console.WriteLine("│                                 &                │   ");
            Console.WriteLine("│     1. INFO                 ACTIVITIES           │   ");
>>>>>>> 5b8a688afb28000f9d15563c0ade89958f34d7da
            Console.WriteLine("│                                                  │   ");
            Console.WriteLine("└──────────────────────────────────────────────────┘");
            Console.WriteLine();
        }

        private int closeOperation = 0;

        private void Input()
        {
<<<<<<< HEAD
            WelcomeMenu();

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
                switch (operation)
                {
                    case 0:
                        Environment.Exit(0);
                        break;
=======
            var operation = -1;
            do
            {
                WelcomeMenu();
                operation  = int.Parse(Console.ReadLine());
                switch (operation)
                {
                   
>>>>>>> 5b8a688afb28000f9d15563c0ade89958f34d7da
                    case 1:
                        Info();
                        break;
                    case 2:
                        SevicesAndAct();
                        break;
<<<<<<< HEAD

=======
                   
>>>>>>> 5b8a688afb28000f9d15563c0ade89958f34d7da
                    default:
                        break;
                }

<<<<<<< HEAD
            } while (true);

        }

        
        
=======
            } while (operation !=closeOperation);
           
        }

       

      
>>>>>>> 5b8a688afb28000f9d15563c0ade89958f34d7da

        private void SevicesAndAct()
        {
            DisplayServicesAndActivities displayServicesAndActivities = new DisplayServicesAndActivities();
        }

        private void Info()
        {
            DisplayInfo displayInfo = new DisplayInfo();
        }
    }
<<<<<<< HEAD
}
=======
}
>>>>>>> 5b8a688afb28000f9d15563c0ade89958f34d7da
