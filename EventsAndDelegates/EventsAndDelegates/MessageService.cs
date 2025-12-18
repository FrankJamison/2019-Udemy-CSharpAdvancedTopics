using System;

namespace EventsAndDelegates
{
    public class MessageService
    {
        //public void OnVideoEncoded(object source, EventArgs args)       // Without args
        //{
        //    Console.WriteLine("Message Service: Sending a text message...");
        //}

        public void OnVideoEncoded(object source, VideoEventArgs args)    // With args
        {
            Console.WriteLine("Message Service: Sending a text message..." + args.Video.Title);
        }
    }
}