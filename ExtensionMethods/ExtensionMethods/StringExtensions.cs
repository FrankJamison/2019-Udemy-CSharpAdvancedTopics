using System;
using System.Linq;

// Use namespace of class being extended
namespace System
{
    // Signature: Class name is the class you are extending and Extensions
    public static class StringExtensions
    {
        // Signature: public static return-type name(this type-extending name, arguments)
        public static string Shorten(this String str, int numberOfWords)
        {
            // If number of words < 0, throw exception
            if (numberOfWords < 0)
                throw new ArgumentOutOfRangeException("numberOfWords should be greater than or equal to 0.");

            // If number of words is 0, return empty string
            if (numberOfWords == 0)
                return "";

            // Split string into words
            var words = str.Split(' ');

            // If the number of words is less than the number to be shortened to, return original string
            if (words.Length <= numberOfWords)
                return str;

            // Use take extension to join the specified number of words with spaces and add ...
            return string.Join(" ", words.Take(numberOfWords)) + "...";
        }
    }
}