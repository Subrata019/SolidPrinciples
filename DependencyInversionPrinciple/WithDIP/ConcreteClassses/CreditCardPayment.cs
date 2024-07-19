using DependencyInversionPrinciple.WithDIP.Interfaces;

namespace DependencyInversionPrinciple.WithDIP.ConcreteClassses
{
    public class CreditCardPayment : IPayment
    {
        public void ProcessPayment() { Console.WriteLine("Processing credit card payment..."); }
    }
}
