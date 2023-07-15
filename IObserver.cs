using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAppDP
{
    //This declares the update method to be used in the observable pattern
    public interface IObserver
    {
        void Update(BankAccount account);
    }
}
