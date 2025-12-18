using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new book repository
            var books = new BookRepository().GetBooks();

            // LINQ Query Operators
            var cheaperBooks =
                from b in books
                where b.Price < 10          // Use Linq Query Operator to get books under $10
                orderby b.Title             // Use Linq Query Operator to order books by title
                select b.Title;             // Use Linq Query Operator select only titles

            Console.WriteLine("");

            // Display books under $10
            foreach (var cheaperBook in cheaperBooks)
            {
                //Console.WriteLine(book.Title + " $" + book.Price);         // As book type without select
                Console.WriteLine(cheaperBook);                              // As string type with select
            }

            Console.WriteLine("");

            // LINQ Extension Methods
            var cheapBooks = books
                .Where(b => b.Price < 10)   // Use Linq where extension and lambda function to get books under $10
                .OrderBy(b => b.Title)      // Then use linq and lambda function to order by title
                .Select(b => b.Title);      // Than change cheapBooks type to string by selecting book title

            // Display books under $10
            foreach (var cheapBook in cheapBooks)
            {
                //Console.WriteLine(book.Title + " $" + book.Price);       // As book type without select
                Console.WriteLine(cheapBook);                              // As string type with select
            }

            Console.WriteLine("");

            // Get a single book and display title 
            var book = books.Single(b => b.Title == "ASP.NET MVC");
            Console.WriteLine(book.Title);

            Console.WriteLine("");

            // Get a single book and display title or default
            var book2 = books.SingleOrDefault(b => b.Title == "ASP.NET MVC 2");
            Console.WriteLine(book2 == null);

            Console.WriteLine("");

            // Get a first book with title C# Advanced Topics or null
            var book3 = books.FirstOrDefault(b => b.Title == "C# Advanced Topics");
            Console.WriteLine(book3.Title + " $" + book3.Price);

            Console.WriteLine("");

            // Get a last book with title C# Advanced Topics or null
            var book4 = books.LastOrDefault(b => b.Title == "C# Advanced Topics");
            Console.WriteLine(book4.Title + " $" + book4.Price);

            Console.WriteLine("");

            // skip first 2 books and get next 3
            var pagedBooks = books.Skip(2).Take(3);
            
            // Display paged books
            foreach (var pagedBook in pagedBooks)
                Console.WriteLine(pagedBook.Title);

            Console.WriteLine("");

            // Count  number of books
            var count = books.Count();
            Console.WriteLine("Number of books: " + count);

            Console.WriteLine("");

            // Display Max and Min prices of books
            var maxPrice = books.Max(b => b.Price);
            var minPrice = books.Min(b => b.Price);
            Console.WriteLine("Max Book Price: $" + maxPrice);
            Console.WriteLine("Min Book Price: $" + minPrice);

            Console.WriteLine("");

            // Display cost of all books
            var costOfCollection = books.Sum(b => b.Price);
            Console.WriteLine("Cost of Collection: $" + costOfCollection);

            Console.WriteLine("");
        }
    }
}
