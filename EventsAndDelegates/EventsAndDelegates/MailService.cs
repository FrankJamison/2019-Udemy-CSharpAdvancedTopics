using System;

namespace EventsAndDelegates
{
    public class MailService
    {
        //public void OnVideoEncoded(object source, EventArgs args)       // Without args
        //{
        //    // Send Email once video is encoded
        //    Console.WriteLine("Mail Service: Sending an email...");
        //}

        public void OnVideoEncoded(object source, VideoEventArgs args)    // With args
        {
            // Send Email once video is encoded
            Console.WriteLine("Mail Service: Sending an email..." + args.Video.Title);
        }
    }
}