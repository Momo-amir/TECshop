using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TECshop.TECshop;

namespace TECshop
{
    class Product
    {
        private List<ProductItem> items = new List<ProductItem>();

        public Product()
        {
            items.Add(new ProductItem("t-shirt", 100));
            items.Add(new ProductItem("hoodie", 450));
            items.Add(new ProductItem("jeans", 700));
            items.Add(new ProductItem("shirt", 275));
        }

        public ProductItem FindProduct(string name)
        {
            foreach (ProductItem item in items)
            {
                if (item.Name == name)
                {
                    return item;
                }
            }
            return null;
        }

        public void Display()
        {
            Console.WriteLine("Products");
            Console.WriteLine();
            Console.WriteLine("Name\t\tCost");

            foreach (ProductItem item in items)
            {
                Console.WriteLine($"{item.Name}\t\t{item.Cost} DKK");
            }
        }
    }
}
