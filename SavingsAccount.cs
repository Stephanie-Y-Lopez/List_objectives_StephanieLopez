using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_objectives_StephanieLopez
{
    internal class SavingsAccount
    {
        //Field
        double interest_;

        //Constructor
        public SavingsAccount(string Name, double balance, double interest)
        {
            this.interest_ = interest;
        }

        //Property
        public double interest { get => interest; set => interest = value; }

        //Method
        public override bool Deposit(double amount)
        {
            if (base.Deposit(amount))
            {
                // If deposit is successful, add interest
                balance += (balance * interest);
                return true;
            }
            else
            {
                return false;
            }
        }

        //Override ToString
        public override string ToString()
        {
            return $"{base.ToString()} - Interest: {interest:P}";
        }
    }
}