using SkiResort.Business;
using SkiResort.Data.Models;
using System;

namespace SkiResort
{
    class Program
    {
        public static object HikeComtroller { get; private set; }

        static void Main(string[] args)
        {
<<<<<<< HEAD

            /// tuka slagam random metodi deto ne znam oshte kude trqbva da sa, no znam che trqbva da gi ima ///

            void WelcomeMenu()
            {


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



=======
            Hike hike = new Hike("hotel Rila", "Musala", 20, new DateTime(2019, 9, 8));
            HikeController hikeController = new HikeController();

            //hikeController.Add(hike);

            hikeController.Delete(2);
            
>>>>>>> ccbde461353ae3845e9794f2a49ededd741c4790

        }
    }
}
