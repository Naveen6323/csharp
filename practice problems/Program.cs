using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
//using OOPs;
namespace practice_problems
{
    internal class Program
    {

        //public int add(int n, int m)
        //{
        //    return n+m;

        //}

        //public double armstring(int n)
        //{
        //    int m = n;
        //    double res = 0;
        //    int counter = 0;
        //    while (m > 0)
        //    {
        //        m = m / 10;
        //        counter++;
        //    }

        //    while (n > 0)
        //    {

        //        res = res + Math.Pow(n % 10, counter);
        //        n = n / 10;
        //    }
        //    return res;
        //}

        //public int lcm(int n, int m)
        //{
        //    //int res = 0;
        //    if (n > m && n % m == 0) return n;
        //    else if (m > n && m % n == 0) return m;
        //    else if (n > m)
        //    {
        //        for (int i = 1; i < m; i++)
        //        {
        //            if ((n * i) % m == 0) return n * i;
        //        }
        //    }
        //    else
        //    {
        //        for (int i = 1; i < n; i++)
        //        {
        //            if ((m * i) % n == 0) return m * i;
        //        }
        //    }

        //    return n * m;

        //}

        //public List<int> primenums(int n)
        //{
        //    List<int> l = new List<int>();
        //    bool ist = true;
        //    for (int i = 2; i <= n; i++)
        //    {
        //        for (int j = 2; j < i; j++)
        //        {
        //            if (i % j == 0)
        //            {
        //                ist = false;
        //                continue;
        //            }
        //        }

        //        if (ist == true) l.Add(i);
        //        ist = true;

        //    }

        //    return l;
        //}

        //public static void Employee()
        //{
        //    Random rn = new Random();
        //    int mark = rn.Next(0, 2);

        //    int wagePerHr = 20;
        //    int fullDayHr = 8;
        //    int partTimeHr = 4;
        //    int workingDaysForMonth = 20;
        //    int dailyWageEmployee = wagePerHr * fullDayHr;
        //    int partTimWageEmployee = wagePerHr * partTimeHr;
        //    int wageForMonth = wagePerHr * fullDayHr * workingDaysForMonth;
        //    int wageForCondition = 100 * wagePerHr;
        //    bool loop = true;
        //    while (loop)
        //    {
        //        Console.WriteLine("1 Attendence\n2 DailyWage\n3 PartTimeWage\n4 wageForMonth \n5 WageForCondition\n6 exit");
        //        int select = int.Parse(Console.ReadLine());
        //        switch (select)
        //        {
        //            case 1:
        //                if (mark == 1) Console.WriteLine("prsent");
        //                else Console.WriteLine("absent");
        //                break;
        //            case 2:
        //                Console.WriteLine("DailyWage : " + dailyWageEmployee);
        //                break;
        //            case 3:
        //                Console.WriteLine("PartTimeWage : " + partTimWageEmployee);
        //                break;
        //            case 4:
        //                Console.WriteLine("wageForMonth : " + wageForMonth);
        //                break;
        //            case 5:
        //                Console.WriteLine("Wage for Condition : "+wageForCondition);
        //                break;
        //           case 6:
        //                loop = false;
        //                break;
        //            default:
        //                Console.WriteLine("number is not present");
        //                break;

        //        }
        //    }

        //}

        //public void ShowGrade(int n)
        //{
        //    if(n>89) Console.WriteLine("A");
        //    else if (n > 79 && n<90) Console.WriteLine("B");
        //    else if (n > 69 && n<80) Console.WriteLine("C");
        //    else if (n > 59 && n<70) Console.WriteLine("D");
        //    else Console.WriteLine("F");
        //}



        //public void TemperatureConverter()
        //{
        //    Console.WriteLine("Temperature Converter");
        //    Console.WriteLine("Select conversion type:");
        //    Console.WriteLine("1. Celsius to Fahrenheit");
        //    Console.WriteLine("2. Fahrenheit to Celsius");

        //    string choice = Console.ReadLine();

        //    double temperature;

        //    switch (choice)
        //    {
        //        case "1":
        //            Console.Write("Enter temperature in Celsius: ");
        //            temperature = Convert.ToDouble(Console.ReadLine());
        //            Console.WriteLine(temperature+"c is equal to "+((temperature*9/5)+32)+"f");
        //            break;

        //        case "2":
        //            Console.Write("Enter temperature in Fahrenheit: ");
        //            temperature = Convert.ToDouble(Console.ReadLine());
        //            Console.WriteLine(temperature+"F is equal to "+((temperature-32)*5/9 )+"C");
        //            break;

