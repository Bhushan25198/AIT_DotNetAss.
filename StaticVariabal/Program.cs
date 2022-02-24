using System;

namespace StaticVariabal
{
    class Program
    {
        class Demo
        {
            public int a = 10;
            public static int b = 10;

            public void increment()
            {
                a++;
                b++;
            }

            public void print()
            {
                Console.WriteLine("a= "+a);
                Console.WriteLine("b= "+b);
            }
        }
        static void Main(string[] args)
        {
            Demo d = new Demo();
            d.increment();
            d.print();


            Demo d2 = new Demo();
            d2.increment();
            d2.print();
        }
    }
}
