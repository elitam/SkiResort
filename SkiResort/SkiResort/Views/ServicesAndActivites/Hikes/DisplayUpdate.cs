using SkiResort.Business;
using SkiResort.Data.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Console = Colorful.Console;


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

        }

        private void InputUpdate()
        {
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



        }

        private void UpdateEndPoint()
        {

            var hike = new Hike();
            do
            {
                hike = GetHike();
            } while (hike.StartPoint == null);

            Console.WriteLine("\nEnter end point: ");
            hike.EndPoint = Console.ReadLine();
            hikeController.Update(hike);
            Console.WriteLine("\nEnd point updated successfully!", Color.LightGreen);


        }

        private void UpdateStartDate()
        {
            var hike = GetHike();



            if (hike != null)
            {

                Console.WriteLine("Enter start date: (dd-mm-yy)");
                hike.StartDate = DateTime.Parse(Console.ReadLine());
                hikeController.Update(hike);
                Console.WriteLine("Start date updated successfully!");

            }
            else
            {
                throw new Exception("Hike not found!");
            }
        }

        private void UpdateStartPoint()
        {

            var hike = new Hike();
            do
            {
                hike = GetHike();
            } while (hike.StartPoint == null);


            Console.WriteLine("\nEnter start point: ");
            hike.StartPoint = Console.ReadLine();
            hikeController.Update(hike);
            Console.WriteLine("\nStart Point updated successfully!", Color.LightGreen);

        }

        private void Exit()
        {
            DisplayHikes displayHikes = new DisplayHikes();

        }

        private Hike GetHike()
        {


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

            return hike;
        }

        private string PrintHike(Hike hike)
        {
            return $"{hike.Id} From {hike.StartPoint} to {hike.EndPoint}- {hike.AverageDuration:F0} hours on {hike.StartDate.ToString("dd/MM/yyyy")}";

        }

    }
}