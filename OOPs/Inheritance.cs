using System;

namespace OOPs
{
     class Animal
    {

        public void Type()
        {
            Console.WriteLine("Animal...");
        }
    }


     class Cat : Animal
     {
            public void Specific()
            {
                Console.WriteLine("cat...");
            }
     }
        class Employee
        {
            public void Work()
            {
                Console.WriteLine("im working");
            }

            public void GetSalary()
            {
                Console.WriteLine("employee salary");
            }

        }

        class HRManager : Employee
        {
            public void Work()
            {
                Console.WriteLine("HR working");
            }

            public void addEmployee()
            {
                Console.WriteLine("add employee");
            }
        }

        class BAccount
        {
            protected int n = 0;
            public void Withdraw(int m)
            {
                n = n - m;
            }
            public void Deposit(int m)
            {
                n = n + m;
            }
            public void Balance()
            {
                Console.WriteLine("balance :" + n);
            }
        }

        class SavingsAccount : BAccount
        {
            public void Withdraw(int m)
            {
                if (n < 100)
                {
                    Console.WriteLine("cannot withdraw beacuse balance is less than hundred");
                    Balance();
                }
                else
                {
                    n = n - m;
                    Console.WriteLine("withdrawn from savings account :" + m);
                    Balance();
            }
            }
        }

        class Emp
        {
            private string name;
            private int salary;
            private string jobTitle;

            public Emp(string name,int salary,string jobTitle)
            {
                this.name = name;
            this.salary = salary;
            this.jobTitle = jobTitle;
        }
            public string GetName()
            {
                return name;
            }

            public int GetSalary()
            {
                return salary;
            }

            public string GetJobTitle()
            {
                return jobTitle;
            
            }

            public double CalculateBonus()
            {
                return 0.0;
            }

            public string PerformanceReport()
            {
                return "not available";
        }
            
        }
        class Manager : Emp
        {
            private int teamSize;
            public Manager(string name, int salary, string jobTitle, int teamSize) : base(name, salary, jobTitle)
        {
            this.teamSize = teamSize;
        }
            public int GetNumberOfManagers()
        {
            return teamSize;
        }

        public double CalculateBonus()
        {
            return 0.2 * GetSalary();
        }

        public string PerformanceReport()
        {
            return "good";
        }
    }

        class Developer : Emp
        {
            public Developer(string name, int salary, string jobTitle) : base(name, salary, jobTitle)
            {

            }
        public double CalculateBonus()
        {
            return 0.1 * GetSalary();
        }
        public string PerformanceReport()
        {
            return "average";
        }
    }

        class Programmer : Emp
        {
            public Programmer(string name, int salary, string jobTitle) : base(name, salary, jobTitle)
        {
        }
            public double CalculateBonus()
        {
            return 0.15 * GetSalary();
        }
        public string PerformanceReport()
        {
            return "good";
        }
    }


}