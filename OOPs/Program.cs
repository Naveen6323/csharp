using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Encap e = new Encap();
            e.SetName("nveen");
            Console.WriteLine(e.GetName());
            BankAccount b = new BankAccount();
            b.SetAccountNumber("3987598374");
            b.SetBalance(7429387.23);
            Console.WriteLine(b.GetAccountNumber());
            Console.WriteLine(b.GetBalance());

        }
    }

    public class Encap
    {
        private string name;
        private int age;
        private string country;

        public string GetName()
        {
            return name;
        }

        public void SetName(string name)
        { 
            this.name = name;
        }

        public int GetAge()
        {
            return age;
        }
        public void SetAge(int age)
        {
            this.age = age;
        }

        public string gGetCountry()
        {
            return country;
        }
        public void SetCountry(string country)
        {
            this.country = country;
        }
    }

    public class BankAccount
    {
        private double balance;
        private string accountNumber;
        public string GetAccountNumber()
        {
            return accountNumber;
        }
        public void SetAccountNumber(string accountNumber)
        {
            this.accountNumber = accountNumber;
        }
        public double GetBalance()
        {
            return balance;
        }
        public void SetBalance(double balance)
        {
            this.balance = balance;
        }
    }
}
