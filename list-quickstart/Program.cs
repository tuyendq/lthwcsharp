using System;
using System.Collections.Generic;


namespace list_quickstart
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string> {"<name>", "Ana", "Felipe" };
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }

            // Add to list
            Console.WriteLine();
            names.Add("Maria");
            names.Add("Bill");
            // Remove from list
            names.Remove("Ana");
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }

            //List index
            Console.WriteLine($"My name is {names[0]}.");
            Console.WriteLine($"I've added {names[2]} and {names[3]} to the list.");

            // Count list
            Console.WriteLine($"This list has {names.Count} in it.");

            // Search and sort list
            var index = names.IndexOf("Felipe");
            if (index == -1)
            {
                Console.WriteLine($"When an item is not found, IndexOf returns {index}");
            } else
            {
                Console.WriteLine($"The name {names[index]} is at index {index}.");
            }

            index = names.IndexOf("Not Found");
            if (index == -1)
            {
                Console.WriteLine($"When an item is not found, IndexOf returns {index}.");
            } else
            {
                Console.WriteLine($"The name {names[index]} is at index {index}.");
            }
        }
    }
}
