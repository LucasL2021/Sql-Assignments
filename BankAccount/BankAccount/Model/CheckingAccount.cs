using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccount.Model
{
    class CheckingAccount : BaseAccount
    {
        public int DebitCardNumber { get; set; }
        public override void CreateBaseAccount()
        {
            base.CreateBaseAccount();
            Console.Write("Enter Debit Card Number: ");
            DebitCardNumber = Convert.ToInt32(Console.ReadLine());
         }
        public override void PrintBaseAccount()
        {
            base.PrintBaseAccount();
            Console.WriteLine("Debit Card Number is " + DebitCardNumber);
        }
    }
}
