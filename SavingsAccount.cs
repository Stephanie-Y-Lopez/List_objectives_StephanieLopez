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
        public SavingsAccount(string Name, double Balance, double interest) : base(Name, Balance)
        {
            interest_ = interest;
        }

        // Property
        public double Interest { get => interest_; set => interest_ = value; }

        // Method
        public override bool Deposit(double amount)
        {
            if (base.Deposit(amount))
            {
                // If deposit is successful, add interest
                balance_ += (balance_ * Interest);
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
            return $"{base.ToString()} - Interest: {Interest:P}";
        }
    }
}