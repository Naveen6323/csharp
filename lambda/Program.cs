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
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 8, 56, 8, 9, 2, 1, 5 };
            List<int> evennums = numbers.FindAll(n => n % 2 == 0);
            List<int> oddnums = numbers.FindAll(n => n % 2 == 1);
            //foreach (var even in evennums)
            //{
            //    Console.WriteLine(even);
            //}
            //foreach (var odd in oddnums)
            //{
            //    Console.WriteLine(odd);
            //}

            List<long> newl = numbers.ConvertAll(n=>(long)n);
            int[] arr = new int[8];
            numbers.CopyTo(arr);
            
            //Console.WriteLine(numbers.Exists(n => n % 5 == 0));
            //numbers.ForEach(n =>  {
            //    Console.WriteLine(n*5);
            //} );
            List<Employee> emp = new List<Employee>()
            {
                new Employee(1,"naveen",22),
                new Employee(2,"vishal",18),
                new Employee(3,"vaibhav",23),
                new Employee(4,"pranshu",17)
            };
            //var major = emp.FindAll(x => x.name[0] == 'v');
            //major.ForEach(n =>
            //{
            //    Console.WriteLine($"id={n.id},name={n.name},age={n.age}");
            //});
            var nameWithV = emp.Select(x => x.name[0]=='v');
            var sortedEmployeeByAge = emp.OrderBy(x => x.age);
            //foreach (var employee in sortedEmployeeByAge)
            //{
            //    Console.WriteLine($"id={employee.id},name={employee.name},age={employee.age}");
            //}

            //emp = emp.FindAll(x => x.name != "naveen");
            emp.RemoveAll(x => x.name == "naveen");
            emp.ForEach(n=>{ Console.WriteLine($"id={n.id},name={n.name},age={n.age}"); });

        }
    }
}
