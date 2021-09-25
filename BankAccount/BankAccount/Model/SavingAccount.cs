using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccount.Model
{
    class SavingAccount : BaseAccount
    {
        public int TransactionLimits { get; set; }
        public override void CreateBaseAccount()
        {
            base.CreateBaseAccount();
            Console.Write("Enter Transaction Limits");
            TransactionLimits = Convert.ToInt32(Console.ReadLine());
        }
        public override void PrintBaseAccount() 
        {
            base.PrintBaseAccount();
            Console.WriteLine("Transaction Limits are " + TransactionLimits);
        }

    }
}
