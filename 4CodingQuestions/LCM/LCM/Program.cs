using System;

namespace LCM
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers you want to find their lease common multiple(the format should be like '20,30')");
            string[] str = Console.ReadLine().Split(',');
            int a = Convert.ToInt32(str[0]);
            int b = Convert.ToInt32(str[1]);
            Console.WriteLine("Their lease common multiple is " + LCM(a, b));
        }

        public static int GCD(int a, int b) 
        {
            if (a < b) 
            {
                int temp = b;
                b = a;
                a = temp;
            }
            return (a % b == 0) ? b : GCD(a % b, b);
        
        }
        public static int LCM(int a, int b) 
        {
            return a * b / GCD(a, b);
        }
    }
}
