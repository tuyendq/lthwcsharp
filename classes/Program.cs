using System;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Tuyen", 100000000000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner}.");
        }
    }
}
