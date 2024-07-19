
using SingleResponsibilityPrinciple.WithSRP;
using WithOutSRPBook = SingleResponsibilityPrinciple.WithOutSRP.Book;


Console.WriteLine("**********  With out Single Responsibility Principle  **********");

WithOutSRPBook withOutSRPbook = new("Treassure Island", "Robert Louis Stevenson", "123456789");
withOutSRPbook.Save();
withOutSRPbook.PrintDetails();
withOutSRPbook.SendEmailNotification("user@example.com");


Console.WriteLine("\n\n**********    With Single Responsibility Principle    **********");

Book book = new("Treassure Island", "Robert Louis Stevenson", "123456789");
BookRepository bookRepo = new();
PrintingService printingService = new ();
EmailService emailService = new();

bookRepo.Save(book);
printingService.PrintDetails(book);
emailService.SendEmailNotification("user@example.com", book);