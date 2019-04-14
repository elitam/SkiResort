using SkiResort.Business;
using SkiResort.Data.Models;
using System;
using System.Collections.Generic;
<<<<<<< HEAD
using System.Drawing;
using System.Text;
using Console = Colorful.Console;

=======
using System.Text;
>>>>>>> 5b8a688afb28000f9d15563c0ade89958f34d7da

namespace SkiResort.Views.Hikes
{
    public class DisplayUpdate
    {
        public DisplayUpdate()
        {
            hikeController = new HikeController();
            InputUpdate();
        }



        private HikeController hikeController;


        private void ShowMenuUpdate()
        {
<<<<<<< HEAD
            Console.WriteLine();
            Console.WriteLine("         ┌────────────────────────────────┐");
            Console.WriteLine("         │             UPDATE!            │");
            Console.WriteLine("┌────────└────────────────────────────────┘────────┐");
            Console.WriteLine("│                       MENU:                      │");
            Console.WriteLine("│                                                  │");
            Console.WriteLine("│    0.BACK                  3. UPDATE AVERAGE     │");
            Console.WriteLine("│                                  DURATION        │");
            Console.WriteLine("│    1. UPDATE START POINT   4. UPDATE START DATE  │");
            Console.WriteLine("│                                                  │");
            Console.WriteLine("│    2. UPDATE END POINT     5. UPDATE ALL         │");
            Console.WriteLine("│                                                  │");
            Console.WriteLine("└──────────────────────────────────────────────────┘");
            Console.WriteLine();

=======
            Console.WriteLine("         ┌────────────────────────────────┐");
            Console.WriteLine("         │             UPDATE!            │");
            Console.WriteLine("┌────────└────────────────────────────────┘────────┐");
            Console.WriteLine("│                       MENU:                      │   ");
            Console.WriteLine("│                                                  │   ");
            Console.WriteLine("│    0.BACK                  3. UPDATE AVERAGE     │   ");
            Console.WriteLine("│                                  DURATION        │   ");
            Console.WriteLine("│    1. UPDATE START POINT   4. UPDATE START DATE  │   ");
            Console.WriteLine("│                                                  │   ");
            Console.WriteLine("│    2. UPDATE END POINT     5. UPDATE ALL         │   ");
            Console.WriteLine("│                                                  │   ");
            Console.WriteLine("└──────────────────────────────────────────────────┘");
>>>>>>> 5b8a688afb28000f9d15563c0ade89958f34d7da
        }

        private void InputUpdate()
        {
<<<<<<< HEAD
            ShowMenuUpdate();

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
            var operation = -1;
            do
            {
                ShowMenuUpdate();
                operation = int.Parse(Console.ReadLine());
>>>>>>> 5b8a688afb28000f9d15563c0ade89958f34d7da
                switch (operation)
                {
                    case 0:
                        Exit();
                        break;

                    case 1:
                        UpdateStartPoint();
                        break;
                    case 2:
                        UpdateEndPoint();
                        break;
                    case 3:
                        UpdateAverageDuration();
                        break;
                    case 4:
                        UpdateStartDate();
                        break;
                    case 5:
                        UpdateAll();
                        break;

                    default:
                        break;
                }

            } while (true);
        }

        private void UpdateAll()
        {

<<<<<<< HEAD
            var hike = new Hike();
            do
            {
                hike = GetHike();
            } while (hike.StartPoint == null);


            Console.WriteLine("\nEnter start point: ");
            hike.StartPoint = Console.ReadLine();

            Console.WriteLine("\nEnter end point: ");
            hike.EndPoint = Console.ReadLine();

            Console.WriteLine("\nEnter start date: (dd-mm-yy)");
            hike.StartDate = DateTime.Parse(Console.ReadLine());

            string input;
            decimal value;
            int i = 1;
            do
            {
                if (i > 1)
                {
                    Console.WriteLine("Invalid input!", Color.Pink);
                }
                Console.WriteLine("\nEnter average duration in hours: ");
                input = Console.ReadLine();
                i++;

            } while (!decimal.TryParse(input, out value));

            hike.AverageDuration = value;

            hikeController.Update(hike);
            Console.WriteLine("\nHike updated successfully!", Color.LightGreen);



        }

