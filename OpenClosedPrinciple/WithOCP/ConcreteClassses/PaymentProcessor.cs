using OpenClosedPrinciple.WithOCP.Interfaces;

namespace OpenClosedPrinciple.WithOCP.ConcreteClassses
{
    public class PaymentProcessor
    {
        public void ProcessPayment(IPaymentMethod paymentMethod) { paymentMethod.ProcessPayment(); }
    }
}
