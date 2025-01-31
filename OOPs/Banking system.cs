using System;

namespace OOPs
{
    public class Banking_system
    {
        private int balance;

        public void withdraw(int money)
        {
            balance = balance - money;
        }

        public void deposit(int money)
        {
            balance = balance + money;
        }

        public void showBalance(){
            Console.WriteLine("balance : "+balance);
        }
    }
}