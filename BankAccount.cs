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
        //Fields
        static Random random_ = new Random(); //Used for account Number
        private string name_;
        private int accountnumber_;
        private double balance;

        //Constructor
        public BankAccount(string Name, int AccountNumber, int balance)
        {
            this.Name_ = Name;
            this.accountnumber_ = random_.Next(100000, 999999); //This will generate a 6 digit random account number for the account!
            this.balance = balance;
        }

        //Properties
        public string Name_ { get => name_; set => name_ = value; }
        public int AccountNumber { get => accountnumber_;}
        public double Balance { get => balance;}

        //Methods
        public virtual bool Deposit(double amount)
        {
            if(amount > 0)
            {
                balance += amount;
                return true;
            }
            else
            {
                return false;
            }
        }
        public virtual bool Withdraw(double amount)
        {
            if (amount > 0 && balance >= amount)
            {
                balance -= amount;
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
            return $"{this.GetType().Name} - {Name_} - Account Number: {AccountNumber} - Balance: {balance:C}";
        }
    }
}
