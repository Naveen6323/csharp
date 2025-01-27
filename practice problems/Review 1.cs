using System;
using System.Runtime.InteropServices;

namespace practice_problems
{
    public class Review_1
    {
        public static void SwapNums(int a, int b)
        {
            Console.WriteLine("a:"+a);
            Console.WriteLine("b:" + b);

            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("after swap");
            Console.WriteLine("a:" + a);
            Console.WriteLine("b:" + b);
        }

        public static void Conversion()
        {
            double d = 23.5664;
            int a = (int)d;//explit

            int b = 534;
            double c = b;//implicit

            //int to string
            string s = a.ToString();
            Console.WriteLine(s);
            

        }

        public static void FibonacciSeries(int n)
        {
            int first = 0;
            int second = 1;
            int next;
            while (n > 0)
            {
                Console.Write(first+" ");
                
                next = first + second;
                first = second;
                second = next;
                n--;
            }
        }

        public static void MultiplicationTable(int a)
        {
            for(int i = 1;i<=10;i++)
            {
                Console.Write(a*i+" ");
            }
        }

        

    }
    abstract class Shape
    {
        public abstract void CalculateArea();

        public static void DisplayInfo(double area, string shape)
        {
            Console.WriteLine($"area of {shape} : " + area);
        }
    }

    class Circle : Shape
    {
        int r;
        double area;
        public Circle(int r)
        {
            this.r = r;
        }
        public override void CalculateArea()
        {
            area = Math.PI * r * r;
            DisplayInfo(area, "circle");
        }

    }

    class Rectangle : Shape
    {
        int l;
        int b;
        int area;
        public Rectangle(int l,int b)
        {
            this.l = l;
            this.b = b;
        }
        public override void CalculateArea()
        {
            area = l * b;
            DisplayInfo(area, "Rectangle");
        }
    }
    class Triangle : Shape
    {
        int l;
        int b;
        float area;
        public Triangle(int l, int b)
        {
            this.l = l;
            this.b = b;
        }
        public override void CalculateArea()
        {
            area = l * b*0.5f ;
            DisplayInfo(area, "Triangle");
        }
    }

    public class Modif
    {

        class A
        {
            //Modif m = new Modif();


        }

    }
}
