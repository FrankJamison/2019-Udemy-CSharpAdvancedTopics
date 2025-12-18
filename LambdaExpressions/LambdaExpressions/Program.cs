
using System;

namespace LambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new book repository initialized with 3 books
            var books = new BookRepository().GetBooks();

            // Find all books (b) in the book repository list having a price less than 10 dollars
            var cheapBooks = books.FindAll(b => b.Price < 10);

            // Display all book titles that are less than 10 dollars
            foreach (var book in cheapBooks)
            {
                Console.WriteLine(book.Title);
            }

        }
    }
}
