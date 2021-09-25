using System;
using BankAccount.Model;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            int choice = menu.Print();
            AccountFactory ac = new AccountFactory();
            BaseAccount ba = ac.GetObject(choice);
            if (ba != null) {
                ba.CreateBaseAccount();
                ba.PrintBaseAccount();
            }
        }
    }

}
