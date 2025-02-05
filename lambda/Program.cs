using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace lambda
{
    class Employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public int salary { get; set; }
        public string department { get; set; }

        public Employee(int id, string name, int age,int salary, string department)
        {
            this.name = name;
            this.age = age;
            this.id = id;
            this.salary = salary;
            this.department = department;
        }
        public override string ToString()
        {
            return $"[id = {id}, name = {name}, age={age},salary = {salary}]";
        }

    }

    class Student
    {
        public string name { get; set; }
        public int math { get; set; }
        public int english { get; set; }
        public int science { get; set; }

        public Student(string name, int math, int english, int science)
        {
            this.name = name;
            this.math = math;
            this.english = english;
            this.science = science;

        }

        public override string ToString()
        {
            return $"[name = {name}, Math = {math}, eng = {english}, sci = {science}";
        }
    }
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
        public DateTime Data { get; set; }
        public Product(string name, double price, int stock, DateTime data)
        {
            Name = name;
            Price = price;
            Stock = stock;
            Data = data;
        }

        public override string ToString()
        {
            return $"Product: {Name}, Price: {Price:C}, Stock: {Stock}";
        }
    }
    public class Names
    {
        public string name { get; set; }

        public Names(string name)
        {
            this.name = name;
            
        }
    }

    public class Calc
    {
        //overload
        public void add(int n, int m)
        {
            Console.WriteLine("sum is "+n+m);
        }

        public void add(double n, double m)
        {
            Console.WriteLine("sum is "+n+m);
        }
    }

    public class Addition : Calc
    {
        //override
        public void add(int n, int m)
        {
            Console.WriteLine(n+m+" is the sum of "+n+" and "+m);
        }
    }
    internal class Program
    {

        

        public class Calculator
        {
            public void addition(int n, int m)
            {
                Console.WriteLine("sum is "+n+m);

            }
            public void addition(float n, float m)
            {
                Console.WriteLine("sum is " + n + m);

            }
            public void addition(double n, double m)
            {
                Console.WriteLine("sum is " + n + m);

            }
        }
        static void Main(string[] args)
        {
            

            int[] arr = { 2, 35, 1, 6, 7, 41, 3 };
            double[] d = { 1.2, 4.3, 3.2 };
            string[] str = { "naveen","fb.com", "vishal", "vaibhav","Abhi","googel.com" };
            char[] ch = { 'a', 'b', 'e', 'c' };
            //MaxinArray.MaxInArray(arr);
            
            Names[] names = new Names[3];
            names[0] = new Names("naveen");
            names[1] = new Names("sam");
            names[2] = new Names("thanos");
            //MaxInArray(names);


            List<Employee> emp = new List<Employee>()
            {
                new Employee(1,"naveen",22,47000,"IT"),
                new Employee(2,"vishal",18,50000, "IT"),
                new Employee(3,"vaibhav",23,65000, "Electronics"),
                new Employee(6,"sam",44,35000, "Sales")
            };
            emp.Add(new Employee(5, "sam", 45,56000, "Sales"));
            List<Student> st = new List<Student>()
            {
                new Student("naveen",87,22,65),
                new Student("vishal", 75, 60, 65)
            };
            List<Product> product = new List<Product>()
            {
                new Product("Laptop", 999.99, 10,new DateTime(2024,2,1)),
                new Product("Smartphone", 499.99, 0,new DateTime(2025,1,1)),
                new Product("Tablet", 299.99, 0,new DateTime(2025,1,23))
            };
            //emp.ForEach(n =>
            //{
            //    Console.WriteLine($"id={n.id},name={n.name},age={n.age}");
            //});
            emp.RemoveAll(x => x.name == "vishal");
            //emp.ForEach(x =>
            //{
            //    if (x.name == "pranshu")
            //    {
            //        Console.WriteLine("searched employee is");
            //        Console.WriteLine($"id={x.id}, name={x.name},age={x.age}");

            //    }
            //});
            var sortedEmployeeByName = emp.OrderBy(x => x.name);
            var sortedEmployeeByAge = emp.OrderBy(x => x.age);
            var reversSortedEmployeeByName = emp.OrderByDescending(x => x.name);

            List<int> numbers = new List<int> { 8, 56, 8, 9,15,30, 2, 1,1, 5,-4 };
            List<int> numbers2 = new List<int> { 3,5,2,6,56,4,1,9};

            List<int> evennums = numbers.FindAll(n => n % 2 == 0);
            List<int> oddnums = numbers.FindAll(n => n % 2 == 1);


            // problems on Lambda----------------------------------------------
            var even = from n in numbers where n % 2 == 0 select n;
            var stringStartWithA = from n in str where n[0] == 'A' select n;
            var desc = numbers.OrderByDescending(n => n);
            var check = from n in numbers select n > 50;
            int stringGreaterThan5 = str.Count(n => n.Length > 5);
            var distinct = numbers.Distinct();
            int sum = numbers.Where(n => n % 2 == 1).Sum();
            int max = numbers.Max();
            var listOfSquares = from n in numbers select n * n;
            var endingWithDotCom = from n in str where n.EndsWith(".com") select n;
            var grroupByFirstLetter = str.GroupBy(n => n[0]);
            //foreach (var group in grroupByFirstLetter)
            //{
            //    Console.WriteLine($"Grade: {group.Key}");
            //    foreach (var student in group)
            //    {
            //        Console.WriteLine($" - {student}");
            //    }
            //}
            var top3 = numbers.OrderByDescending(n => n).Take(3);
            var salaryGreaterThanFiftyThousand = from n in emp where n.salary > 50000 select n;
            //foreach (var VARIABLE in salaryGreaterThanFiftyThousand)
            //{
            //    Console.WriteLine(VARIABLE.ToString());
            //}
            var checkAllPositive =numbers.All(n=>n>0);
            var firstNumberDivisibleBy3And5 = numbers.Where(n => n % 3 == 0 && n % 5 == 0).Take(1);
            var studentWithMarksGreaterThan80 =
                from s in st where s.english > 80 || s.math > 80 || s.science > 80 select s;
            //foreach (var VARIABLE in studentWithMarksGreaterThan80)
            //{
            //    Console.WriteLine(VARIABLE.ToString());
            //}
            var longestString = str.OrderByDescending(n => n.Length).Take(1);
            var outOfStockProducts = from p in product where p.Stock==0 select p;
            var averageOFNumbers = numbers.Average();
            var secondHighest = numbers.OrderByDescending(n => n).Skip(1).First();
            List<List<int>> nlist = new List<List<int>>()
            {
                new List<int>() { 1, 2, 3 },
                new List<int>() { 4, 5, 6 }
            };
            var flattenList = nlist.SelectMany(n => n).ToList();
            var commonnums = from a in numbers from b in numbers2 where a == b select a;
            var averageSalaryOfEachDepartment = from n in emp
                group n by n.department into e
                select new { department = e.Key, averageSalary = e.Average(g => g.salary) };
            var average = emp.GroupBy(e => e.department)
                .Select(e => new { depart = e.Key, average = e.Average(s => s.salary) });

            //foreach (var VARIABLE in averageSalaryOfEachDepartment)
            //{
            //    Console.WriteLine($"department = {VARIABLE.department} , salary = {VARIABLE.averageSalary}");
            //}
            DateTime currdate = DateTime.Now;
            DateTime pdo = new DateTime(2024, 4, 3);
            var productsLastPurchased = from p in product
                where (currdate - p.Data).TotalDays <= 30 select p;
            //foreach (var p in productsLastPurchased)
            //{
            //    Console.WriteLine(p);
            //}

            var youngestEmployee = from e in emp
                group e by e.department
                into x
                select x.OrderBy(e => e.age).FirstOrDefault();
            //foreach (var VARIABLE in youngestEmployee)
            //{
            //    Console.WriteLine(VARIABLE);
            //}

            ExceptionHandling.Divide();
            //try
            //{
            //    ExceptionHandling.PrintAge(-1);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
                
            //}  




            //foreach (var even in evennums)
            //{
            //    Console.WriteLine(even);
            //}
            //foreach (var odd in oddnums)
            //{
            //    Console.WriteLine(odd);
            //}
            //Dictionary<string, int> dict = new Dictionary<string, int>();
            //dict.Add("sam",1);
            //dict.Add("nick",2);
            ////var major = emp.FindAll(x => x.name[0] == 'v');

            //var nameWithV = emp.Select(x => x.name[0]=='v');
            //var sortedEmployeeByAge = emp.OrderBy(x => x.age);
            //foreach (var employee in sortedEmployeeByAge)
            //{
            //    Console.WriteLine($"id={employee.id},name={employee.name},age={employee.age}");
            //}

            //emp = emp.FindAll(x => x.name != "naveen");
            //emp.RemoveAll(x => x.name == "naveen");
            ////emp.ForEach(n=>{ Console.WriteLine($"id={n.id},name={n.name},age={n.age}"); });
            //emp.ForEach(h=>h.ToString());
            //SortedSet<int> s = new SortedSet<int>(){ 3, 2, 3, 1, 2, 4, 5, 5, 6};
            //Console.WriteLine(5&1);

            /// Console.WriteLine(numbers.Exists(n => n % 5 == 0));
            //numbers.ForEach(n =>  {
            //    Console.WriteLine(n*5);
            //} );
        }
    }
}
