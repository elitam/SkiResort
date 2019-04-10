using SkiResort.Business;
using SkiResort.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SkiResort.Views
{
    public class DisplayHikes 
    {
       
        public DisplayHikes()
        {
            InputHikes();
            hikeController = new HikeController();
        }

        

        private HikeController hikeController; 

        int closeOperation = 6;

        private void ShowMenuHikes()
        {
            Console.WriteLine("         ┌────────────────────────────────┐");
            Console.WriteLine("         │             HIKES!             │");
            Console.WriteLine("┌────────└────────────────────────────────┘────────┐");
            Console.WriteLine("│                     MENU:                        │   ");
            Console.WriteLine("│      1. ADD                        4. UPDATE     │   ");
            Console.WriteLine("│                                                  │   ");
            Console.WriteLine("│      2. LISTALL                    5. DELETE     │   ");
            Console.WriteLine("│                                                  │   ");
            Console.WriteLine("│      3. FETCH                      6. MAIN MANU  │   ");
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
                    case 1:
                        Add();
                        break;
                    case 2:
                        ListAll();
                        break;
                    case 3:
                        Fetch();
                        break;
                    case 4:
                        Update();
                        break;
                    case 5:
                        Delete();
                        break;
                    case 6:
                        Exit();
                        break;
                    default:
                        break;
                }

            } while (operation != closeOperation);
        }
        private void Exit()
        {
            Display display = new Display();

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
            throw new NotImplementedException();
        }

        private void Fetch()
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
            Console.WriteLine("Enter lenght: ");
            hike.Length = decimal.Parse(Console.ReadLine());
            this.hikeController.Add(hike);
        }

        private void ListAll()
        {

            Console.WriteLine(new string('-',40));
            Console.WriteLine(new string(' ', 18)+"HIKES"+ new string(' ', 18));
            Console.WriteLine(new string('-', 40));

            var hikes = this.hikeController.GetAll();

            foreach (var hike in hikes)
            {
                Console.WriteLine($"{hike.Id} From {hike.StartPoint} to {hike.EndPoint}- {hike.Length}km on {hike.StartDate}");
            }
        }

      
    }
}
