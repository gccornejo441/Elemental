using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScopeTestingDotNET5
{
    public class Product
    {
        public Product(string name, int qty)
        {
            Name = name;
            Quantity = qty;
        }

        public string Name;
        public int Quantity;
    }
}
