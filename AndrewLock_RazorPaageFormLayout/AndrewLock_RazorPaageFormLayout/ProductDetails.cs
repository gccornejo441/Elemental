using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AndrewLock_RazorPaageFormLayout
{
    public class ProductDetails
    {
        public string ProductName { get; set; }
        public decimal SellPrice { get; set; }
        public int QuantityInStock { get; set; }

        public ProductDetails(string productName, decimal sellPrice, int qty)
        {
            ProductName = productName;
            SellPrice = sellPrice;
            QuantityInStock = qty;
        }
    }
}
