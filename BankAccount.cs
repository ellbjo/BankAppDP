using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAppDP
{
    //This represents the bankaccount baseclass and is the "product" in the factory pattern and this one implements observable pattern that will notify all the observers then the balanced is changed
    public abstract class BankAccount : IObservable
    {
        private static readonly int CorrectPin = 1234; // the static pin value for mock
        protected decimal Balance { get; set; }

        // Here is the list of observers
        private List<IObserver> _observers = new List<IObserver>();

        public void RegisterObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (var observer in _observers)
            {
                observer.Update(this);
            }
        }

        public void Deposit(decimal amount)
        {
            Balance += amount;
            Logger.Instance.LogInformation($"{amount} has been deposited. New balance is {Balance}");
            NotifyObservers();
        }

        public void Withdraw(decimal amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
                Logger.Instance.LogInformation($"{amount} has been withdrawn. New balance is {Balance}");
                NotifyObservers();
            }
            else
            {
                Logger.Instance.LogError("Insufficient funds");
            }
        }

        public bool ValidatePin(int pin)
        {
            if (pin == CorrectPin)
            {
                Logger.Instance.LogInformation("Pin validation successful");
                return true;
            }
            else
            {
                Logger.Instance.LogError("Invalid pin");
                return false;
            }
        }
    }

}
