using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace DataAnnotationsAndRegex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter details");
            Console.WriteLine("entern your name");
            string name = Console.ReadLine();
            Console.WriteLine("enter age:");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter email : ");
            string email = Console.ReadLine();

            Employee emp = new Employee()
            {
                Name  = name,
                Age  = age,
                Email  = email

            };
            var context = new ValidationContext(emp);
            var results = new List<ValidationResult>();
            bool isValid = Validator.TryValidateObject(emp, context, results,true);
            if (isValid)
            {
                Console.WriteLine("emp  details are correct");
            }
            else
            {
                Console.WriteLine("validation errors");
                foreach (var VARIABLE in results)
                {
                    Console.WriteLine($"->{VARIABLE.ErrorMessage}");
                }
            }
        }
    }

    class Employee
    {
        [Required(ErrorMessage = "name is required")]
        [StringLength(10,MinimumLength = 3,ErrorMessage = "name should be less than 10 and greater than 2")]
        public string Name { get;  set; }

        [Required(ErrorMessage = "age is required")]
        [Range(18, 70, ErrorMessage = "age should be 18 or above")]
        public int Age { get; set; } = 0;
        [Required(ErrorMessage = "email is required")]
        [EmailAddress(ErrorMessage = "provide valid emialaddress")]
        public string Email { get; set; }
    }

    
}

