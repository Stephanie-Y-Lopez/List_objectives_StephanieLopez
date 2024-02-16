using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_objectives_StephanieLopez
{
    internal class SavingsAccount : BankAccount
    {
        // Field
        public double interest_ { set; get; }

        // Constructor
        public SavingsAccount(string name, double balance, double interest) : base(name, balance)
        {
            interest_ = interest; // Corrected variable names
        }

        // Property
        public double Interest { get => interest_; set => interest_ = value; } // Corrected variable names

        // Method
        public override bool Deposit(double amount)
        {
            if (base.Deposit(amount))
            {
                // If deposit is successful, add interest
                Balance += (Balance * Interest); // Corrected variable names
                return true;
            }
            else
            {
                return false;
            }
        }

        // Override ToString
        public override string ToString()
        {
            return $"{base.ToString()} - Interest: {Interest:P}"; // Corrected variable names
        }
    }
}