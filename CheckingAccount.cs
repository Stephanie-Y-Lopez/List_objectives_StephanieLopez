using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_objectives_StephanieLopez
{
    internal class CheckingAccount : BankAccount
    {
        // Field
        public double overdraftfee { get; set; }

        // Constructor
        public CheckingAccount(string Name, double Balance, double OverDraftFee) : base(Name, Balance)
        {
            overdraftfee = OverDraftFee;
        }

        // Method
        public override bool Withdraw(double amount)
        {
            bool success = base.Withdraw(amount);
            if (!success)
            {
                Balance -= overdraftfee; // Corrected to use the property instead of field
            }
            return success;
        }

        // Override ToString
        public override string ToString()
        {
            return base.ToString() + $" - Overdraft Fee: {overdraftfee:C}"; // Corrected to use the property instead of field
        }
    }
}