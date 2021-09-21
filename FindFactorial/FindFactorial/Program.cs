using System;

namespace FindFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type the number you want to find the factorial:");
            string str = Console.ReadLine();
            int a = Convert.ToInt32(str);
            int res = 1;
            while (a > 1) 
            {
                res *= a;
                a--;
            }
            Console.WriteLine($"The factorial is {res}");

        }
    }
}
