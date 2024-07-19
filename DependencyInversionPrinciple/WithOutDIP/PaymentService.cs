namespace DependencyInversionPrinciple.WithOutDIP
{
    public class PaymentService
    {
        private readonly CreditCardPayment creditCardPayment;

        public PaymentService() { creditCardPayment = new(); }

        public void MakePayment() { creditCardPayment.ProcessPayment(); }
    }
}
