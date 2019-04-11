using SkiResort.Business;
using SkiResort.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

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
        }

        private void InputUpdate()
        {
            var operation = -1;
            do
            {
                ShowMenuUpdate();
                operation = int.Parse(Console.ReadLine());
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

                
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("{0} Hike not found.", e);
               
            }

            
            
        }

        private void UpdateEndPoint()
        {

            var hike = GetHike();
           

            if (hike != null)
            {

                Console.WriteLine("Enter end point: ");
                hike.EndPoint = Console.ReadLine();
                hikeController.Update(hike);

            }
            else
            {

                throw new Exception("Hike not found!");
            }
        }

        private void UpdateStartDate()
        {
            var hike = GetHike();
           


            if (hike != null)
            {

                Console.WriteLine("Enter start date: ");
                hike.StartDate = DateTime.Parse(Console.ReadLine());
                hikeController.Update(hike);

            }
            else
            {
                throw new Exception("Hike not found!");
            }
        }

        private void UpdateStartPoint()
        {
            
            var cuurHike = GetHike();
           
            if (cuurHike != null)
            {
                Console.WriteLine("Enter start point: ");
                cuurHike.StartPoint = Console.ReadLine();
                hikeController.Update(cuurHike);

            }
            else
            {
                throw new Exception("Hike not found!");
            }
        }

        private void Exit()
        {
            DisplayHikes displayHikes = new DisplayHikes();

        }

        private Hike GetHike()
        {
            Console.WriteLine("Enter ID to update:");
            int id = int.Parse(Console.ReadLine());
            Hike hike = hikeController.Get(id);
            //Console.WriteLine(PrintHike(hike));
            return hike;
        }

        private string PrintHike(Hike hike)
        {
            return $"{hike.Id} From {hike.StartPoint} to {hike.EndPoint}- {hike.AverageDuration:F0} hours on {hike.StartDate.ToString("dd/MM/yyyy")}";

        }

    }
}
