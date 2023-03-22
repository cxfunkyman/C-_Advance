using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    public class VideoEncoder
    {
        /* Let's give this class the ability to publish an event, there are 3 steps to follow:
        *
        *   1- Define a delegates (contract or agreetment between publisher and subscriber)
        *   2- Define an event based on that delegate.
        *   3- Rise the event
        */

        // To define or declare a delegate we start with public because
        //we want it to be accessible, then keyword 'delegate'
        //by convension the name we use 'name' + 'EventHandler'
        //step 1
        //public delegate void VideoEncodedEventHandler(object source, EventArgs args);//base args
        //public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);//custom args with video info
        
        //for not create custom delegate .NET have a delegate type which is called
        // • EventHandler (normal form)
        // • EventHandler<TEventArgs> (generic form)
        //step 2
        //public event VideoEncodedEventHandler VideoEncoded;
        public event EventHandler<VideoEventArgs> VideoEncoded; // sending additional data
        //public event EventHandler VideoEncoded; // without sending additional data

        public void Encode(Video video) 
        {
            Console.WriteLine("Encoding Video....");
            Thread.Sleep(3000);

            OnVideoEncoded(video);
        }
        //step 3
        //by convention is suggested that the event publisher methods should
        // be PROTECTED, VIRTUAL and VOID, the name should start with ON and
        // the name, if is executed before the process mput ing, like ENCODING
        // if is after the process use past tense like ENCODED
        protected virtual void OnVideoEncoded(Video video) 
        { 
            if (VideoEncoded != null) 
            {
                //if not sending anything use EventArgs.Empty
                //VideoEncoded(this, EventArgs.Empty);
                VideoEncoded(this, new VideoEventArgs() { video = video});
            }
        }
    }
}
