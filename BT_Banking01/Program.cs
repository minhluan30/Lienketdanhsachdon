using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_Banking01
{
    class Account
    {
        private double _balace;
        public Account() { }
        public Account(double balance)
        {
            this._balace = balance;
        }

        protected double Balance
        {
            set { _balace = value; }
            get { return _balace; }
        }
        public virtual bool WithDraw(double amount)
        {
            return false;
        }
        public virtual bool Deposit(double amount)
        {
            return false;
        }
        public void PrintBalance()
        {
            Console.WriteLine("Balance: {0}", _balace);
        }
        class SavigAccount : Account
        {
            private double _interesRate = 0.8;

            public SavigAccount() : base() { }
            public SavigAccount(double balance) : base(balance)
            {
            }
            public double InteresRate
            {
                set { _interesRate = value; }
                get { return _interesRate; }
            }
            public override bool WithDraw(double amount)
            {
                return base.WithDraw(amount);
            }
            public override bool Deposit(double amount)
            {
                return base.Deposit(amount);
            }
        }
        class CheckingAccount : Account
        {
            public CheckingAccount() : base() { }
            public CheckingAccount(double balance) : base(balance)
            {
            }
            public override bool WithDraw(double amount)
            {
                return false;
            }
            public override bool Deposit(double amount)
            {
                return false;
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                Account ac1 = new SavigAccount(200);
                Console.WriteLine("Saving Account");
                ac1.Deposit(100);
                ac1.PrintBalance();

                Account ac2 = new SavigAccount(200);
                Console.WriteLine("Saving Account");
                ac2.Deposit(100);
                ac2.PrintBalance();

                Console.ReadLine();
            }
        }
    }
}
