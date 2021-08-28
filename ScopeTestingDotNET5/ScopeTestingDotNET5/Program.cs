using System;
using System.Collections.Generic;
using System.Linq;

namespace ScopeTestingDotNET5
{
    class Program
    {
        static void Main(string[] args)
        {
            IDictionary<string, Product> _allProducts = new Dictionary<string, Product>
            {
                {"cheese-danish", new Product("Cheese Danish", 1) }
            };


             Product GetProduct(string name)
            {
                if (_allProducts.TryGetValue(name, out var value))
                {
                    return value;
                }
                return null;
            }


            List<Product> Search(string term, StringComparison comparisonType)
            {
                return _allProducts
                    .Where(x => x.Value.Name.Contains(term, comparisonType))
                    .Select(x => x.Value)
                    .ToList();
            }

            Console.WriteLine(Search("cheese-danish", StringComparison.Ordinal));
        }
    }
}
   



