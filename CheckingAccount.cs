using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_objectives_StephanieLopez
{
    internal class CheckingAccount
    {
        //Field
        private double overdraftfee;

        //Constructor
        public CheckingAccount(string Name, double balance, double OverDraftFee)
        {
            this.overdraftfee = OverDraftFee;
        }

        //Property
        public double Overdraftfee { get => overdraftfee; set => overdraftfee = value; }

        //Method
        public override bool Withdraw(double amount)
        {
            if (!base.Withdraw(amount))
            {
                // Withdraw failed, deduct overdraft fee
                base.Withdraw(overdraftfee);
            }
            return true;
        }


        //Override ToString
        public override string ToString()
        {
            return $"{base.ToString()} - Overdraft Fee: {overdraftfee:C}";
        }

    }
}
