using OpenClosedPrinciple.WithOCP.ConcreteClassses;
using OpenClosedPrinciple.WithOCP.Interfaces;
using WithOutOCPPaymentProcessor = OpenClosedPrinciple.WithOutOCP.PaymentProcessor;


Console.WriteLine("**********  With out Open Closed Principle  **********");

WithOutOCPPaymentProcessor withOutOCPProcessor = new();
withOutOCPProcessor.ProcessPayment("CreditCard");
withOutOCPProcessor.ProcessPayment("PayPal");
withOutOCPProcessor.ProcessPayment("Bitcoin");


Console.WriteLine("\n\n**********    With Open Closed Principle    **********");

PaymentProcessor processor = new();

IPaymentMethod creditCard = new CreditCardPayment();
IPaymentMethod payPal = new PayPalPayment();
IPaymentMethod bitcoin = new BitcoinPayment();

processor.ProcessPayment(creditCard);
processor.ProcessPayment(payPal);
processor.ProcessPayment(bitcoin);