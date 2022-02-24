using System;

namespace CalculateAss4
{

    class Rectangle
    {
        public void cal(int length, int breadth, out double area, out double perimeter)
        {


            area = length * breadth;
            perimeter = 2 * length + 2 * breadth;


        }
        class Program
        {


            static void Main(string[] args)
            {
                double area;
                double perimeter;
                Console.WriteLine("Please Enter The Length And Breadth of Rectangle");
                int length = Convert.ToInt32(Console.ReadLine());
                int breadth = Convert.ToInt32(Console.ReadLine());


                Rectangle r = new Rectangle();
                r.cal(length, breadth, out area, out perimeter);
                Console.WriteLine("Area Of Rectangle = " + area +  "Perimeter of Rectangle = " + perimeter);
                Console.ReadKey();


            }

        }
    }

    
    
        

    
        
    
}
