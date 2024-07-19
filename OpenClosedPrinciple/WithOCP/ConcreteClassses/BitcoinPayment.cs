using OpenClosedPrinciple.WithOCP.Interfaces;

namespace OpenClosedPrinciple.WithOCP.ConcreteClassses
{
    public class BitcoinPayment : IPaymentMethod
    {
        public void ProcessPayment() { Console.WriteLine("Processing Bitcoin payment..."); }
    }
}
