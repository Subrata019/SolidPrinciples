using DependencyInversionPrinciple.WithDIP.Interfaces;

namespace DependencyInversionPrinciple.WithDIP.ConcreteClassses
{
    public class PaymentService
    {
        private readonly IPayment Payment;

        public PaymentService(IPayment payment) { Payment = payment; }

        public void MakePayment() { Payment.ProcessPayment(); }
    }
}