        //        default:
        //            Console.WriteLine("Invalid choice. Please select 1 or 2.");
        //            break;
        //    }
        //}

        //public void TicketPrice()
        //{
        //    int child = 60;
        //    int adult = 100;
        //    int senior = 80;
        //    float matinee = 1.5f;
        //    Console.Write("enter age : ");
        //    int age = int.Parse(Console.ReadLine());
        //    Console.Write("enter time in 24hr format : ");
        //    int time = int.Parse(Console.ReadLine());
        //    bool isMatinee = false;
        //    if (time < 18) isMatinee = true;
        //    if (age < 12)
        //    {
        //        if (isMatinee) Console.WriteLine("ticket price : " + child);
        //        else Console.WriteLine("ticket price :" + matinee*child);
        //    }
        //    else if (age >= 12 && age < 65)
        //    {
        //        if (isMatinee) Console.WriteLine("ticket price : " +  adult);
        //        else Console.WriteLine("ticket price :" + matinee*adult);
        //    }
        //    else
        //    {
        //        if (isMatinee) Console.WriteLine("ticket price : " + senior);
        //        else Console.WriteLine("ticket price :" + matinee*senior);
        //    }
        //}

        //public void Verify(string user,string password)
        //{
        //    Dictionary<string, string> d = new Dictionary<string, string>();
        //    d.Add("naveen", "naveen123");
        //    d.Add("sai", "sai123");
        //    if (d.ContainsKey(user))
        //    {
        //        if (password.Equals(d[user])) Console.WriteLine("login succesfull");
        //        else Console.WriteLine("password is incorrect");
        //    }
        //    else Console.WriteLine("user not exist");
        //}
        

        static void Main(string[] args)
        {
           
            Review_1.SwapNums(3,7);
            //Review_1.Conversion();
            //Review_1.FibonacciSeries(7);
            //Console.WriteLine();
            //Review_1.MultiplicationTable(3);
            //Circle c = new Circle(4);
            //c.CalculateArea();
            //Rectangle r = new Rectangle(4, 5);
            //r.CalculateArea();
            //Triangle t = new Triangle(2, 3);
            //t.CalculateArea();

            //Console.WriteLine("child class with same project--------");
            //Program p = new Program();
            //Console.WriteLine(" non child class in same project----------");
            //SecondChild sc = new SecondChild();
            //sc.a(); sc.c(); sc.e();







            Action<object> cw = Console.WriteLine;
            //int x1 = 1;
            //int y1 = 3;
            //int x2 = 4;
            //int y2 = 5;
            //double len = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            ////Console.WriteLine(len);
            ////double length = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));
            //int line1 = 33;
            //int line2 = 43;
            ////if (line1.Equals(line2)) Console.WriteLine("equal");
            ////else Console.WriteLine("not equal");


            //int x = line1.CompareTo(line2);
            //if (x == 1) Console.WriteLine("line1 is greater");
            //else if (x == -1) Console.WriteLine("line 2 is greater");
            //else Console.WriteLine("lines are equal");

            //p.ShowGrade(56);
            //p.TemperatureConverter();
            //p.TicketPrice();
            //p.Verify("naveen", "naveen3");
            //cw("hello");
            //List<int> l = new List<int>();
            //HashSet<int> h = new HashSet<int>();
            //h.Add(1);
            //l.Sort();
            //Person p = new Person("naveen",423);

            //p.SetAge(-1); ;
            //cw(p.GetName());
            //cw(p.GetAge());
            //Circle c = new Circle(5);
            //c.GetArea();
            //Square s = new Square(5);
            //s.GetArea();
            //Calculator cal  = new Calculator();
            //cal.Add(1,3.4423422,2.23);
            //CreditCardPayment c = new CreditCardPayment();
            //c.ProcessPayment();
            //CashPayment cp = new CashPayment();
            //cp.ProcessPayment();
            //PartTimeEmployee p = new PartTimeEmployee(1000);
            //p.Calculate();
            //FullTimeEmployee f = new FullTimeEmployee(1000);
            //f.Calculate();
            //Product p = new Product("apple", 30, 10);
            //p.GetTotalValue();
            //Book b = new Book();
            //b.AddBook("oops");
            //b.AddBook("c#");
            //b.RemoveBook("java");
            //b.GetAllBooks();
            string s = "nalkdjf";
            cw(" : "+s.IndexOf(s.Substring(0, 2)));





        }

        
        
    }
    class SecondChild : Child
    {

    }

