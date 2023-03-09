using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TECshop
{
    class ProductItem
    {
        public string Name { get; set; }
        public int Cost { get; set; }

        public ProductItem(string name, int cost)
        {
            Name = name;
            Cost = cost;
        }
    }
}
