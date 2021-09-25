using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccount.Model
{
    class Menu
    {
        public int Print() 
        { 
            Console.WriteLine("Press 1 for saving account");
            Console.WriteLine("Press 2 for checking account");
            Console.Write("Enter choice = ");
            int foo = Convert.ToInt32(Console.ReadLine());
            return foo;
        }
    }
}
