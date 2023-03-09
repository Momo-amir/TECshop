using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TECshop
{
    class ShoppingCart
    {
        private List<ProductItem> items = new List<ProductItem>();

        public void Add(ProductItem item)
        {
            items.Add(item);
            Console.WriteLine($"{item.Name} added to shopping cart.");
        }

        public void Remove(string name)
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].Name == name)
                {
                    Console.WriteLine($"{name} removed from shopping cart.");
                    items.RemoveAt(i);
                    return;
                }
            }
            Console.WriteLine($"{name} not found in shopping cart.");
        }

        public void Display()
        {
            Console.WriteLine("Shopping Cart");
            Console.WriteLine();
            Console.WriteLine("Name\t\tCost");

            int totalCost = 0;

            foreach (ProductItem item in items)
            {
                Console.WriteLine($"{item.Name}\t\t{item.Cost} DKK");
                totalCost += item.Cost;
            }

            Console.WriteLine($"Total cost: {totalCost} DKK");
        }
    }
}

