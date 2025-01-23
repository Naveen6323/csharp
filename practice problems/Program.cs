using System;
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
                        Console.WriteLine("Wage for Condition ----> "+wageForCondition);
                        
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

        static void Main(string[] args)
        {
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

            Employee();




        }
        
    }
}
