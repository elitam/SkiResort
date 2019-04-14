using SkiResort.Business;
using SkiResort.Data.Models;
using System;
using System.Collections.Generic;
<<<<<<< HEAD
using System.Drawing;
using System.Linq;
using System.Text;
using Console = Colorful.Console;

=======
using System.Linq;
using System.Text;
>>>>>>> 5b8a688afb28000f9d15563c0ade89958f34d7da

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
<<<<<<< HEAD
            Console.WriteLine("┌────────└────────────────────────────────┘────────┐");
            Console.WriteLine("│                        MENU:                     │");
            Console.WriteLine("│                                                  │");
            Console.WriteLine("│      0. BACK                     3. LIST ITEMS   │");
            Console.WriteLine("│                                                  │");
            Console.WriteLine("│      1. ADD ITEM                 4. RENT ITEM    │");
            Console.WriteLine("│                                                  │");
            Console.WriteLine("│      2. REMOVE ITEM              5. RETURN ITEM  │");
            Console.WriteLine("│                                                  │");
            Console.WriteLine("└──────────────────────────────────────────────────┘");
            Console.WriteLine();

        }

        private void InputRental()
        {
            ShowMenuRental();
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
>>>>>>> 5b8a688afb28000f9d15563c0ade89958f34d7da
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

<<<<<<< HEAD
        private void ReturnItem()
        {
            ListRentedItems();

            var item = new Item();
            do
            {
                item = GetById();
            } while (item.Size == null);


            this.rentalController.ReturnItem(item.Id);
            Console.WriteLine("\nItem returned successfully!", Color.LightGreen);
        } // validated
=======


        private void ReturnItem()
        {
            ListRentedItems();
            Console.WriteLine("Enter item id:");
            var id = int.Parse(Console.ReadLine());
            this.rentalController.ReturnItem(id);
            Console.WriteLine("Item returned successfully!");
        }


>>>>>>> 5b8a688afb28000f9d15563c0ade89958f34d7da

        private void RentItem()
        {
            ListAll();
<<<<<<< HEAD

            var item = new Item();
            do
            {
                item = GetById();
            } while (item.Size == null);


            this.rentalController.RentItem(item.Id);
            Console.WriteLine("\nItem rented successfully!", Color.LightGreen);

        } // validated
=======
            Console.WriteLine("Enter item id:");
            var id = int.Parse(Console.ReadLine());
            this.rentalController.RentItem(id);
            Console.WriteLine("Item rented successfully!");
        }
>>>>>>> 5b8a688afb28000f9d15563c0ade89958f34d7da

        private void RemoveItem()
        {
            ListAll();
<<<<<<< HEAD

            var item = new Item();
            do
            {
                item = GetById();
            } while (item.Size == null);


            this.rentalController.RemoveById(item.Id);
            Console.WriteLine("\nItem removed successfully!", Color.LightGreen);

        } // validated
=======
            Console.WriteLine("Enter item id:");
            var id = int.Parse(Console.ReadLine());
            this.rentalController.RemoveById(id);
            Console.WriteLine("Item removed successfully!");
        }
>>>>>>> 5b8a688afb28000f9d15563c0ade89958f34d7da

        private void AddItem()
        {
            Item item = new Item();
<<<<<<< HEAD

            Console.WriteLine("\nEnter item name: ");
            item.Name = Console.ReadLine();

            string input;
            decimal value;
            int i = 1;
            do
            {
                if (i > 1)
                {
                    Console.WriteLine("Invalid input!", Color.Pink);

                }
                Console.WriteLine("\nEnter item price: ");
                input = Console.ReadLine();
                i++;

            } while (!decimal.TryParse(input, out value));
            item.Price = value;

            Console.WriteLine("\nEnter item size: ");
            item.Size = Console.ReadLine();

            string gender;
            int b = 1;
            do
            {
                if (b > 1)
                {
                    Console.WriteLine("Invalid input!", Color.Pink);
                }
                Console.WriteLine("\nEnter item gender: (Female, Male, Kids)");
                gender = Console.ReadLine();
                b++;
            } while (gender.ToLower() != "female" && gender.ToLower() != "male" && gender.ToLower() != "kids");
            item.Gender = FirstCharToUpper(gender);

            this.rentalController.Add(item);
            Console.WriteLine("\nItem added successfully!", Color.LightGreen);
        } // validated
=======
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
>>>>>>> 5b8a688afb28000f9d15563c0ade89958f34d7da

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
<<<<<<< HEAD
                    //Console.WriteLine($"{item.Id}: {item.Name} ({item.Size} size), costs {item.Price} lv", Color.Orange);

                    string text = "{0}: {1} ({2} size), costs {3} lv";
                    string[] data = new string[]
                    {
                     item.Id.ToString(),
                     item.Name,
                     item.Size,
                     item.Price.ToString()
                    };

                    Console.WriteLineFormatted(text, Color.Salmon, Color.White, data);
                }

            }


            
=======
                    Console.WriteLine($"{item.Id}: {item.Name} ({item.Size} size), costs {item.Price:F2} lv");
                }

            }
>>>>>>> 5b8a688afb28000f9d15563c0ade89958f34d7da
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
<<<<<<< HEAD
            DisplayServicesAndActivities displayServicesAndActivities = new DisplayServicesAndActivities();
        }

        private Item GetById()
        {
            Item item = new Item();
            Console.WriteLine("\nEnter ID :");

            int value;
            if (!int.TryParse(Console.ReadLine(), out value))
            {
                Console.WriteLine("Input must be a number!", Color.Pink);
            }
            else
            {
                int id = value;
                item = rentalController.GetItem(id);
            }


            return item;
        }

        private string FirstCharToUpper(string input)
        {
            switch (input)
            {
                case null: throw new ArgumentNullException(nameof(input));
                case "": throw new ArgumentException($"{nameof(input)} cannot be empty", nameof(input));
                default: return input.First().ToString().ToUpper() + input.Substring(1);
            }
=======
            DisplayServicesAndActivities display = new DisplayServicesAndActivities();

>>>>>>> 5b8a688afb28000f9d15563c0ade89958f34d7da
        }


    }
<<<<<<< HEAD
}
=======
}
>>>>>>> 5b8a688afb28000f9d15563c0ade89958f34d7da
