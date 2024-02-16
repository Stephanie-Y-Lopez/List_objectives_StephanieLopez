using System.Collections.Generic;

namespace List_objectives_StephanieLopez
{
    //Stephanie Lopez
    internal class Program
    {
        static void Main(string[] args)
        {
            var accounts = new List<BankAccount>();

            var savingsAccount = new SavingsAccount("Savings", 0, 0.05);
            var checkingAccount = new CheckingAccount("Checking", 0, 35);
            var retirementAccount = new RetirementAccount("Retirement", 0, 0.08);

            accounts.Add(savingsAccount);
            accounts.Add(checkingAccount);
            accounts.Add(retirementAccount);

            foreach (var account in accounts)
            {
                account.Deposit(500);
                account.Deposit(-50000);
                account.Withdraw(200);
                account.Withdraw(-200000);
                account.Withdraw(1000);
                Console.WriteLine(account);
                Console.WriteLine();
            }
        }
    }
}