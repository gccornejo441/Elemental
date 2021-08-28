using System;
using System.Collections.Generic;

namespace ScopeTestingDotNET5
{
    class Program
    {
        static void Main(string[] args)
        {
            IDictionary<string, Language> _allProducts = new Dictionary<string, Language>
            {
                {"csharp", new Language("csharp", "C#")},
            };


        Language GetLanguage(string name)
        {
            if (_allProducts.TryGetValue(name, out var product))
            {
                    Console.WriteLine("Get Lang: {0}", product.Item);
            }
            return null;
        }

            Console.WriteLine("Get Language: {0}", GetLanguage("csharp"));

        }
    }
}
   



