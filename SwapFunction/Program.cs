using System;

namespace SwapFunction
{
    class Mathclass
    {
        public void Swap(ref int a, ref int b)
        {
            int temp;
            temp = a;
            a = b;
            b = temp;
        }
    }
        class Program
    {
         static void Main(string[] args)
        {
            int x, y;
            Console.WriteLine("Enter 2 Numbers");
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Values befor Swaping x= {0} and y = {1}", x,y);

            Mathclass obj = new Mathclass();
            obj.Swap(ref x, ref y);

            Console.WriteLine("Values after Swaping x = {0} and y = {1}" ,x,y);
        }
    }
}
