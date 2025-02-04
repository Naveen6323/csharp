using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambda
{
    class Employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }

        public Employee(int id, string name, int age)
        {
            this.name= name;
            this.age = age;
            this.id= id;
        }
        public void ToString()
        {
            Console.WriteLine($"[id = {id}, name = {name}, age={age}]");
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
            string[] str = { "naveen", "vishal", "vaibhav" };
            char[] ch = { 'a', 'b', 'e', 'c' };
            MaxinArray.MaxInArray(arr);
            
            Names[] names = new Names[3];
            names[0] = new Names("naveen");
            names[1] = new Names("sam");
            names[2] = new Names("thanos");
            //MaxInArray(names);


            List<Employee> emp = new List<Employee>()
            {
                new Employee(1,"naveen",22),
                new Employee(2,"vishal",18),
                new Employee(3,"vaibhav",23),
                new Employee(4,"pranshu",17)
            };
            emp.Add(new Employee(5, "sam", 45));

            emp.ForEach(n =>
            {
                Console.WriteLine($"id={n.id},name={n.name},age={n.age}");
            });
            emp.RemoveAll(x => x.name == "vishal");
            emp.ForEach(x =>
            {
                if (x.name == "pranshu")
                {
                    Console.WriteLine("searched employee is");
                    Console.WriteLine($"id={x.id}, name={x.name},age={x.age}");

                }
            });
            var sortedEmployeeByName = emp.OrderBy(x => x.name);
            var sortedEmployeeByAge = emp.OrderBy(x => x.age);
            var reversSortedEmployeeByName = emp.OrderByDescending(x => x.name);

            List<int> numbers = new List<int> { 1, 8, 56, 8, 9, 2, 1, 5 };
            List<int> evennums = numbers.FindAll(n => n % 2 == 0);
            List<int> oddnums = numbers.FindAll(n => n % 2 == 1);

            //foreach (var employee in reversSortedEmployeeByName)
            //{
            //    employee.ToString();
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
