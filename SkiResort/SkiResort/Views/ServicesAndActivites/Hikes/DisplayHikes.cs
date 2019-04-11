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
            InputHikes();
        }

        

        private HikeController hikeController; 

        

        private void ShowMenuHikes()
        {
            Console.WriteLine("         ┌────────────────────────────────┐");
            Console.WriteLine("         │             HIKES!             │");
            Console.WriteLine("┌────────└────────────────────────────────┘────────┐");
            Console.WriteLine("│                     MENU:                        │   ");
            Console.WriteLine("│                                                  │   ");
            Console.WriteLine("│      0. BACK                 3. LIST ALL         │   ");
            Console.WriteLine("│                                                  │   ");
            Console.WriteLine("│      1. ADD                  4. UPDATE           │   ");
            Console.WriteLine("│                                                  │   ");
            Console.WriteLine("│      2. DELETE               5. RATE             │   ");
            Console.WriteLine("│                                                  │   ");
            Console.WriteLine("└──────────────────────────────────────────────────┘");
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
                        Delete();
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



        private void Delete()
        {
            Console.WriteLine("Enter ID to delete: ");
            int id = int.Parse(Console.ReadLine());
            Hike hike = new Hike();
            hikeController.Delete(id);
            Console.WriteLine("Done!");
        }

        private void Update()
        {
            this.ListAll();
            DisplayUpdate displayUpdate = new DisplayUpdate();
        }

        private void Rate()
        {
            throw new NotImplementedException();
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
        }

        public void ListAll()
        {

            Console.WriteLine(new string('-',40));
            Console.WriteLine(new string(' ', 18)+"HIKES"+ new string(' ', 18));
            Console.WriteLine(new string('-', 40));

            var hikes = this.hikeController.GetAll();

            foreach (var hike in hikes)
            {
                Console.WriteLine($"{hike.Id} From {hike.StartPoint} to {hike.EndPoint} - {hike.AverageDuration:f0} hours on {hike.StartDate.ToString("dd/MM/yyyy")}");
            }
        }

      
    }
}
