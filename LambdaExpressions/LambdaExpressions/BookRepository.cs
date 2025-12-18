using System.Collections.Generic;

namespace LambdaExpressions
{
    public class BookRepository
    {
        // Get a list of 3 initialized books
        public List<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book() {Title = "Title 1", Price = 5},
                new Book() {Title = "Title 2", Price = 7},
                new Book() {Title = "Title 3", Price = 17}
            };
        }
    }
}