namespace SingleResponsibilityPrinciple.WithSRP
{
    public class BookRepository
    {
        public void Save(Book book)
        {
            Console.WriteLine($"Saving book {book.Title} by {book.Author} to the database"); // Code to save book details to a database
        }
    }
}
