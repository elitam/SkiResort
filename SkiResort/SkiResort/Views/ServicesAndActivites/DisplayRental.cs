using SkiResort.Business;
using SkiResort.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SkiResort.Views
{
    class DisplayRental
    {
        public DisplayRental()
        {
            rentalController = new RentalController();
            InputRental();
        }

        private RentalController rentalController;

        int closeOperation = 6;

        private void ShowMenuRental()
        {
            Console.WriteLine();
            Console.WriteLine("         ┌────────────────────────────────┐");
            Console.WriteLine("         │             RENTAL!            │");
            Console.WriteLine("┌────────└────────────────────────────────┘───────────┐");
            Console.WriteLine("│                        MENU:                        │");
            Console.WriteLine("│                                                     │");
            Console.WriteLine("│      0. BACK                     3. LIST ITEMS      │");
            Console.WriteLine("│                                                     │");
            Console.WriteLine("│      1. ADD ITEM                 4. RENT ITEM       │");
            Console.WriteLine("│                                                     │");
            Console.WriteLine("│      2. REMOVE ITEM              5. RETURN ITEM     │");
            Console.WriteLine("│                                                     │");
            Console.WriteLine("└─────────────────────────────────────────────────────┘");
            Console.WriteLine();
        }


        private void InputRental()
        {
            var operation = -1;
            do
            {
                ShowMenuRental();
                operation = int.Parse(Console.ReadLine());
                switch (operation)
                {
                    case 0:
                        Back();
                        break;
                    case 1:
                        AddItem();
                        break;
                    case 2:
                        RemoveItem();
                        break;
                    case 3:
                        ListAll();
                        break;
                    case 4:
                        RentItem();
                        break;
                    case 5:
                        ReturnItem();
                        break;
                    default:
                        break;
                }

            } while (operation != closeOperation);
        }



        private void ReturnItem()
        {
            ListRentedItems();
            Console.WriteLine("Enter item id:");
            var id = int.Parse(Console.ReadLine());
            this.rentalController.ReturnItem(id);
            Console.WriteLine("Item returned successfully!");
        }



        private void RentItem()
        {
            ListAll();
            Console.WriteLine("Enter item id:");
            var id = int.Parse(Console.ReadLine());
            this.rentalController.RentItem(id);
            Console.WriteLine("Item rented successfully!");
        }

        private void RemoveItem()
        {
            ListAll();
            Console.WriteLine("Enter item id:");
            var id = int.Parse(Console.ReadLine());
            this.rentalController.RemoveById(id);
            Console.WriteLine("Item removed successfully!");
        }

        private void AddItem()
        {
            Item item = new Item();
            Console.WriteLine("Enter item name: ");
            item.Name = Console.ReadLine();
            Console.WriteLine("Enter item price: ");
            item.Price = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter item size: ");
            item.Size = Console.ReadLine();
            Console.WriteLine("Enter item gender: ");
            var gender = Console.ReadLine();
            ValidateGender(gender);
            item.Gender = gender;
            this.rentalController.Add(item);
            Console.WriteLine("Item added successfully!"); // tuka go pookrasi da e zatvoreno v kvadratche
        }

        public void ValidateGender(string gender)
        {
            while (gender != "Male" && gender != "Female" && gender != "Kids")
            {
                Console.WriteLine("Invalid gender. Only Male, Female or Kids available !");
                Console.WriteLine("Enter type: (Male/Female/Kids)");
                gender = Console.ReadLine();
            }
            

        }

        private void ListAll()
        {
            PrintTitle("RENTAL");
            PrintTitle("FEMALE");

            ListByGenderAndType("Female", "Not Rented");
            PrintTitle("MALE");
            ListByGenderAndType("Male", "Not Rented");
            PrintTitle("KIDS");
            ListByGenderAndType("Kids", "Not Rented");
            Console.WriteLine();
        }

        private void PrintTitle(string title)
        {
            if (title == "FEMALE" || title == "RENTAL")
            {
                Console.WriteLine(new string('-', 40));
                Console.WriteLine(new string(' ', 17) + title + new string(' ', 18));
                Console.WriteLine(new string('-', 40));
            }
            else if (title == "MALE" || title == "KIDS")
            {
                Console.WriteLine(new string('-', 40));
                Console.WriteLine(new string(' ', 18) + title + new string(' ', 18));
                Console.WriteLine(new string('-', 40));
            }
            else
            {
                Console.WriteLine(new string('-', 40));
                Console.WriteLine(new string(' ', 14) + title + new string(' ', 18));
                Console.WriteLine(new string('-', 40));
            }


        }

        private void ListByGenderAndType(string gender, string status)
        {
            var items = rentalController.GetAllItems();
            foreach (var item in items.Where(it => it.Gender == gender))
            {
                if (item.Status == status)
                {
                    Console.WriteLine($"{item.Id}: {item.Name} ({item.Size} size), costs {item.Price:F2} lv");
                }

            }
        }

        private void ListRentedItems()
        {
            PrintTitle("RENTED ITEMS");
            PrintTitle("FEMALE");

            ListByGenderAndType("Female", "Rented");
            PrintTitle("MALE");
            ListByGenderAndType("Male", "Rented");
            PrintTitle("KIDS");
            ListByGenderAndType("Kids", "Rented");
            Console.WriteLine();
        }

        private void Back()
        {
            DisplayServicesAndActivities display = new DisplayServicesAndActivities();

        }


    }
}