using System;

namespace LiesInsideCircleAss15
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, radius;
            int radius_square, coordinates_calculation;
            Console.WriteLine("Enter the X Coordinates of Circle:");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Y Coordinates o Circle:");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Radius of Circle:");
            radius = Convert.ToInt32(Console.ReadLine());
            radius_square = radius * radius;

            //And here at the origin (0,0) here
            coordinates_calculation = (x * x) + (y * y);
            if (coordinates_calculation == radius_square)
            {
                Console.WriteLine("Points Lies On The Circle");
            }
            if(coordinates_calculation> radius_square)
            {
                Console.WriteLine("Points Lies OutSide The Circle");
            }
            if(coordinates_calculation< radius_square)
            {
                Console.WriteLine("Points Lies Inside The Circle");
            }
            Console.ReadLine();
        }
    }
}
