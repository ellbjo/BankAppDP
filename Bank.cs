using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAppDP
{
    // The Bank is the superclass/creator in the Factory pattern
    public abstract class Bank
    {
        // CreateAccount is the "Factory Method"
        public abstract BankAccount CreateAccount();
    }
}