    public class Child
    {
        public void a()
        {
            Console.WriteLine("public");
        }

        private void b()
        {
            Console.WriteLine("private");
        }

        internal void c()
        {
            Console.WriteLine("internal");
        }

        protected void d()
        {
            Console.WriteLine("protected");
        }
        protected internal void e()
        {
            Console.WriteLine("protected internal");
        }
    }

    //class Rectangle
    //{
    //    private int length;
    //    private int breadth;
    //    public void SetLength(int length)
    //    {
    //        this.length = length;
    //    }
    //    public void SetBreadth(int breadth)
    //    {
    //        this.breadth = breadth;
    //    } 
    //    public int GetArea()
    //    {
    //        return length * breadth;
    //    }

    //}

    class Person
    {
        private string name;
        private int age;
        public Person(string name,int age)
        {
            this.name = name;
            if(age<0) Console.WriteLine("age cannot be negative");
            else this.age = age;
        }
        //public void SetAge(int age)
        //{
        //    if(age<0) Console.WriteLine("age cannot bo negative");
        //    else this.age = age;
        //}
        public string GetName()
        {
            return name;
        }
        public int GetAge()
        {
            return age;
        }
    }

    //class Shape
    //{
    //    public void GetArea()
    //    {
    //        Console.WriteLine("Shape ");
    //    }
    //}
    //class Circle : Shape
    //{
    //    private int radius;
    //    public Circle(int radius)
    //    {
    //        this.radius = radius;
    //    }
    //    public void GetArea()
    //    {
    //        Console.WriteLine("area of circle : " + Math.PI * radius * radius);
    //    }
    //}
    //class Square : Shape
    //{
    //    private int side;
    //    public Square(int side)
    //    {
    //        this.side = side;
    //    }
    //    public void GetArea()
    //    {
    //        Console.WriteLine("area of square : " + side * side);
    //    }
    //}

    class Animal
    {
        public void MakeSound()
        {
            Console.WriteLine("animal sound");
        }
    }
    class Dog : Animal
    {
        public void MakeSound()
        {
            Console.WriteLine("bark");
        }
    }
    class Cat: Animal
    {
        public void MakeSound()
        {
            Console.WriteLine("meow");
        }
    }

    class Calculator
    {
        public void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public void Add(double a, double b, double c)
        {
            Console.WriteLine(a + b + c);
        }   
    }

     class Payment
    {
        public void ProcessPayment()
        {
            Console.WriteLine("payment process");
        }

    }

    class CreditCardPayment : Payment
    {
        public void ProcessPayment()
        {
            Console.WriteLine("credit card payment");
        }
    }
    class CashPayment : Payment
    {
        public void ProcessPayment()
        {
            Console.WriteLine("cash payment");
        }
    }

    abstract class Vehicle
    {
        public abstract void Start();
    }
    class Bike : Vehicle
    {
        public override void Start()
        {
            Console.WriteLine("bike start");
        }
    }
    class Car : Vehicle
    {
        public override void Start()
        {
            Console.WriteLine("car start");
        }
    }

    abstract class CalculateSalary
    {
        public abstract void Calculate();


    }

    class FullTimeEmployee : CalculateSalary
    {
        private int salary;
        public FullTimeEmployee(int salary)
        {
            this.salary = salary;
        }
        override
        public void Calculate()
        {
            Console.WriteLine("salary : " + salary);
        }
    }
    class PartTimeEmployee : CalculateSalary
    {
        private int salary;
        public PartTimeEmployee(int salary)
        {
            this.salary = salary;
        }
        override
        public  void Calculate()
        {
            Console.WriteLine("salary : " + salary*0.5);
        }
    }

    class Product
    {
        private string name;
        private double price;
        private int quantity;
        public Product(string name, double price, int quantity)
        {
            this.name = name;
            this.price = price;
            this.quantity = quantity;
        }
        public void GetTotalValue()
        {
            Console.WriteLine($"total price of  {name} :" + price * quantity);
        }
    }
    class Library
    {
        protected List<string> l = new List<string>();
        
        public void GetAllBooks()
        {
            Console.WriteLine("books : ");
            foreach (var i in l)
            {
                Console.WriteLine(i);
            }
        }
    }

    class Book : Library
    {
        
        public void AddBook(string book)
        {
            if(l.Contains(book)) Console.WriteLine("book already exist");
            else l.Add(book);
        }
        public void RemoveBook(string book)
        {
            if (l.Contains(book)) l.Remove(book);
            else Console.WriteLine($"{book} book not exist in library");
        }
    }
}
