using System.Collections.Generic;

namespace List_objectives_StephanieLopez
{
    //Stephanie Lopez
    internal class Program
    {
        static void Main(string[] args)
        {
            List<BankAccount> accounts = new List<BankAccount>
            { };
            {
                new SavingsAccount("Savings Account", 1000, 0.05);
                new CheckingAccount("Checking Account", 1500, 25);
                new RetirementAccount("Retirement Account", 20000, 0.08);
            }

            foreach (var account in accounts)
            {
                account.Deposit(500);
            }

            foreach (var account in accounts)
            {
                account.Deposit(-50000);
            }

            foreach (var account in accounts)
            {
                account.Withdraw(200);
            }

            foreach (var account in accounts)
            {
                account.Withdraw(-200000);
            }

            foreach (var account in accounts)
            {
                account.Withdraw(2000);
            }

            //Displaying results!
            foreach (var account in accounts)
            {
                Console.WriteLine(account);
            }
        }
    }
}