using System;

namespace Delegates
{
    public class PhotoProcessor
    {
        // Process that takes a path to a photo sets delegate signature to take an object of type photo that has no return value
        public void Process(string path, Action<Photo> filterHandler)
        {
            // Load the photo from the path
            var photo = Photo.Load(path);

            // Use filter handler delegate to apply filters
            filterHandler(photo);

            // Save photo
            photo.Save();
        }
    }
}