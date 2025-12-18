using System;

namespace Delegates
{
    public class PhotoFilters
    {
        // Apply brightness filter to a photo
        public void ApplyBrightness(Photo photo)
        {
            Console.WriteLine("Apply brightness");
        }

        // Apply contrast filter to a photo
        public void ApplyContrast(Photo photo)
        {
            Console.WriteLine("Apply contrast");
        }

        // Apply resize option to a photo
        public void Resize(Photo photo)
        {
            Console.WriteLine("Resize photo");
        }
    }
}