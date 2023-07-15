using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAppDP
{
    //This method is being used to notify the observables when the ballanced is changed
    public class EmailNotification : IObserver
    {
        public void Update(BankAccount account)
        {
            // Send an email to the user
            Console.WriteLine("Email sent to user about balance change");
        }
    }
}
