using System;

namespace ExceptionHandling
{
    // Custom YouTube exception for YouTube API
    public class YouTubeException : Exception
    {
        public YouTubeException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}