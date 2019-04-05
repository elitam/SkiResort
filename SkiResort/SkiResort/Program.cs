using System;

namespace SkiResort
{
    class Program
    {
        static void Main(string[] args)
        {
            WelcomeMenu();

             void WelcomeMenu() {


                Console.WriteLine("         ┌────────────────────────────────┐");
                Console.WriteLine("         │   WELCOME TO OUR SKI RESORT!   │");
                Console.WriteLine("┌────────└────────────────────────────────┘────────┐");
                Console.WriteLine("│                     MENU:                        │   ");
                Console.WriteLine("│   1. INFO                      3. CARDS          │   ");
                Console.WriteLine("│                                                  │   ");
                Console.WriteLine("│   2. RENTAL                    4. HIKES          │   ");
                Console.WriteLine("│                                                  │   ");
                Console.WriteLine("└──────────────────────────────────────────────────┘");
            }
        }
    }
}
