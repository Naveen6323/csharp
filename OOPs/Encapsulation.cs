namespace OOPs
{
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