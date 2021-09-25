using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccount.Model
{
    class AccountFactory
    {
        public BaseAccount GetObject(int choice) 
        {
            switch (choice) {
                case 1:
                    BaseAccount b = new SavingAccount();
                    return b;
                case 2:
                    BaseAccount bb = new CheckingAccount();
                    return bb;

            }
            return null;
        }
    }
}
