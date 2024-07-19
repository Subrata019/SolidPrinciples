using DependencyInversionPrinciple.WithDIP.Interfaces;

namespace DependencyInversionPrinciple.WithDIP.ConcreteClassses
{
    public class PayPalPayment : IPayment
    {
        public void ProcessPayment() { Console.WriteLine("Processing PayPal payment..."); }
    }
}
