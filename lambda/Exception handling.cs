using System;
using System.CodeDom;

namespace lambda
{
    public class ExceptionHandling
    {
        public static void Divide()
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int d = 0;
            if (y < 0) throw new MyException();
            try
            {
                d = x / y;
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("finally executed succefully");
            }
            
        }

        public static void PrintAge(int age)
        {
            if (age < 0) throw new MyException();
            Console.WriteLine(age);
        }
    }

    public class MyException : Exception
    {
        public MyException()
        {
            Console.WriteLine("denominatoer cant be Zero");
        }
    }
}