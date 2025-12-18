using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            // Add numbers to generic list
            var numbers = new GenericList<int>();
            numbers.Add(10);

            // Add books to generic list
            var books = new GenericList<Book>();
            books.Add(new Book());

            // Add key value pairs to generic dictionary
            var dictionary = new GenericDictionary<string, Book>();
            dictionary.Add("1234", new Book());

            // Create new nullable object of type int
            var number = new Nullable<int>();
            Console.WriteLine("Has Value ? " + number.HasValue);
            Console.WriteLine("Value: " + number.GetValueOrDefault());
        }
    }
}
