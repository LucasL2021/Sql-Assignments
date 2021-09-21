using System;

namespace PrimeOrNot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number you want to judge whether it is a prime number");
            string str = Console.ReadLine();
            int a = Convert.ToInt32(str);
            IsPrime(a);
        }
        public static void IsPrime(int a) 
        {
            Boolean res = true;
            if (a < 2) res = false;
            for (int i = 2; i < a; i++) {
                if (a % i == 0) {
                    res = false;
                    break;
                }
            }
            if (res) Console.WriteLine("This number is a prime number");
            else Console.WriteLine("This number is not a prime number");

        }
    }
}
