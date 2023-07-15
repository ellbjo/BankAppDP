using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAppDP
{
    public class CheckingAccount : BankAccount
    {
        public CheckingAccount()
        {
            Logger.Instance.LogInformation("Checking account created");
        }
    }
}
