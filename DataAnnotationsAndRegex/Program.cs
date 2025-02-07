using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace DataAnnotationsAndRegex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("enter details");
            Console.WriteLine("entern your email");
            string name = Console.ReadLine();
            //Console.WriteLine("enter num:");
            //int num = int.Parse(Console.ReadLine());
            //Console.WriteLine("enter size:");


            //Console.WriteLine("enter phone : ");
            //string Phone = Console.ReadLine();

            EmailValidate p = new EmailValidate()
            {
                mail = name

            };
            //string dates = "Here are some dates:12/05/2021, 01-25-2020, and also 3/03/2022 (not valid) Important: 15/04/2023 and 11-12-2025 ";

            //MatchDates.matchDates(dates);

            var context = new ValidationContext(p);
            var results = new List<ValidationResult>();
            bool isValid = Validator.TryValidateObject(p, context, results, true);
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

            //string reg = @"[a-z\s]+[a-z\W]+";
            //Regex regex = new Regex(reg);
            //string str = "naveen is good boy {is'nt he} {is'nt }";
            //Match m = regex.Match(str);
            //if(m.Success) Console.WriteLine(m);
            //else Console.WriteLine("nulll");
            

        }
    }

    class Employee
    {
        [Required(ErrorMessage = "name is required")]
        [StringLength(10, MinimumLength = 3, ErrorMessage = "name should be less than 10 and greater than 2")]
        public string Name { get; set; }

        [Required(ErrorMessage = "password is required")]
        [MinLength(8, ErrorMessage = "password should be atleast 8 characters")]
        public string password { get; set; }
        [Required(ErrorMessage = "email is required")]
        [EmailAddress(ErrorMessage = "provide valid emialaddress")]
        public string Email { get; set; }
    }

    class Product
    {
        [Required(ErrorMessage = "product name is required")]
        [MaxLength(50, ErrorMessage = "name shoule be less than 50 ")]
        public string name { get; set; }
        [Required(ErrorMessage = "price is required")]
        [Range(1, 100, ErrorMessage = "price must be in range 1 to 1000")]
        public int price { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = "stock can't be negative")]
        public int stock { get; set; }
    }

    class EventRegistration
    {
        [Required(ErrorMessage = "name is required")]
        [MaxLength(30, ErrorMessage = "should be less than 30 characters")]
        public string name { get; set; }
        [Range(18, 60, ErrorMessage = "should be major")]
        public int age { get; set; }
        [RegularExpression(@"^\d{10}$",ErrorMessage = "must be exaclty 10 digits")]
        public string phone { get; set; }
    }

    class FileName
    {
        [Required(ErrorMessage = "name is required")]
        [RegularExpression(@"(.+\.pdf|.+\.docx)$",ErrorMessage = "must end with .docx or .pdf")]
        public string fileName { get; set; }
        [RegularExpression(@"(1kb|[2-4][0-9]{0,3}kb|[1-5]mb)$",ErrorMessage = "must be less  than 5120kb or less than  5mb")]
        public string filesize { get; set; }
    }

    class OrderManagement
    {
        [Required(ErrorMessage = "id is required")]
        [RegularExpression(@"^ORD-\d{0,10}",ErrorMessage = "must start with ORD- than numeric digits")]
        public string id { get; set; }
        [Required(ErrorMessage = "date is required")]
        [DataType(DataType.Date,ErrorMessage = "must be in format yyyy/mm/dd")]
        public DateTime date { get; set; }
    }

    class EmailValidate
    {
        [Required(ErrorMessage = "mail is must")]
        [RegularExpression(@"[a-zA-Z0-9.]+@[a-z]+(\.[a-z]+){0,2}")]
        public string mail { get; set; }
    }

    class PhoneNumber
    {
        [Required(ErrorMessage = "nummber is must")]
        [RegularExpression(@"(^[0-9]{10}$)|(^\+91\s+[0-9]{10}$)|(^[0-9]{3}-[0-9]{3}-[0-9]{4}$)|(^\([0-9]{3}\)\s+[0-9]{3}-[0-9]{4}$)",ErrorMessage = "us be in +91 XXXXXXXXXX or XXXXXXXXXX 0r (XXX) XXX-XXXX or XXX-XXX-XXXX")]
        public string number { get; set; }
    }

    class MatchDates
    {

        public static void matchDates(string s)
        {
            Regex reg = new Regex(@"(\d{2}\/\d{2}\/\d{4})|(\d{2}-\d{2}-\d{4})");
            MatchCollection matches = reg.Matches(s);
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
        }
    }

    class PasswordValidator
    {
        [Required(ErrorMessage = "must")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@#$%^&+=!])[A-Za-z\d@$!%*?&]{8,}$", ErrorMessage = "must use all")]
        public string pass { get;  set; }
    }

    
}
