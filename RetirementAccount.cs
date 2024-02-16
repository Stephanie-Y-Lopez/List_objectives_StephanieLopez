using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_objectives_StephanieLopez
{
    internal class RetirementAccount : SavingsAccount
    {
        public RetirementAccount(string Name, double Balance, double interest) : base(Name, Balance, interest) // Corrected variable names
        {
        }

        // Method
        public new bool Withdraw(double amount)
        {
            Console.WriteLine("Cannot withdraw from a retirement account");
            return false;
        }
    }
}
