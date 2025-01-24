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
            //Encap e = new Encap();
            //e.SetName("naveen");
            //Console.WriteLine(e.GetName());
            //BankAccount b = new BankAccount();
            //b.SetAccountNumber("3987598374");
            //b.SetBalance(7429387.23);
            //Console.WriteLine(b.GetAccountNumber());
            //Console.WriteLine(b.GetBalance());
            //Console.WriteLine("oops");
            //Cat c = new Cat();
            //c.Type();
            //HRManager hr = new HRManager();
            //hr.Work();
            //hr.addEmployee();
            //SavingsAccount sa = new SavingsAccount();
            //sa.Deposit(200);
            //sa.Withdraw(150);
            //sa.Withdraw(100);
            //sa.Balance();
            //Manager m = new Manager("naveen",12000,"developer",2);
            //Console.WriteLine(m.GetNumberOfManagers());
            //Console.WriteLine(m.CalculateBonus());
            //Developer d = new Developer("sai", 10000, "developer");
            //Console.WriteLine(d.GetName());
            //Console.WriteLine(d.CalculateBonus());
            //Console.WriteLine(d.PerformanceReport());
            //Programmer p = new Programmer("naveen", 10000, "developer");
            //Console.WriteLine(p.GetName());
            //Console.WriteLine(p.GetSalary());
            //Console.WriteLine(p.GetJobTitle());
            //Console.WriteLine(p.CalculateBonus());
            //Console.WriteLine(p.PerformanceReport())
            //Circle c = new Circle(5);
            //c.CalculateArea();
            //c.CalculatePerimeter();
            //c.Display();
            Car c = new Car(12, 2);
            Console.WriteLine(c.GetSpeed());
            c.SpeedUp();
        }
    }
}
