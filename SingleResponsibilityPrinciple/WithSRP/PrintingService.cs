namespace SingleResponsibilityPrinciple.WithSRP
{
    public class PrintingService
    {
        public void PrintDetails(Book book)
        {
            // Code to print book details
            Console.WriteLine($"Title: {book.Title}");
            Console.WriteLine($"Author: {book.Author}");
            Console.WriteLine($"ISBN: {book.ISBN}");
        }
    }
}
