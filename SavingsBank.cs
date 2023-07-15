using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAppDP
{
    //SavingsBank are "Concrete Creators" in the Factory pattern
    public class SavingsBank : Bank
    {
        //Overriding the Factory Method to produce a "Concrete Product" (SavingsAccount)
        public override BankAccount CreateAccount()
        {
            return new SavingsAccount();
        }
    }
}
