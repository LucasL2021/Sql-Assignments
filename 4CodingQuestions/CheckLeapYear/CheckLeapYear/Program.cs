using System;

namespace CheckLeapYear
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the year you want to check if it is a leap year:");
            string str = Console.ReadLine();
            int year = Convert.ToInt32(str);
            CheckLeap(year);
        }
        public static void CheckLeap(int year) 
        {
            Boolean res;
            if ((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0)) res = true;
            else res = false;
            if (res) Console.WriteLine("This year is a leap year.");
            else Console.WriteLine("This year is not a leap year.");
        }
    }
}
