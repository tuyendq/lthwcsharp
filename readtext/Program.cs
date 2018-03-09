using System;
using System.Collections.Generic;
using System.IO;

namespace readtext
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            // Read "sampleQuotes.txt" file
            string filename = "sampleQuotes.txt";
            var lines = ReadFrom(filename);
            //var lines = ReadFrom("sampleQuotes.txt");
            foreach (var line in lines)
            {
                Console.WriteLine(line);
            }

        }
        // ReadFrom method
        static IEnumerable<string> ReadFrom(string file)
        {
            string line;
            using (var reader = File.OpenText(file))
            {
                while ((line = reader.ReadLine()) != null)
                {
                    yield return line;
                }
            }
        }

    }
}
