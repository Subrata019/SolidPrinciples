namespace SingleResponsibilityPrinciple.WithOutSRP
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }

        public Book(string title, string author, string isbn)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
        }

        public void Save()
        {
            Console.WriteLine($"Saving book {Title} by {Author} to the database"); // Code to save book details to a database
        }

        public void PrintDetails()
        {
            // Code to print book details
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"ISBN: {ISBN}");
        }

        public void SendEmailNotification(string email)
        {            
            Console.WriteLine($"Sending email to {email} about the book {Title}"); // Code to send email notification
        }
    }
}