        private void UpdateAverageDuration()
        {

            var hike = new Hike();
            do
            {
                hike = GetHike();
            } while (hike.StartPoint == null);

            string input;
            decimal value;
            int i = 1;
            do
            {
                if (i > 1)
                {
                    Console.WriteLine("Invalid input!", Color.Pink);

                }
                Console.WriteLine("\nEnter average duration in hours: ");
                input = Console.ReadLine();
                i++;

            } while (!decimal.TryParse(input, out value));

            hike.AverageDuration = value;
            Console.WriteLine("\nAverage duration updated successfully!", Color.LightGreen);
=======
            var hike = GetHike();

            if (hike != null)
            {
                Console.WriteLine("Enter start point: ");
                hike.StartPoint = Console.ReadLine();
                Console.WriteLine("Enter end point: ");
                hike.EndPoint = Console.ReadLine();
                Console.WriteLine("Enter start date : ");
                hike.StartDate = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Enter average duration in hours: ");
                hike.AverageDuration = decimal.Parse(Console.ReadLine());
                hikeController.Update(hike);
                Console.WriteLine("Hike updated");


            }
            else
            {
                throw new Exception("Hike not found!");
            }
        }

        private void UpdateAverageDuration()
        {
            var hike = GetHike();


            try
            {

                Console.WriteLine("Enter average duration in hours: ");
                hike.AverageDuration = decimal.Parse(Console.ReadLine());
                hikeController.Update(hike);
                Console.WriteLine("Average duration updated");



            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine($"{e} Hike not found.");

            }
            finally
            {

            }             
>>>>>>> 5b8a688afb28000f9d15563c0ade89958f34d7da



        }

        private void UpdateEndPoint()
        {

<<<<<<< HEAD
            var hike = new Hike();
            do
            {
                hike = GetHike();
            } while (hike.StartPoint == null);

            Console.WriteLine("\nEnter end point: ");
            hike.EndPoint = Console.ReadLine();
            hikeController.Update(hike);
            Console.WriteLine("\nEnd point updated successfully!", Color.LightGreen);


=======
            var hike = GetHike();


            if (hike != null)
            {

                Console.WriteLine("Enter end point: ");
                hike.EndPoint = Console.ReadLine();
                hikeController.Update(hike);
                Console.WriteLine("End point updated");

            }
            else
            {

                throw new Exception("Hike not found!");
            }
>>>>>>> 5b8a688afb28000f9d15563c0ade89958f34d7da
        }

        private void UpdateStartDate()
        {
            var hike = GetHike();



            if (hike != null)
            {

<<<<<<< HEAD
                Console.WriteLine("Enter start date: (dd-mm-yy)");
                hike.StartDate = DateTime.Parse(Console.ReadLine());
                hikeController.Update(hike);
                Console.WriteLine("Start date updated successfully!");
=======
                Console.WriteLine("Enter start date: ");
                hike.StartDate = DateTime.Parse(Console.ReadLine());
                hikeController.Update(hike);
                Console.WriteLine("Start date updated");
>>>>>>> 5b8a688afb28000f9d15563c0ade89958f34d7da

            }
            else
            {
                throw new Exception("Hike not found!");
            }
        }

        private void UpdateStartPoint()
        {

<<<<<<< HEAD
            var hike = new Hike();
            do
            {
                hike = GetHike();
            } while (hike.StartPoint == null);


            Console.WriteLine("\nEnter start point: ");
            hike.StartPoint = Console.ReadLine();
            hikeController.Update(hike);
            Console.WriteLine("\nStart Point updated successfully!", Color.LightGreen);

=======
            var cuurHike = GetHike();

            if (cuurHike != null)
            {
                Console.WriteLine("Enter start point: ");
                cuurHike.StartPoint = Console.ReadLine();
                hikeController.Update(cuurHike);
                Console.WriteLine("Start point updated");

            }
            else
            {
                throw new Exception("Hike not found!");
            }
>>>>>>> 5b8a688afb28000f9d15563c0ade89958f34d7da
        }

        private void Exit()
        {
            DisplayHikes displayHikes = new DisplayHikes();

        }

        private Hike GetHike()
        {
<<<<<<< HEAD


            Console.WriteLine("\nEnter ID to update:");

            Hike hike = new Hike();
            int value;
            if (!int.TryParse(Console.ReadLine(), out value))
            {
                Console.WriteLine("Input must be a number!", Color.Pink);

            }
            else
            {
                int id = value;
                hike = hikeController.Get(id);
            }
=======
            Console.WriteLine("Enter ID to update:");
            int id = int.Parse(Console.ReadLine());
            Hike hike = hikeController.Get(id);
>>>>>>> 5b8a688afb28000f9d15563c0ade89958f34d7da

            return hike;
        }

        private string PrintHike(Hike hike)
        {
            return $"{hike.Id} From {hike.StartPoint} to {hike.EndPoint}- {hike.AverageDuration:F0} hours on {hike.StartDate.ToString("dd/MM/yyyy")}";

        }

    }
<<<<<<< HEAD
}
=======
}
>>>>>>> 5b8a688afb28000f9d15563c0ade89958f34d7da
