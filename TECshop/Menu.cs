using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TECshop.TECshop;

namespace TECshop
{
    class Menu
    {
        private Product products = new Product();
        private ShoppingCart cart = new ShoppingCart();

        public void Display()
        {
            Console.WriteLine("Welcome to the TECshop");
            Console.WriteLine();

            while (true)
            {
                Console.WriteLine("1. Display Products");
                Console.WriteLine("2. Add Product to Shopping Cart");
                Console.WriteLine("3. Remove Product from Shopping Cart");
                Console.WriteLine("4. Display Shopping Cart");
                Console.WriteLine("5. Exit");
                Console.WriteLine();

                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();
                Console.WriteLine();

                switch (choice)
                {
                    case "1":
                        products.Display();
                        break;
                    case "2":
                        Console.Write("Enter the name of the product you want to add: ");
                        string productName = Console.ReadLine();
                        cart.Add(products.FindProduct(productName));
                        break;
                    case "3":
                        Console.Write("Enter the name of the product you want to remove: ");
                        string removeProductName = Console.ReadLine();
                        cart.Remove(removeProductName);
                        break;
                    case "4":
                        cart.Display();
                        break;
                    case "5":
                        Console.WriteLine("Thank you for shopping at TECshop!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

                Console.WriteLine();
            }
        }
    }
}
