using System.Diagnostics;
using System.Linq.Expressions;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System.Text.RegularExpressions;

namespace OnlyForReview
{
    internal class Review
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hii");
            //EmailValidation.IsValid("naveen@gmailcom");
            //DuplicateWords.AllMatches("this a is a a test test");
            //ExceptionHandling.Execute();
            //Bank.AddBalance(200);
            //Bank.WithDraw();
            //Stock.GetStock();
            //NumberChecker.StringEqual("ab","ab");
            //StringEqual.IsEqual("dsaj","dbk");
            //List<int> a = new List<int>(){1, 2, 3, 11, 22 };
            //NumberTransFormation.GreatThan10(a);
            //NumberTransFormation.MulByTwo(a);
            //NumberTransFormation.Max(a);


        }
    }

    class EmailValidation
    {
         static Regex reg = new Regex(@"[a-zA-Z0-9]+\@[a-zA-Z0-9]+(\.[a-z]+){1,2}");
        public static void IsValid(string s)
        {
            Match m = reg.Match(s);
            if(m.Length==0) Console.WriteLine("not valid");
            else
            {
                Console.WriteLine("is valid : "+m);
            }
        }
    }

    class PasswordStrengthChecker
    {
        static Regex reg = new Regex(@"(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[@$!#%*?&])[A-Za-z\d@$!%#*?&]{8,}");
        
        public static void IsValid(string s)
        {
            Match m = reg.Match(s);
            if (m.Length == 0) Console.WriteLine("not valid");
            else
            {
                Console.WriteLine("is valid:"+m);
            }

        }
    }
    class PhoneNumberValidation
    {
        static Regex reg = new Regex(@"(^\+\d{1,2}-\d{10}$)|(^\d{3}-\d{3}-\d{4}$)");

        public static void IsValid(string s)
        {
            Match m = reg.Match(s);
            if (m.Length == 0) Console.WriteLine("not valid");
            else
            {
                Console.WriteLine("is valid:" + m);
            }

        }
    }

    

    class ExceptionHandling
    {
        

        public static void Divide()
        {
            int a, b;
            try
            {
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());
                Console.WriteLine(a / b);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(" denominator cannot be zero");
            }
            catch (FormatException)
            {
                Console.WriteLine(" enter only nums");
            }
        }

        public static void Age(int age)
        {
            
                if (age < 0 || age > 150) throw new Exception("must be in 0 -150");

            
            
        }

        public static void Execute()
        {
            try
            {
                Age(-1);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }

    class InsufficientFundsException : Exception
    {
        public InsufficientFundsException(string s)
        {
            Console.WriteLine(s);
        }
    }

    class Bank
    {
        static int balance = 0;

        public static void AddBalance(int a)
        {
            balance += a;
        }

        public static void Draw(int a)
        {
            if (balance < a) throw new InsufficientFundsException(" balance is less than the withdrawing amount");
            balance -= a;
            Console.WriteLine(balance);
        }

        public static void WithDraw()
        {
            int a = int.Parse(Console.ReadLine());

            try
            {
                Draw(a);
            }
            catch (Exception e)
            {
                
            }
        }
    }

    class ProductOutOfStockException : Exception
    {
        public ProductOutOfStockException(string s)
        {
            Console.WriteLine(s);
        }
    }

    class Stock
    {
        static  int a = 0;
        
        public static void CheckStock()
        {
            
                if (a == 0) throw new ProductOutOfStockException("out of stock");
                Console.WriteLine("a:"+a);
            
        }

        public static void GetStock()
        {
            try
            {
                CheckStock();

            }
            catch (Exception e)
            {
                
            }
        }
    }

    class NumberChecker
    {

        public static void OddOrEven(int a)
        {
            Action <int>check =(num) =>
            {
                if (a % 2 == 0) Console.WriteLine("even");
                else Console.WriteLine("odd");
            };
            check(a);
        }

        public static void StringEqual(string a, string b)
        {
            Func<string, string, bool> check = (a, b) =>
            {
                if(a == b) return true;
                return a.Length == b.Length;
            };
            Console.WriteLine(check(a, b));
            
        }
    }

    class StringEqual
    {
        public static void IsEqual(string a, string b)
        {
            int x = a.Length.CompareTo(b.Length);
            if(x==0) Console.WriteLine("equal");
            else Console.WriteLine("not equal");

        }
    }

    class SwapNums
    {
        public static void Swap<T>(T a, T b)
        {
            Console.WriteLine("before swap: a:" + a + "\nb:" + b);
            T temp = a;
            a = b;
            b = temp;
            Console.WriteLine("after swap: a:" + a + "\nb:" + b);


        }
    }

    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Sub(int a, int b)
        {
            return a - b;
        }

        public int Mulyiply(int a, int b)
        {
            return a * b;
        }

        public int divide(int a, int b)
        {
            return a / b;
        }

        public bool IsValid(string a)
        {
            int l = 0;
            int r = a.Length - 1;
            while (l < r)
            {
                if (a[l] != a[r]) return false;
                l++;
                r--;
            }

            return true;
        }
    }

    class NumberTransFormation
    {
        public static void MulByTwo(List<int> a)
        {
            var b = a.Select(x => x * 2);
            foreach (var i in b)
            {
                Console.WriteLine(i);
            }
        }
        public static void GreatThan10(List<int> a)
        {
            var b = a.FindAll(x => x >10);
            foreach (var i in b)
            {
                Console.WriteLine(i);
            }
        }
        public static void Max(List<int> a)
        {
            var b = a.Max();
            Console.WriteLine(b+" is max");
        }
    }



}

