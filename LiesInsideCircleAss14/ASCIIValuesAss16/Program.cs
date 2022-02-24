using System;

namespace ASCIIValuesAss16
{
    class Program
    {
        static void Main(string[] args)
        {
            char a;
            int b;

            Console.WriteLine("Enter A Character: ");
            a = Convert.ToChar(Console.ReadLine());
            b = (int)a;

            if (b >=65 && b <= 90)
            {
                Console.WriteLine("Entered Character Is Capital Letter: ");
            }
            if(b >=97 && b <= 122)
            {
                Console.WriteLine("Entered Character Is Small Letter: ");
            }

            if(b >=48 && b <= 57)
            {
                Console.WriteLine("Entered Character Is Special Symbols: ");
            }
            Console.ReadKey();

        }
    }
}
