namespace LibraryOOP
{
    internal class Program
    {
        static void Main()
        {
            Books book = new Books("Harry Potter and the Philosopher's Stone", "J.K. Rowling", 1997);
            Console.WriteLine(book.BookInfo());
            Console.WriteLine(book.CheckAvailability());
        }
    }
}