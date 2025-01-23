using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_problems
{
    internal class Program
    {

        public int add(int n, int m)
        {
            return n+m;

        }

        public double armstring(int n)
        {
            int m = n;
            double res = 0;
            int counter = 0;
            while (m > 0)
            {
                m = m / 10;
                counter++;
            }

            while (n > 0)
            {

                res = res + Math.Pow(n % 10, counter);
                n = n / 10;
            }
            return res;
        }

        public int lcm(int n, int m)
        {
            //int res = 0;
            if (n > m && n % m == 0) return n;
            else if (m > n && m % n == 0) return m;
            else if (n > m)
            {
                for (int i = 1; i < m; i++)
                {
                    if ((n * i) % m == 0) return n * i;
                }
            }
            else
            {
                for (int i = 1; i < n; i++)
                {
                    if ((m * i) % n == 0) return m * i;
                }
            }

            return n * m;

        }

        public List<int> primenums(int n)
        {
            List<int> l = new List<int>();
            bool ist = true;
            for (int i = 2; i <= n; i++)
            {
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        ist = false;
                        continue;
                    }
                }

                if (ist == true) l.Add(i);
                ist = true;

            }

            return l;
        }

        public static void Employee()
        {
            Random rn = new Random();
            int mark = rn.Next(0, 2);

            int wagePerHr = 20;
            int fullDayHr = 8;
            int partTimeHr = 4;
            int workingDaysForMonth = 20;
            int dailyWageEmployee = wagePerHr * fullDayHr;
            int partTimWageEmployee = wagePerHr * partTimeHr;
            int wageForMonth = wagePerHr * fullDayHr * workingDaysForMonth;
            int wageForCondition = 100 * wagePerHr;
            bool loop = true;
            while (loop)
            {
                Console.WriteLine("1 Attendence\n2 DailyWage\n3 PartTimeWage\n4 wageForMonth \n5 WageForCondition\n6 exit");
                int select = int.Parse(Console.ReadLine());
                switch (select)
                {
                    case 1:
                        if (mark == 1) Console.WriteLine("prsent");
                        else Console.WriteLine("absent");
                        break;
                    case 2:
                        Console.WriteLine("DailyWage : " + dailyWageEmployee);
                        break;
                    case 3:
                        Console.WriteLine("PartTimeWage : " + partTimWageEmployee);
                        break;
                    case 4:
                        Console.WriteLine("wageForMonth : " + wageForMonth);
                        break;
                    case 5:
                        Console.WriteLine("Wage for Condition : "+wageForCondition);
                        break;
                   case 6:
                        loop = false;
                        break;
                    default:
                        Console.WriteLine("number is not present");
                        break;

                }
            }

        }

        public void ShowGrade(int n)
        {
            if(n>89) Console.WriteLine("A");
            else if (n > 79 && n<90) Console.WriteLine("B");
            else if (n > 69 && n<80) Console.WriteLine("C");
            else if (n > 59 && n<70) Console.WriteLine("D");
            else Console.WriteLine("F");
        }

        

        public void TemperatureConverter()
        {
            Console.WriteLine("Temperature Converter");
            Console.WriteLine("Select conversion type:");
            Console.WriteLine("1. Celsius to Fahrenheit");
            Console.WriteLine("2. Fahrenheit to Celsius");

            string choice = Console.ReadLine();

            double temperature;

            switch (choice)
            {
                case "1":
                    Console.Write("Enter temperature in Celsius: ");
                    temperature = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(temperature+"c is equal to "+((temperature*9/5)+32)+"f");
                    break;

                case "2":
                    Console.Write("Enter temperature in Fahrenheit: ");
                    temperature = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(temperature+"F is equal to "+((temperature-32)*5/9 )+"C");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please select 1 or 2.");
                    break;
            }
        }

        public void TicketPrice()
        {
            int child = 60;
            int adult = 100;
            int senior = 80;
            float matinee = 1.5f;
            Console.Write("enter age : ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("enter time in 24hr format : ");
            int time = int.Parse(Console.ReadLine());
            bool isMatinee = false;
            if (time < 18) isMatinee = true;
            if (age < 12)
            {
                if (isMatinee) Console.WriteLine("ticket price : " + child);
                else Console.WriteLine("ticket price :" + matinee*child);
            }
            else if (age >= 12 && age < 65)
            {
                if (isMatinee) Console.WriteLine("ticket price : " +  adult);
                else Console.WriteLine("ticket price :" + matinee*adult);
            }
            else
            {
                if (isMatinee) Console.WriteLine("ticket price : " + senior);
                else Console.WriteLine("ticket price :" + matinee*senior);
            }
        }

        public void Verify(string user,string password)
        {
            Dictionary<string, string> d = new Dictionary<string, string>();
            d.Add("naveen", "naveen123");
            d.Add("sai", "sai123");
            if (d.ContainsKey(user))
            {
                if (password.Equals(d[user])) Console.WriteLine("login succesfull");
                else Console.WriteLine("password is incorrect");
            }
            else Console.WriteLine("user not exist");
        }


        static void Main(string[] args)
        {
            Program p = new Program();
            Action<object> cw = Console.WriteLine;
            int x1 = 1;
            int y1 = 3;
            int x2 = 4;
            int y2 = 5;
            double len = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            //Console.WriteLine(len);
            //double length = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));
            int line1 = 33;
            int line2 = 43;
            //if (line1.Equals(line2)) Console.WriteLine("equal");
            //else Console.WriteLine("not equal");


            int x = line1.CompareTo(line2);
            //if (x == 1) Console.WriteLine("line1 is greater");
            //else if (x == -1) Console.WriteLine("line 2 is greater");
            //else Console.WriteLine("lines are equal");

            //p.ShowGrade(56);
            //p.TemperatureConverter();
            //p.TicketPrice();
            //p.Verify("naveen", "naveen3");
            
            


        }
        
    }
}
