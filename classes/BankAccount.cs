using System;

namespace classes
{
    public class BankAccount
    {
        private static int accountNumberSeed = 1234567890;
        public string Number { get; }
        public string Owner { get; set; }
        public decimal Balance { get; }

        public void MakeDeposit(decimal amount, DateTime date, string note)
        {

        }

        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {

        }

        public BankAccount(string name, decimal initialBalance)
        {
            this.Owner = name;
            this.Balance = initialBalance;
            this.Number = accountNumberSeed.ToString();
            accountNumberSeed++;
        }
    }


}