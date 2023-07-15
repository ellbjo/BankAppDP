using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAppDP
{
    //CheckingBank are Concrete Creators in the Factory pattern
    public class CheckingBank : Bank
    {
        //Overriding the Factory Method to produce a "Concrete Product", CheckingAccount
        public override BankAccount CreateAccount()
        {
            return new CheckingAccount();
        }
    }
}
