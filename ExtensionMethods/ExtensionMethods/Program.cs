
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            // Long blog post 
            string post = "This is supposed to be a very long blog post blah blah blah...";

            // Use our string extension to shorten string.
            var shortenedPost = post.Shorten(5);

            // Display shortened post
            Console.WriteLine(shortenedPost);

            // Generic list of numbers
            IEnumerable<int> numbers = new List<int>() { 1, 5, 3, 10, 2, 18 };

            // Use predefined max extension
            var max = numbers.Max();

            // Display max number
            Console.WriteLine(max);

        }
    }
}
