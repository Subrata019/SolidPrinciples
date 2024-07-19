using OpenClosedPrinciple.WithOCP.Interfaces;

namespace OpenClosedPrinciple.WithOCP.ConcreteClassses
{
    public class PayPalPayment : IPaymentMethod
    {
        public void ProcessPayment() { Console.WriteLine("Processing PayPal payment..."); }
    }
}
