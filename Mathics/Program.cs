using System;

namespace Mathics
{
    class Program
    {
        static int Adder(int x)
        {
            return x + 5;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            string x = Console.ReadLine();
            int y = int.Parse(x);
            Console.WriteLine(Adder(y));
        }

        
    }
}
