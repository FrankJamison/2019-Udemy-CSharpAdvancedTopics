
using System;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new photo processor object
            var processor = new PhotoProcessor();

            // Create a new photo filters object
            var filters = new PhotoFilters();

            // Use filter handler delegate to apply filters
            // Action<T> is generic delegate that takes up to 16 parameters and does not return a value
            // Func<T> is a generic delegate that takes up to 16 parameters and returns a value
            Action<Photo> filterHandler = filters.ApplyBrightness;
            filterHandler += filters.ApplyContrast;
            filterHandler += RemoveRedEyeFilter;

            // Add filter handler delegate to process method of photo processor
            processor.Process("photo.jpg", filterHandler);
        }

        // New filter conforming to delegate signature
        static void RemoveRedEyeFilter(Photo photo)
        {
            Console.WriteLine("Apply RemoveRedEye");
        }
    }
}
