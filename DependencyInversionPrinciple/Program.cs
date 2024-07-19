using DependencyInversionPrinciple.WithDIP.ConcreteClassses;
using DependencyInversionPrinciple.WithDIP.Interfaces;
using WithOutDIPPaymentService = DependencyInversionPrinciple.WithOutDIP.PaymentService;


Console.WriteLine("**********  With out Dependency Inversion Principle  **********");

WithOutDIPPaymentService withOutDIPPaymentService = new();
withOutDIPPaymentService.MakePayment();


Console.WriteLine("\n\n**********    With Dependency Inversion Principle    **********");

IPayment creditCardPayment = new CreditCardPayment();
PaymentService paymentService = new PaymentService(creditCardPayment);
paymentService.MakePayment();

IPayment payPalPayment = new PayPalPayment();
PaymentService payPalPaymentService = new PaymentService(payPalPayment);
payPalPaymentService.MakePayment();