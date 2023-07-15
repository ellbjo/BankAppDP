using Microsoft.VisualBasic;

namespace BankAppDP
{
    internal class Program
    {

        //I Decided to use Singleton, Observable and Factory Method as my design patterns
        //PIN for Mock usage is 1234
        static void Main(string[] args)
        {

            Logger.Instance.LogInformation("Enter 1 for Savings account or 2 for Checking account");
            int choice = int.Parse(Console.ReadLine());

            Bank bank;
            if (choice == 1)
            {
                bank = new SavingsBank();
            }
            else 
            {
                bank = new CheckingBank();
            }

            //Here we use the Factory Method to create a BankAccount.We don't care if it's a SavingsAccount
            //or a CheckingAccount, as long as it's a BankAccount. This is the main point of the Factory pattern:
            //creating objects without specifying the exact class of object that will be created.

            var account = bank.CreateAccount();

            var emailNotification = new EmailNotification();
            account.RegisterObserver(emailNotification);

            Logger.Instance.LogInformation("Enter your pin:");
            int pin = int.Parse(Console.ReadLine());

            if (account.ValidatePin(pin))
            {
                Logger.Instance.LogInformation("Enter the amount to deposit:");
                decimal deposit = decimal.Parse(Console.ReadLine());

                account.Deposit(deposit);
                Logger.Instance.LogInformation("Enter the amount to withdraw:");
                decimal withdraw = decimal.Parse(Console.ReadLine());

                account.Withdraw(withdraw);
                Logger.Instance.LogInformation("Closing bank application!");

            }
            else
            {
                Logger.Instance.LogInformation("Restart the bank application to try again!");

            }

        }
    }
}