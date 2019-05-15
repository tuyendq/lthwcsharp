using System;

namespace hello
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello .NET Core on Ubuntu on Windows 10!");
            MyClass c1 = new MyClass();
            Console.WriteLine($"Favorite quote: {c1.ReturnMessage()}");
        }
    }
}
