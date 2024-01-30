using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_objectives_StephanieLopez
{
    internal class RetirementAccount
    {
        public RetirementAccount(string v1, int v2, double v3)
        {
        }

        //Method
        public new bool Withdraw(double amount)
        {
            Console.WriteLine("Cannot withdraw from a retirement account");
            return false;
        }
    }
}
