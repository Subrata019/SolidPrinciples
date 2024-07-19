namespace SingleResponsibilityPrinciple.WithSRP
{
    public class EmailService
    {
        public void SendEmailNotification(string email, Book book)
        {
            Console.WriteLine($"Sending email to {email} about the book {book.Title}"); // Code to send email notification
        }
    }
}
