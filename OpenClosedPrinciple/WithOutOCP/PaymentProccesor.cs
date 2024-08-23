namespace OpenClosedPrinciple.WithOutOCP
{
    public class PaymentProcessor
    {
        public void ProcessPayment(string paymentType)
        {
            if (paymentType == "CreditCard") Console.WriteLine("Processing credit card payment...");
            else if (paymentType == "PayPal") Console.WriteLine("Processing PayPal payment...");
            else if (paymentType == "Bitcoin") Console.WriteLine("Processing Bitcoin payment...");
            else Console.WriteLine("Unknown payment method.");
        }
    }
}
