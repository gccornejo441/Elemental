using System;
using System.Collections.Generic;

namespace ScopeTestingDotNET5
{
    class Program
    {
        static void Main(string[] args)
        {
            IDictionary<string, string> openWith = new Dictionary<string, string>();

            openWith.Add("txt", "notepad.exe");
            openWith.Add("bmp", "paint.exe");
            openWith.Add("dib", "paint.exe");
            openWith.Add("rtf", "wordpad.exe");

            try
            {
                openWith.Add("txt", "winword.exe");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("An element with Key = \"txt\" already exists.");
            }

            // can omit its name when accessing elements.
            Console.WriteLine("For key = \"rtf\", value = {0}.",
                openWith["rtf"]);

            openWith["rtf"] = "winword.exe";
            Console.WriteLine("For key = \"rtf\", value = {0}.",
                openWith["rtf"]);

            if (openWith.TryGetValue("tif", out var value))
            {
                Console.WriteLine("For key = \"tif\", value = {0}.", value);
            }
            else
            {
                Console.WriteLine("Key = \"tif\" is not found.");
            }

        }
    }
}
