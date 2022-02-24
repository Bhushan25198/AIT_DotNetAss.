using System;

namespace StraightLineAss._14
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1, x2, x3, y1, y2, y3;
            int slope1, slope2, slope3;
            
            Console.WriteLine("Enter The Values of X1 And Y1 Coordinates Of First Point");
            x1 = Convert.ToInt32(Console.ReadLine());
            y1 = Convert.ToInt32(Console.ReadLine());
           
            Console.WriteLine("Enter The Value Of X2 And Y2 Coordinates Of Second Point");
            x2 = Convert.ToInt32(Console.ReadLine());
            y2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter The Value Of X3 And Y3 Coordinates Of Third Point");
            x3 = Convert.ToInt32(Console.ReadLine());
            y3 = Convert.ToInt32(Console.ReadLine());

            slope1 = y2 - y1 / x2 - x1;
            slope2 = y3 - y1 / x3 - x1;
            slope3 = y3 - y2 / x3 - x2;

            if (slope1 == slope2 && slope1 == slope3)
            {
                Console.WriteLine("All Points Are Fall On One Straight Line ");
            }
            else
            {
                Console.WriteLine("All Points Are Not Fall On One Straight Line ");
            }
            Console.ReadKey();
        }
    }
}
