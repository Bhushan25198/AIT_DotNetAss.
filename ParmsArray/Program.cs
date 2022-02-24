using System;

namespace ParamsArray
{
    class MathClass
    {
        public void Average(params double[] no)
        {
            double totale = 0;
            double avg = 0;

            for(int i = 0; i < no.Length; i++)
            {
                totale = totale + no[i];

            }

            avg = totale / no.Length;

            Console.WriteLine("Average is..." + avg);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MathClass obj = new MathClass();
            obj.Average(1, 2, 3, 4, 5, 6, 7, 8);
            obj.Average(10, 20, 30, 40);
            obj.Average(20, 50, 30);
        }
    }
}
