using System;
using System.Collections.Generic;
namespace DemoStackGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> s = new Stack<int>();
            s.Push(1);
            s.Push(2);
            s.Push(3);
            s.Push(4);

            foreach (int o in s)
            {
                Console.WriteLine(o);
            }
        }
    }
}
