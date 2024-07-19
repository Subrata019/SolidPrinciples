using OpenClosedPrinciple.WithOCP.Interfaces;

namespace OpenClosedPrinciple.WithOCP.ConcreteClassses
{
    public class CreditCardPayment : IPaymentMethod
    {
        public void ProcessPayment() { Console.WriteLine("Processing credit card payment..."); }
    }
}
