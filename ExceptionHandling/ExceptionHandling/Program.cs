
using System;
using System.IO;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            // Try catch example. Must be most specific to most generic 
            try
            {
                var calculator = new Calculator();
                calculator.Divide(5, 0);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("You cannot divide by 0.");
            }
            catch (ArithmeticException)
            {

            }

            // Example of finally block to cleanup stream reader
            try
            {
                // Calls finally block with dispose method under the hood
                using (var streamReader = new StreamReader(@"C:\file.zip"))
                {
                    var content = streamReader.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Sorry, an unexpected error has occurred.");
                Console.WriteLine("");
            }

            // Create API and get videos
            try
            {
                var api = new YouTubeApi();
                var videos = api.GetVideos("mosh");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
