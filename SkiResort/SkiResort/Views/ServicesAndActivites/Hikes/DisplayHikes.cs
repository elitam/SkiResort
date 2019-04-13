using SkiResort.Business;
using SkiResort.Data.Models;
using SkiResort.Views.Hikes;
using System;
using System.Collections.Generic;
using System.Text;

namespace SkiResort.Views
{
    public class DisplayHikes 
    {
       
        public DisplayHikes()
        {
            hikeController = new HikeController();
            rateController = new RateController();
            InputHikes();
        }

        

        private HikeController hikeController;
        private RateController rateController;




        private void ShowMenuHikes()
        {
            Console.WriteLine("         ┌────────────────────────────────┐");
            Console.WriteLine("         │            HIKES!              │");
            Console.WriteLine("┌────────└────────────────────────────────┘────────┐");
            Console.WriteLine("│                     MENU:                        │   ");
            Console.WriteLine("│                                                  │   ");
            Console.WriteLine("│      0. BACK                 3. LIST ALL         │   ");
            Console.WriteLine("│                                                  │   ");
            Console.WriteLine("│      1. ADD                  4. UPDATE           │   ");
            Console.WriteLine("│                                                  │   ");
            Console.WriteLine("│      2. REMOVE               5. RATE             │   ");
            Console.WriteLine("│                                                  │   ");
            Console.WriteLine("└──────────────────────────────────────────────────┘");
            Console.WriteLine();
        }

        private void InputHikes()
        {
            var operation = -1;
            do
            {
                ShowMenuHikes();
                operation = int.Parse(Console.ReadLine());
                switch (operation)
                {
                    case 0:
                        Exit();
                        break;
                    case 1:
                        Add();
                        break;
                    case 2:
                        Remove();
                        break;
                    case 3:
                        ListAll();
                        break;
                    case 4:
                        Update();
                        break;
                    case 5:
                        Rate();
                        break;
                   
                   
                   
                    default:
                        break;
                }

            } while (true);
        }
        private void Exit()
        {
            DisplayServicesAndActivities display = new DisplayServicesAndActivities();

        }



        private void Remove()
        {
            this.ListAll();

            Console.WriteLine("Enter ID to delete: ");
            int id = int.Parse(Console.ReadLine());
            Hike hike = new Hike();
            hikeController.Delete(id);
            Console.WriteLine("Hike removed successfully!");
            

        }

        private void Update()
        {
            this.ListAll();
            DisplayUpdate displayUpdate = new DisplayUpdate();
        }

        private void Rate()
        {
            this.ListAll();
            Rate rate = new Rate();

            Console.WriteLine("Enter hike id to rate: ");
            rate.HikeId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter stars (1...5): ");
            rate.Stars = int.Parse(Console.ReadLine());
            this.rateController.AddRate(rate);
            Console.WriteLine("Rate added successfully!");
        }

        private void Add()
        {
            Hike hike = new Hike();
            Console.WriteLine("Enter start point: ");
            hike.StartPoint = Console.ReadLine();
            Console.WriteLine("Enter end point: ");
            hike.EndPoint = Console.ReadLine();
            Console.WriteLine("Enter start date : ");
            hike.StartDate =DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter average duration: ");
            hike.AverageDuration = decimal.Parse(Console.ReadLine());
            this.hikeController.Add(hike);
            Console.WriteLine("Hike added successfully!");
        }

        public void ListAll()
        {

            Console.WriteLine(new string('-',40));
            Console.WriteLine(new string(' ', 18)+"HIKES"+ new string(' ', 18));
            Console.WriteLine(new string('-', 40));

            var hikes = this.hikeController.GetAll();

            foreach (var hike in hikes)
            {
                var rating = rateController.CalculateRateForHike(hike);
                Console.WriteLine($"{hike.Id} From {hike.StartPoint} to {hike.EndPoint} - {hike.AverageDuration:f0} hours on {hike.StartDate.ToString("dd/MM/yyyy")}" +
                    $" with rate {rating} starts ");
            }
            Console.WriteLine();
        }

      
    }
}
