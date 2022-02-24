using System;

namespace AbstractClass5
{
    class Program
        
    {

        public abstract class Shape
        {
            public abstract double CalculateArea();

        }

        public class Circle : Shape
        {
             public double Radius;
            public Circle(double radius)
            {
                Radius = radius;
            }
            public override double CalculateArea()
            {
                return (3.14 * Radius * Radius);
            }
        }

        public class Rectangle : Shape
        {
            public double Height;
            public double Width;

            public Rectangle(double height, double width)
            {
                Height = height;
                Width = width;

            }
            public override double CalculateArea()
            {
                return ( Height * Width);
            }
        }

            static void Main(string[] args)
        {
            Shape circle = new Shape();
            circle.CalculateArea();
            Shape rectangle = new Shape();
            rectangle.CalculateArea();

            Console.WriteLine("The Area of Circle" + circle );
            Console.WriteLine("The Area of Rectangle" + rectangle);
        }
    }
}
