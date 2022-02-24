using System;

namespace UserAcceptPrimeNos
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, a;
            Console.WriteLine("Enter Any Number: ");
            n = Convert.ToInt32(Console.ReadLine());

            a = 0;
            i = 2;
            while(i <= n/2)
            {
                if (n % i == 0)
                {
                    a = 1;
                    break;
                }
                i++;
            }
            if (a == 0)

                Console.WriteLine(n + " Is prime Number");
              
            else
                Console.WriteLine(n + " Not a Prime Number");
            Console.ReadLine();
        }
    }
}
