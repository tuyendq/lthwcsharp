using System;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Tuyen", 100000000000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner}.");

            // Let't make some transactions to check
            account.MakeWithdrawal(1000000, DateTime.Now, "Rent payment");
            Console.WriteLine(account.Balance);
            account.MakeDeposit(100000000, DateTime.Now, "March 2018 salary");
            Console.WriteLine(account.Balance);

            // Test that the initial balances must be positive:
            try
            {
                var invalidAccount = new BankAccount("invalid", -55);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Exception caught creating account with negative balance.");
                Console.WriteLine(e.ToString());
            }

            // Test for a negative balance
            try
            {
                account.MakeWithdrawal(200000000000000, DateTime.Now, "funding WHO's project");
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("Exception caught trying to overdraw.");
                Console.WriteLine(e.ToString());
            }

            // Report all transactions
            Console.WriteLine(account.GetAccountHistory());


            // Play with Book class
            Book book1 = new Book("The Alchemist", "Paulo Coelho", 172);
            System.Console.WriteLine(book1.GetDescription());
        }
    }
}
