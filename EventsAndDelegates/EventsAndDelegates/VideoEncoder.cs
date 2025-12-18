using System;
using System.Threading;

namespace EventsAndDelegates
{
    public class VideoEncoder
    {
        // Define a delegate with and without arguments
        // public delegate void VideoEncodedEventHandler(object source, EventArgs args);        // Without args
        // public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);   // With args


        // Define an event based on the delegate
        // public event VideoEncodedEventHandler VideoEncoded;

        // Define an event with a generic delegate event handler
        // public event EventHandler VideoENcoded;                   // Without args
        public event EventHandler<VideoEventArgs> VideoEncoded;      // With args

        // The Event without args
        protected virtual void OnVideoEncoded()
        {
            // If there are subscribers, call them
            if (VideoEncoded != null)
            {
                // VideoEncoded(this, EventArgs.Empty);               // Without args
                VideoEncoded(this, new VideoEventArgs());       // With args
            }
        }

        // The Event with args
        protected virtual void OnVideoEncoded(Video video)
        {
            // If there are subscribers, call them
            if (VideoEncoded != null)
            {
                // VideoEncoded(this, EventArgs.Empty);               // Without args
                VideoEncoded(this, new VideoEventArgs() { Video = video});       // With args
            }
        }

        // Encode video
        public void Encode(Video video)
        {
            Console.WriteLine("Encoding video...");
            Thread.Sleep(3000);

            // Raise the Event
            // OnVideoEncoded();        // Without args
            OnVideoEncoded(video);      // With args
        }
    }
}