using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace List_objectives_StephanieLopez
{
    internal class BankAccount
    {
        // Fields
        private static readonly Random random_ = new Random(); // Used for account Number
        public string name_;
        public int accountnumber_;
        public double balance_;

        // Constructor
        public BankAccount(string Name, double Balance)
        {
            name_ = Name;
            balance_ = Balance;
            accountnumber_ = random_.Next(100000, 999999); // Generates a random 6-digit account number
        }

        // Properties
        public string Name_ { get => name_; set => name_ = value; }
        public int AccountNumber { get => accountnumber_; }
        public double Balance { get => balance_; }

        // Methods
        public virtual bool Deposit(double amount)
        {
            if (amount > 0)
            {
                balance_ += amount;
                return true;
            }
            else
            {
                return false;
            }
        }

        public virtual bool Withdraw(double amount)
        {
            if (amount > 0 && balance_ >= amount)
            {
                balance_ -= amount;
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
            return $"{this.GetType().Name} - {Name_} - Account Number: {AccountNumber} - Balance: {balance_:C}";
        }
    }
}