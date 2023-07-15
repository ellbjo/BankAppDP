using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAppDP
{
    public class SavingsAccount : BankAccount
    {
        public SavingsAccount()
        {
            Logger.Instance.LogInformation("Savings account created");
        }
    }
}
