using System;
using System.Collections.Generic;
namespace DemoArray
{
    class Program
    {
        static void Main(string[] args)
        {
          /*  ArrayList list = new ArrayList();
            list.Add(50);
            list.Add(40.25);
            list.Add("Hiii.");
            list.Add('b');
            list.Add(true);
            list.Insert(5, "NewVal");

            foreach (object o in list)
            {
                Console.WriteLine(o);
            }*/
            int[] arr = new int[5];
            Console.WriteLine("Enter 5 integers");

            for (int i = 0; i < arr.Length; i++) ;
            {
                Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("****************************************");

            foreach(int i in arr)
            {
                Console.WriteLine(i);
            }
            Array.Sort(arr);
            Array.Reverse(arr);
            Console.WriteLine("*************************************************");

            foreach(int i in arr)
            {
                Console.WriteLine(i);
            }
        }
    }
}
