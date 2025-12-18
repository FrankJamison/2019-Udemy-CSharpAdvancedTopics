using System.ComponentModel.DataAnnotations;

namespace EventsAndDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new video
            var video = new Video() {Title = "Video 1"};

            // Create a new video encoder
            var videoEncoder = new VideoEncoder();      // Publisher

            // Create new mail service
            var mailService = new MailService();        // Subscriber

            // Create a new message service
            var messageService = new MessageService();  // Subscriber

            // Subscriptions 
            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;        // Event Handler
            videoEncoder.VideoEncoded += messageService.OnVideoEncoded;     // Event Handler

            // Encode the video
            videoEncoder.Encode(video);
        }
    }
}
