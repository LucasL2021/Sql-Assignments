using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccount.Model
{
    public class BaseAccount
    {
        private int accountNumber;
        private string userName; 
        private int deposit;
        //public int AccountNumber
        //{
        //    get { return AccountNumber; }
        //    set { AccountNumber = value; }
        //}
        public int AccountNumber { get; set; }
        public string UserName { get; set; }
        public int Deposit { get; set; }

        public virtual void CreateBaseAccount() 
        {
            Console.Write("Endter Account Number = ");
            AccountNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Endter User Name = ");
            UserName = Console.ReadLine();
            Console.Write("Endter Deposit = ");
            Deposit = Convert.ToInt32(Console.ReadLine());

        }
        public virtual void PrintBaseAccount()
        {
            Console.WriteLine("Account Number is " + AccountNumber);
            Console.WriteLine("User Name is " + userName);
            Console.WriteLine("Deposit is " + Deposit);
        }
    }
}
