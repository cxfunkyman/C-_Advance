/*
 * Events:
 *  • A mechanism for communication between objects
 *  • Used in building Loosely Coupled Applications
 *  • Helps extending applications
 * 
 * Delegates:
 *  • Agreement / Contract between Publisher and Subscriber
 *  • Determines the signature of the event handler method in subscriber
 */


namespace EventsAndDelegates
{
    class Program
    {
        static void Main(string[] args) 
        {
            var video = new Video() { Title = "Video 1" };
            var videoEncoder = new VideoEncoder(); // publisher
            var mailService = new MailService(); // subscriber
            var messageService = new MessageService(); // subscriber

            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
            videoEncoder.VideoEncoded += messageService.OnVideoEncoded;

            videoEncoder.Encode(video);
        }
    }


}
