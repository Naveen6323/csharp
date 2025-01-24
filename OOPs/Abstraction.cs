using System;

namespace OOPs
{
    internal abstract class Area
    {
        public abstract void CalculateArea();
        public abstract void CalculatePerimeter();
        public void Display()
        {
            Console.WriteLine("Area and Perimeter of the shape");
        }
    }

    class Circle : Area
    {
        private double radius;
        public Circle(double radius)
        {
            this.radius = radius;
        }
        override
            public void CalculateArea()
        {

            Console.WriteLine("Area of Circle : " +(2*3.14*radius*radius));
        }
        override 
        public void CalculatePerimeter()
        {
            Console.WriteLine("Perimeter of Circle : " + (2 * 3.14 * radius));
        }
    }
}